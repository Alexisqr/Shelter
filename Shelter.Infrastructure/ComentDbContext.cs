using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Shelter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Infrastructure
{
    public class ComentDbContext : DbContext
    {
        public ComentDbContext(DbContextOptions options):base(options) {

        }

        public DbSet<ComentGlob> ComentGlobs { get; set; }
        public DbSet<ComentGood> ComentGoods { get; set; }
        public DbSet<ComentKindAnimals> ComentKindAnimalss { get; set; }
    }
}
