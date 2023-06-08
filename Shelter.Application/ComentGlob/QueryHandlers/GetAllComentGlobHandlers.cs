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
    public class GetAllComentGlobHandlers : IRequestHandler<GetAllComentGlob, ICollection<ComentGlob>>
    {
        private readonly IComentGlobRepository _globRepository;
        public GetAllComentGlobHandlers(IComentGlobRepository globRepository)
        {
            _globRepository = globRepository;
        }
        public async Task<ICollection<ComentGlob>> Handle(GetAllComentGlob request, CancellationToken cancellationToken)
        {
            return await _globRepository.GetAllComentGlob();
        }
    }
}
