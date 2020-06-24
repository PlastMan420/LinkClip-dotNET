using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkShortnerDotNET.Data;
using LinkShortnerDotNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LinkShortnerDotNET.Data
{
    public class BaseRepository : IBaseRepository
    {
        private readonly DataContext _context;

        public BaseRepository(DataContext context)
        {
            this._context = context;
        }
        public async Task<LinkSet> LookUp(string id)
        {
            var setId = await _context.Links.FirstOrDefaultAsync(x => x.LinkId == id).ConfigureAwait(false);

            return setId;
        }

        public async Task StoreId(LinkSet Set)
        {
            Set.LinkId = ToolKit.RandomString(8);
            await _context.Links.AddAsync(Set);
            await _context.SaveChangesAsync().ConfigureAwait(false);

        }
    }
}
