using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Shelter.Application.Abstractions;
using Shelter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Infrastructure.Repositoties
{
    public class ComentKindOfAnimalsRepository : IComentKindAnimalsRepository
    {
        private readonly ComentDbContext _context;
        public ComentKindOfAnimalsRepository(ComentDbContext context)
        {
            _context = context;
        }
        public async Task<ComentKindAnimals> CreateComentKindAnimals(ComentKindAnimals toCreate)
        {
            toCreate.Date = DateTime.Now;
            _context.ComentKindAnimalss.Add(toCreate);
            await _context.SaveChangesAsync();
            return toCreate;
        }

        public async Task DeleteComentKindAnimals(int comentkindanimalsId)
        {
            var comentkindanimals = await _context.ComentKindAnimalss
               .FirstOrDefaultAsync(p => p.Id == comentkindanimalsId);
            if (comentkindanimals == null) return;
            _context.ComentKindAnimalss.Remove(comentkindanimals);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<ComentKindAnimals>> GetAllComentKindAnimals()
        {
            return await _context.ComentKindAnimalss.ToListAsync();
        }

        public async Task<ComentKindAnimals> GetComentKindAnimalsById(int comentkindanimalsId)
        {
            return await _context.ComentKindAnimalss.FirstOrDefaultAsync(p => p.Id == comentkindanimalsId);
        }

        public async Task<ComentKindAnimals> UpdateComentKindAnimals(string updateContent, int comentkindanimalsId)
        {

            var comentkindanimals = await _context.ComentKindAnimalss
                .FirstOrDefaultAsync(p => p.Id == comentkindanimalsId);
            comentkindanimals.Date = DateTime.Now;
            comentkindanimals.Text = updateContent;
            await _context.SaveChangesAsync();
            return comentkindanimals;
        }
    }
}

