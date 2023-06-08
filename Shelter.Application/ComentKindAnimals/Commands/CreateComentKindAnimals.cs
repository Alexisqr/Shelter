using MediatR;
using Shelter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Shelter.Application.Commands
{
    public class CreateComentKindAnimals : IRequest<ComentKindAnimals>
    {
        public string? ComentKindAnimalsText { get; set; }
    }
}
