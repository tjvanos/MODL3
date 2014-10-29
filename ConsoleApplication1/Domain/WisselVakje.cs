using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Domain
{
    class WisselVakje : Vakje
    {
        private Vakje volgende2;
        private Vakje vorige;
        private Vakje vorige2;
        private Vakje huidig;
        private Boolean typeIn;
        private string waarde;
         public WisselVakje(){}

        public void setVakjes(Vakje volgende, Vakje volgende2, Vakje vorige, Vakje vorige2)
        {
            this.volgende = volgende;
            this.vorige = vorige;
            this.volgende2 = volgende2;
            this.vorige2 = vorige2;
            if (volgende2 == null)
            {
                huidig = vorige2;
                typeIn = true;
                this.waarde = "\\";
            }
            else
            {
                huidig = volgende2;
                typeIn = false;
                this.waarde = "/";
            }
            
            
        }

       

        public void Wissel()
         {
             if(typeIn)
             {
                 if (huidig == vorige)
                 {
                     huidig = vorige2;
                     this.waarde = "/";
                 }
                 else
                 {
                     huidig = vorige;
                     this.waarde = "\\";
                 }
             }
             else
             {
                 if (huidig == volgende)
                 {
                     huidig = volgende2;
                     this.waarde = "\\";
                 }
                 else
                 {
                     huidig = volgende;
                     this.waarde = "/";
                 }
             }
         }

        public override String getWaarde()
        {
            String output = "";
            if (typeIn)
                output += this.waarde;
            output += "[";
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
            if (! typeIn)
                output += this.waarde;
            return output;
        }

        public Vakje getVorigVakje()
        {
            return vorige;
        }

        public Vakje getVolgendVakje()
        {
            return volgende;
        }
    }
}
