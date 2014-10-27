using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Domain
{
    class Bord
    {
        public List<StartVakje> starts;
        public Bord()
        {
            starts = new List<StartVakje>();


            RailsVakje rails1 = new RailsVakje();
            RailsVakje rails2 = new RailsVakje();
            RailsVakje rails3 = new RailsVakje();

            StartVakje start1 = new StartVakje(rails1);
            StartVakje start2 = new StartVakje(rails2);
            StartVakje start3 = new StartVakje(rails2);
            starts.Add(start1);
            starts.Add(start2);
            starts.Add(start3);

        }
    }
}
