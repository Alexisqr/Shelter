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
    public class ComentGoodRepository : IComentGoodRepository
    {
        private readonly ComentDbContext _context;
        public ComentGoodRepository(ComentDbContext context)
        {
            _context = context;
        }
        public async Task<ComentGood> CreateComentGood(ComentGood toCreate)
        {
            toCreate.Date = DateTime.Now;
            _context.ComentGoods.Add(toCreate);
            await _context.SaveChangesAsync();
            return toCreate;
        }

        public async Task DeleteComentGood(int comentgoodId)
        {
       
            var comentgood = await _context.ComentGoods
                .FirstOrDefaultAsync(p => p.Id == comentgoodId);
            if (comentgood == null) return;
            _context.ComentGoods.Remove(comentgood);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<ComentGood>> GetAllComentGood()
        {
            return await _context.ComentGoods.ToListAsync();
        }

        public async Task<ComentGood> GetComentGoodById(int comentgoodId)
        {
            return await _context.ComentGoods.FirstOrDefaultAsync(p => p.Id == comentgoodId);
        }

        public async Task<ComentGood> UpdateComentGood(string updateContent, int comentgoodId)
        {

            var comentgood = await _context.ComentGoods
                .FirstOrDefaultAsync(p => p.Id == comentgoodId);
            comentgood.Date = DateTime.Now;
            comentgood.Text = updateContent;
            await _context.SaveChangesAsync();
            return comentgood;
        }
    
     }
}
