using Domain.Entities;
using MediatR;
using Shelter.Application.Abstractions;
using Shelter.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shelter.Application.QueryHandlers
{
    public class GetComentKindAnimalsByIdHandlers : IRequestHandler<GetComentKindAnimalsById, ComentKindAnimals>
    {
        private readonly IComentKindAnimalsRepository _kindAnimalsRepository;
        public GetComentKindAnimalsByIdHandlers(IComentKindAnimalsRepository kindAnimalsRepository)
        {
            _kindAnimalsRepository = kindAnimalsRepository;
        }
        public async Task<ComentKindAnimals> Handle(GetComentKindAnimalsById request, CancellationToken cancellationToken)
        {
            return await _kindAnimalsRepository.GetComentKindAnimalsById(request.ComentKindAnimalsId);
        }
    }
}
