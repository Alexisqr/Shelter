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
    public class DeleteComentKindAnimalsHandler : IRequestHandler<DeleteComentKindAnimals>
    {
        private readonly IComentKindAnimalsRepository _kindAnimalsRepository;
        public DeleteComentKindAnimalsHandler(IComentKindAnimalsRepository kindAnimalsRepository)
        {
            _kindAnimalsRepository = kindAnimalsRepository;
        }
     
        public async Task<Unit> Handle(DeleteComentKindAnimals request, CancellationToken cancellationToken)
        {
            await _kindAnimalsRepository.DeleteComentKindAnimals(request.ComentKindAnimalsId);
            return Unit.Value;
        }
    }
}
