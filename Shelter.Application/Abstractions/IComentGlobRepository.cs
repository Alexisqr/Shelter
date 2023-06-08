using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Application.Abstractions
{
    public interface IComentGlobRepository
    {
        Task<ICollection<ComentGlob>> GetAllComentGlob();
        Task<ComentGlob> GetComentGlobById(int comentglobId);
        Task<ComentGlob> CreateComentGlob(ComentGlob toCreate);
        Task<ComentGlob> UpdateComentGlob(string updateContent, int comentglobId);
        Task DeleteComentGlob(int comentglobId);
    }
}
