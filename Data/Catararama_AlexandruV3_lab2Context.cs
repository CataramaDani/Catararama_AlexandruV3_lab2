using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Catararama_AlexandruV3_lab2.Models;

namespace Catararama_AlexandruV3_lab2.Data
{
    public class Catararama_AlexandruV3_lab2Context : DbContext
    {
        public Catararama_AlexandruV3_lab2Context (DbContextOptions<Catararama_AlexandruV3_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Catararama_AlexandruV3_lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Catararama_AlexandruV3_lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Catararama_AlexandruV3_lab2.Models.Authors> Authors { get; set; } = default!;
        public DbSet<Catararama_AlexandruV3_lab2.Models.Category> Category { get; set; } = default!;
        public DbSet<Catararama_AlexandruV3_lab2.Models.Member> Member { get; set; } = default!;
        public DbSet<Catararama_AlexandruV3_lab2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
