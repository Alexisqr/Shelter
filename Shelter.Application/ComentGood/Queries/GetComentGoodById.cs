using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Application.Queries
{
    public class GetComentGoodById : IRequest<ComentGood>
    {
        public int ComentGoodId { get; set; }
    }
}
