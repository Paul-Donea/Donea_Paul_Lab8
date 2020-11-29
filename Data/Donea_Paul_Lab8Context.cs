using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Donea_Paul_Lab8.Models;

namespace Donea_Paul_Lab8.Data
{
    public class Donea_Paul_Lab8Context : DbContext
    {
        public Donea_Paul_Lab8Context (DbContextOptions<Donea_Paul_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Donea_Paul_Lab8.Models.Book> Book { get; set; }

        public DbSet<Donea_Paul_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Donea_Paul_Lab8.Models.Category> Category { get; set; }
    }
}
