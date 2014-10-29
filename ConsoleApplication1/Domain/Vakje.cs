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
        public virtual void Move()
        {
            if(this.volgende != null)
            { 
                this.volgende.kar = this.kar;
                this.kar = null;
            }
        }

        public virtual String getWaarde()
        {
            String output = "=[";
            if (this.kar != null)
            {
                if (this.kar.hasPackage())
                    output += "1";
                else
                    output += "0";
            }
            else
            {
                output += "-";
            }
            output += "]";
            return output;
        }

       
        


    }
}
