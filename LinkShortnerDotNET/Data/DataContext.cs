using LinkShortnerDotNET.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkShortnerDotNET.Data
{
    public class DataContext : DbContext
    {
        // initialize EF Core DbContext. class must extend DbContext
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        
        }
           public DbSet<LinkSet> Links { get; set; }
        
    }
}