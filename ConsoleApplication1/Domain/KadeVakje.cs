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

         public override String getWaarde()
         {
             String output = "K";
             if (this.kar != null)
             {
                 if (this.kar.hasPackage())
                     output += "[1]";
                 else
                     output += "[0]";
             }
             else
             {
                 output += "===";
             }
             return output;
         }
    }
}
