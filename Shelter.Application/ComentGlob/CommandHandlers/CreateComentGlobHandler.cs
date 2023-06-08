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
    public class CreateComentGlobHandler : IRequestHandler<CreateComentGlob, ComentGlob>
    {
        private readonly IComentGlobRepository _globRepository;
        public CreateComentGlobHandler(IComentGlobRepository globRepository)
        {
            _globRepository = globRepository;
        }
        public async Task<ComentGlob> Handle(CreateComentGlob request, CancellationToken cancellationToken)
        {
            var newGlob = new ComentGlob {
            Text = request.ComentGlobText
       
            };
            return await _globRepository.CreateComentGlob(newGlob);
        }
    }
}
