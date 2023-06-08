using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Application.Abstractions
{
    public interface IComentKindAnimalsRepository
    {
        Task<ICollection<ComentKindAnimals>> GetAllComentKindAnimals();
        Task<ComentKindAnimals> GetComentKindAnimalsById(int comentkindanimalsId);
        Task<ComentKindAnimals> CreateComentKindAnimals(ComentKindAnimals toCreate);
        Task<ComentKindAnimals> UpdateComentKindAnimals(string updateContent, int comentkindanimalsId);
        Task DeleteComentKindAnimals(int comentkindanimalsId);
    }
}
