using MediatR;
using Shelter.Application.Queries;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Shelter.Application.Abstractions;

namespace Shelter.Application.QueryHandlers
{
    public class GetAllComentGoodHandlers : IRequestHandler<GetAllComentGood, ICollection<ComentGood>>
    {
        private readonly IComentGoodRepository _goodRepository;
        public GetAllComentGoodHandlers(IComentGoodRepository goodRepository)
        {
            _goodRepository = goodRepository;
        }
        public async Task<ICollection<ComentGood>> Handle(GetAllComentGood request, CancellationToken cancellationToken)
        {
            return await _goodRepository.GetAllComentGood();
        }
    }
}
