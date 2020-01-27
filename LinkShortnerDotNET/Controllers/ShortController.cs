using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkShortnerDotNET.Data;
using LinkShortnerDotNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace LinkShortnerDotNET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShortController : Controller
    {
        private readonly DataContext _context; // --> naming convention. add underscore to private data.

        public ShortController(DataContext context)
        {
            this._context = context;
        }

        [HttpPost("linkgen")]
        public async Task<IActionResult> LinkGen(LinkSet linkSet)
        {

        }
        
    }
}