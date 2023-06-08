using MediatR;
using Shelter.Application.Queries;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Shelter.Application.Abstractions;

namespace Shelter.Application.QueryHandlers
{
    public class GetAllComentKindAnimalsHandlers : IRequestHandler<GetAllComentKindAnimals, ICollection<ComentKindAnimals>>
    {
        private readonly IComentKindAnimalsRepository _kindAnimalsRepository;
        public GetAllComentKindAnimalsHandlers(IComentKindAnimalsRepository kindAnimalsRepository)
        {
            _kindAnimalsRepository = kindAnimalsRepository;
        }
        public async Task<ICollection<ComentKindAnimals>> Handle(GetAllComentKindAnimals request, CancellationToken cancellationToken)
        {
            return await _kindAnimalsRepository.GetAllComentKindAnimals();
        }
    }
}
