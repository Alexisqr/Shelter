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
    public class CreateComentGoodHandler : IRequestHandler<CreateComentGood, ComentGood>
    {
        private readonly IComentGoodRepository _goodRepository;
        public CreateComentGoodHandler(IComentGoodRepository goodRepository)
        {
            _goodRepository = goodRepository;
        }
        public async Task<ComentGood> Handle(CreateComentGood request, CancellationToken cancellationToken)
        {
            var newGood = new ComentGood
            {
                Text = request.ComentGoodText

            };
            return await _goodRepository.CreateComentGood(newGood);
        }
    }
}
