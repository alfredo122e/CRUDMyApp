using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Miapp.Models;

    public class MunicipalityContext : DbContext
    {
        public MunicipalityContext (DbContextOptions<MunicipalityContext> options)
            : base(options)
        {
        }

        public DbSet<Miapp.Models.Municipio> Municipio { get; set; }


    }
