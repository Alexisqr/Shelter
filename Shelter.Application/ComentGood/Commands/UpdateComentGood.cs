using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Application.Commands
{
    public class UpdateComentGood : IRequest<ComentGood>
    {
        public int ComentGoodId { get; set; }
        public string? ComentGoodText { get; set; }

    }
}
