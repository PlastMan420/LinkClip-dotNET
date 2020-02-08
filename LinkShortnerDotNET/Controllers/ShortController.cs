using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkShortnerDotNET.Data;
using LinkShortnerDotNET.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LinkShortnerDotNET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShortController : ControllerBase
    {
        private readonly DataContext _context; // --> naming convention. add underscore to private data.
        private readonly IBaseRepository _repo;
        public ShortController(IBaseRepository repo, DataContext context)
        {
            this._context = context;
            this._repo = repo;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult FetchId(string id)
        {
            var Set = _repo.LookUp(id);
            if (Set == null)
                return NotFound();

            string Url = Set.Result.Url;
            //Response.Redirect(Url, true);
            return Ok(Url);
            
        }

        [HttpPost("link")] // api/short/link
        [AllowAnonymous]
        public async Task<IActionResult> link(LinkSet Set) 
        {
            await _repo.StoreId(Set);
            return StatusCode(201);
        }
    }
}