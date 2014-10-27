using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Domain
{
    public abstract class Vakje 
    {
        public Vakje volgende;

        public Kar kar{
            get;
            set;
        }

        public Vakje(Vakje volgende)
        {
            this.volgende = volgende;
        }
        public Vakje()
        {

        }
        public void Move()
        {
            this.volgende.kar = this.kar;
            this.kar = null;
        }



    }
}
