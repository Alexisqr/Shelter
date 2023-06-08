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
    public class GetComentGlobByIdHandlers : IRequestHandler<GetComentGlobById, ComentGlob>
    {
        private readonly IComentGlobRepository _globRepository;
        public GetComentGlobByIdHandlers(IComentGlobRepository globRepository)
        {
            _globRepository = globRepository;
        }
        public async Task<ComentGlob> Handle(GetComentGlobById request, CancellationToken cancellationToken)
        {
            return await _globRepository.GetComentGlobById(request.ComentGlobId);
        }
    }
}
