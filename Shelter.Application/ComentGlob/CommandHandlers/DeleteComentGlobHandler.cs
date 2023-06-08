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
    public class DeleteComentGlobHandler : IRequestHandler<DeleteComentGlob>
    {
        private readonly IComentGlobRepository _globRepository;
        public DeleteComentGlobHandler(IComentGlobRepository globRepository)
        {
            _globRepository = globRepository;
        }
        public async Task<Unit> Handle(DeleteComentGlob request, CancellationToken cancellationToken)
        {
            await _globRepository.DeleteComentGlob(request.ComentGlobId);
            return Unit.Value;
        }
    }
}
