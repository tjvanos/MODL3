using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Domain
{
    class WisselVakje : Vakje
    {
         public WisselVakje()
        {
                
        }

         public WisselVakje(Vakje volgende)
        {
            this.volgende = volgende;
        }
    }
}
