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
    public class ComentGlobRepository : IComentGlobRepository
        
    {
        private readonly ComentDbContext _context;
        public ComentGlobRepository(ComentDbContext context)
        {
            _context = context;
        }
        public async Task<ComentGlob> CreateComentGlob(ComentGlob toCreate)
        {
            toCreate.Date= DateTime.Now;
            _context.ComentGlobs.Add(toCreate);
            await _context.SaveChangesAsync();
            return toCreate;
        }

        public async Task DeleteComentGlob(int comentglobId)
        {
            var comentglob = await _context.ComentGlobs
                .FirstOrDefaultAsync(p => p.Id == comentglobId);
            if (comentglob == null) return;
            _context.ComentGlobs.Remove(comentglob);    
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<ComentGlob>> GetAllComentGlob()
        {
            return await _context.ComentGlobs.ToListAsync();
        }

        public async Task<ComentGlob> GetComentGlobById(int comentglobId)
        {
            return await _context.ComentGlobs.FirstOrDefaultAsync(p => p.Id == comentglobId);
        }

        public async Task<ComentGlob> UpdateComentGlob(string updateContent, int comentglobId)
        {

            var comentglob = await _context.ComentGlobs
                .FirstOrDefaultAsync(p => p.Id == comentglobId);
            comentglob.Date = DateTime.Now;
            comentglob.Text = updateContent;
            await _context.SaveChangesAsync();
            return comentglob;
        }
    }
}
