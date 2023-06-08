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
    public class GetComentGoodByIdHandlers : IRequestHandler<GetComentGoodById, ComentGood>
    {
        private readonly IComentGoodRepository _goodRepository;
        public GetComentGoodByIdHandlers(IComentGoodRepository goodRepository)
        {
            _goodRepository = goodRepository;
        }
        public async Task<ComentGood> Handle(GetComentGoodById request, CancellationToken cancellationToken)
        {
            return await _goodRepository.GetComentGoodById(request.ComentGoodId);
        }
    }
}
