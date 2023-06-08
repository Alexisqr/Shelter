
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ComentGood
    {
        public int Id { get; set; }
      //  public int IDVolonter { get; set; }
       // public Volonters? Volonters { get; set; }
      //  public int IDGood { get; set; }
       // public Goods? Goods { get; set; }

        public string? Text { get; set; }
        public DateTime Date { get; set; }//ПерепитатисЬ за дату
    }
}
