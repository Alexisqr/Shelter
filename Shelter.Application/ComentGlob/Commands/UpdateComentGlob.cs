using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Application.Commands
{
    public class UpdateComentGlob : IRequest<ComentGlob>
    {
        public int ComentGlobId { get; set; }
        public string? ComentGlobText { get; set; }

    }
}
