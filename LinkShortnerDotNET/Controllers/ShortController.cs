using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkShortnerDotNET.Data;
using LinkShortnerDotNET.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LinkShortnerDotNET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShortController : ControllerBase
    {
        private readonly DataContext _context; // --> naming convention. add underscore to private data.

        public ShortController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet("index")]
        [AllowAnonymous]
        public string Index()
        {
            return "This is Index action method of StudentController";
        }

        [HttpPost("link")] // api/short/link
        [AllowAnonymous]
        public async Task<IActionResult> link(LinkSet Set) 
        {
            await _context.Links.AddAsync(Set);
            await _context.SaveChangesAsync();
            return StatusCode(201);
        }
    }
}