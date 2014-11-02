using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Domain
{
    class RailsVakje : Vakje
    {
        public RailsVakje()
        {
                
        }

        public RailsVakje(Vakje volgende)
        {
            this.volgende = volgende;
        }



        
    }
}
