using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Salak_Gergely_Lab8.Models;

namespace Salak_Gergely_Lab8.Data
{
    public class Salak_Gergely_Lab8Context : DbContext
    {
        public Salak_Gergely_Lab8Context (DbContextOptions<Salak_Gergely_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }

        public DbSet<Salak_Gergely_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Salak_Gergely_Lab8.Models.BookCategory> BookCategory { get; set; }

        public DbSet<Salak_Gergely_Lab8.Models.Category> Category { get; set; }

    }
}
