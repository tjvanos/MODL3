﻿using System;
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
        public virtual int Move()
        {
            int score = 0;
            // score verhogen als het volgende vakje een kadevakje is en er een boot beschikbaar is.
            if(this.volgende != null)
            {
                
                if(this.volgende.GetType() == typeof(WisselVakje))
                {
                    WisselVakje temp = (WisselVakje)this.volgende;
                    if (this == temp.getVorigVakje())
                    {
                        this.volgende.kar = this.kar;
                        this.kar = null;
                    }
                }
                else
                {
                    this.volgende.kar = this.kar;
                    this.kar = null;
                }
            }
            return score;
        }

        public virtual String getWaarde()
        {
            String output = "=";
            if (this.kar != null)
            {
                if (this.kar.hasPackage())
                    output += "[1]";
                else
                    output += "[0]";
            }
            else
            {
                output += " = ";
            }
            return output;
        }

       
        


    }
}
