using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Domain
{
    class KadeVakje : Vakje
    {
        public KadeVakje()
        {
                
        }

         public KadeVakje(Vakje volgende)
        {
            this.volgende = volgende;
        }
    }
}
