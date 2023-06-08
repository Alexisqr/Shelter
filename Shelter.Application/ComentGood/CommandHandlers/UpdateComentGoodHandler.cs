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
    public class UpdateComentGoodHandler : IRequestHandler<UpdateComentGood, ComentGood>
    {
        private readonly IComentGoodRepository _goodRepository;
        public UpdateComentGoodHandler(IComentGoodRepository goodRepository)
        {          
                _goodRepository = goodRepository;   
        }
        public async Task<ComentGood> Handle(UpdateComentGood request, CancellationToken cancellationToken)
        {
            var Glob = await _goodRepository.UpdateComentGood(request.ComentGoodText, request.ComentGoodId);
            return Glob;
        }
    }
}
