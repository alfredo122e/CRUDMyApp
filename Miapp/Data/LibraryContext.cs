using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using primeraAplicacion.Models;

    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<primeraAplicacion.Models.Perro> Perro { get; set; }
    }
