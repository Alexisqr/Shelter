using Shelter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Domain.Entities
{
    public class Goods 
    {
      //  public Goods()
      //  {
       //     this.ComentGoods = new HashSet<ComentGood>();
      //  }
        public int Id { get; set; }
        public string? Name { get; set; }
        public int NameKind { get; set; }
        public int Price { get; set; }
       // public ICollection<ComentGood> ComentGoods { get; set; }
    }
}
