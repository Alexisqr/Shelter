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
    public class DeleteComentGoodHandler : IRequestHandler<DeleteComentGood>
    {
        private readonly IComentGoodRepository _goodRepository;
        public DeleteComentGoodHandler(IComentGoodRepository goodRepository)
        {
            _goodRepository = goodRepository;
        }
        public async Task<Unit> Handle(DeleteComentGood request, CancellationToken cancellationToken)
        {
            await _goodRepository.DeleteComentGood(request.ComentGoodId);
            return Unit.Value;
        }
    }
}
