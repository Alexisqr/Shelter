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
    public class CreateComentKindAnimalsHandler : IRequestHandler<CreateComentKindAnimals, ComentKindAnimals>
    {
        private readonly IComentKindAnimalsRepository _kindAnimalsRepository;
        public CreateComentKindAnimalsHandler(IComentKindAnimalsRepository kindAnimalsRepository)
        {
            _kindAnimalsRepository= kindAnimalsRepository;
        }
        public async Task<ComentKindAnimals> Handle(CreateComentKindAnimals request, CancellationToken cancellationToken)
        {
            
                var newKindAnimals = new ComentKindAnimals
                {
                    Text = request.ComentKindAnimalsText

                };
                return await _kindAnimalsRepository.CreateComentKindAnimals(newKindAnimals);
        }
    }
}
