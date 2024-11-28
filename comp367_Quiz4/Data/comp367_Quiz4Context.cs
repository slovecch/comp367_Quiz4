using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using comp367_Quiz4.Models;

namespace comp367_Quiz4.Data
{
    public class comp367_Quiz4Context : DbContext
    {
        public comp367_Quiz4Context (DbContextOptions<comp367_Quiz4Context> options)
            : base(options)
        {
        }

        public DbSet<comp367_Quiz4.Models.Product> Product { get; set; } = default!;
    }
}
