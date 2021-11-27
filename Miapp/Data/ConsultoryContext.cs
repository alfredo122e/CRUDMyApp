using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Miapp.Models;

    public class ConsultoryContext : DbContext
    {
        public ConsultoryContext (DbContextOptions<ConsultoryContext> options)
            : base(options)
        {
        }

        public DbSet<Miapp.Models.Consultory> Consultory { get; set; }


    }
