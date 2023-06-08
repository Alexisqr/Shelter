using Domain.Entities;
using Shelter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Application.Abstractions
{
    public interface IComentGoodRepository
    {
        Task<ICollection<ComentGood>> GetAllComentGood();
        Task<ComentGood> GetComentGoodById(int comentgoodId);
        Task<ComentGood> CreateComentGood(ComentGood toCreate);
        Task<ComentGood> UpdateComentGood(string updateContent, int comentgoodId);
        Task DeleteComentGood(int comentgoodId);
    }
}
