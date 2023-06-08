using Domain.Entities;
using MediatR;
using Shelter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Application.Commands
{
    public class CreateComentGlob : IRequest<ComentGlob>
    {
        public string? ComentGlobText { get; set; }
    }
}
