using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCOne.Models;

namespace MVCOne.Models
{
    public class MVCOneContext : DbContext
    {
        public MVCOneContext (DbContextOptions<MVCOneContext> options)
            : base(options)
        {
        }

        public DbSet<MVCOne.Models.Person> Person { get; set; }

        public DbSet<MVCOne.Models.Match> Match { get; set; }
    }
}
