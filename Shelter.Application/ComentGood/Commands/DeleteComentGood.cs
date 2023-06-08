using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Application.Commands
{
    public class DeleteComentGood : IRequest
    {
        public int ComentGoodId { get; set; }
    }
}
