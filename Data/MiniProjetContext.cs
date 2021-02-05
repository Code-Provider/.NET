using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniProjet.Models;

namespace MiniProjet.Models
{
    public class MiniProjetContext : DbContext
    {
        public MiniProjetContext (DbContextOptions<MiniProjetContext> options)
            : base(options)
        {
        }

        public DbSet<MiniProjet.Models.Book> Book { get; set; }

        public DbSet<MiniProjet.Models.VideoGame> VideoGame { get; set; }
    }
}
