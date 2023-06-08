using Domain.Entities;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Application.Queries
{
    public class GetAllComentGood: IRequest<ICollection<ComentGood>>
    {
    }
}
