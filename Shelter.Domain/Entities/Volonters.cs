using Shelter.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Domain.Entities
{
    public class Volonters 
    {
      //  public Volonters()
       // {
      //      this.ComentGlobs = new HashSet<ComentGlob>();
      //      this.ComentGoods = new HashSet<ComentGood>();
     //       this.ComentKindAnimalss = new HashSet<ComentKindAnimals>();
      //  }
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneName { get; set; }
        public string? EMail { get; set; }

       // public ICollection<ComentGlob> ComentGlobs { get; set; }
       // public ICollection<ComentGood> ComentGoods { get; set; }
       // public ICollection<ComentKindAnimals> ComentKindAnimalss { get; set; }
    }
}
