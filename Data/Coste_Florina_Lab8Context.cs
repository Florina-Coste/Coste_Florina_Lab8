using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coste_Florina_Lab8.Models;

namespace Coste_Florina_Lab8.Data
{
    public class Coste_Florina_Lab8Context : DbContext
    {
        public Coste_Florina_Lab8Context (DbContextOptions<Coste_Florina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Coste_Florina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Coste_Florina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Coste_Florina_Lab8.Models.Category> Category { get; set; }
    }
}
