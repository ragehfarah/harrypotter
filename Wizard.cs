using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Wizard
    {
        public string? Name { get; set; }
        public bool DeathEater { get; set; }
         
        public bool DumbledoresArmy { get; set; }

        public Blodstatus? Blodstatus { get; set; }
      
       

    }
    enum Blodstatus
    {
        Renblod,
        Halvblod,
        Muggalarfödd,
        Okänt
    }
}
    

