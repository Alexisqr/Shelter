using Domain.Entities;
using MediatR;
using Shelter.Application.Abstractions;
using Shelter.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Application.CommandHandlers
{
    public class UpdateComentKindAnimalsHandler : IRequestHandler<UpdateComentKindAnimals, ComentKindAnimals>
    {
        private readonly IComentKindAnimalsRepository _kindAnimalsRepository;
        public UpdateComentKindAnimalsHandler(IComentKindAnimalsRepository kindAnimalsRepository)
        {
            _kindAnimalsRepository = kindAnimalsRepository;   
        }
        public async Task<ComentKindAnimals> Handle(UpdateComentKindAnimals request, CancellationToken cancellationToken)
        {
            var Glob = await _kindAnimalsRepository.UpdateComentKindAnimals(request.ComentKindAnimalsText, request.ComentKindAnimalsId);
            return Glob;
        }
    }
}
