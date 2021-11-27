using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using primeraAplicacion.Models;

    public class PerroContext : DbContext
    {
        public PerroContext (DbContextOptions<PerroContext> options)
            : base(options)
        {
        }

        public DbSet<primeraAplicacion.Models.Owner> Owner { get; set; }
    }
