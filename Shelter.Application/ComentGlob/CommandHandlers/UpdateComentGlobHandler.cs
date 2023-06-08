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
    public class UpdateComentGlobHandler : IRequestHandler<UpdateComentGlob, ComentGlob>
    {
        private readonly IComentGlobRepository _globRepository;
        public UpdateComentGlobHandler(IComentGlobRepository globRepository)
        {          
                _globRepository = globRepository;   
        }
        public async Task<ComentGlob> Handle(UpdateComentGlob request, CancellationToken cancellationToken)
        {
            var Glob = await _globRepository.UpdateComentGlob(request.ComentGlobText, request.ComentGlobId);
            return Glob;
        }
    }
}
