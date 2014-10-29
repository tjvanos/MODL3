using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Domain
{
    public class Kar
    {
        private int packages { get; set; }
        public Kar()
        {
            this.packages = 1;
        }

        public void empty()
        {
            this.packages = 0;
        }

        public Boolean hasPackage()
        {
            if (this.packages > 0)
                return true;
            return false;
        }

    }
}
