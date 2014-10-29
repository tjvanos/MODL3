using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Domain
{
    class StartVakje : Vakje
    {
        String naam;
        
        public StartVakje(Vakje volgende, String naam)
        {
            this.volgende = volgende;
            this.naam = naam;
        }

        public override void Move()
        {
            
            base.Move();
        }
    }
}
