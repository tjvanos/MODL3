using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Domain
{
    class StartVakje : Vakje
    {
        public StartVakje(Vakje volgende)
        {
            this.volgende = volgende;
        }
    }
}
