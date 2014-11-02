using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Domain
{
    class Bord
    {
        List<Vakje> vakjes;
        List<StartVakje> startVakjes;
        List<WisselVakje> wisselVakjes;
        private Random myGenerator;
        public Bord()
        {
            vakjes = new List<Vakje>();
            startVakjes = new List<StartVakje>();
            wisselVakjes = new List<WisselVakje>();
            //maak route 1

            Eindvakje vak13 = new Eindvakje();
            RailsVakje vak12 = new RailsVakje(vak13);
            KadeVakje vak11 = new KadeVakje(vak12);
            RailsVakje vak10 = new RailsVakje(vak11);

            WisselVakje vak9 = new WisselVakje();
            // zet het wisselvakje !

            RailsVakje vak8 = new RailsVakje(vak9);

            WisselVakje vak7 = new WisselVakje();
            // zet het wisselvakje !

            RailsVakje vak6 = new RailsVakje(vak7);

            WisselVakje vak5 = new WisselVakje();
            // zet het wisselvakje !

            RailsVakje vak4 = new RailsVakje(vak5);

            StartVakje vak1 = new StartVakje(vak4, "A");

            //route 1 gemaakt

            //maak route 2
            Eindvakje vak22 = new Eindvakje();
            RailsVakje vak21 = new RailsVakje(vak22);
            KadeVakje vak20 = new KadeVakje(vak21);
            RailsVakje vak19 = new RailsVakje(vak20);

            WisselVakje vak18 = new WisselVakje();
            // zet het wisselvakje !

            RailsVakje vak17 = new RailsVakje(vak18);

            WisselVakje vak16 = new WisselVakje();
            // zet het wisselvakje !

            RailsVakje vak15 = new RailsVakje(vak16);
            RailsVakje vak14 = new RailsVakje(vak5);
            StartVakje vak2 = new StartVakje(vak14, "B");
            // einde route 2

           
            // maak route 3
            RailsVakje vak23 = new RailsVakje(vak16);
            StartVakje vak3 = new StartVakje(vak23, "C");
            //einde route 3

            RailsVakje vak24 = new RailsVakje(vak9);

            vak9.setVakjes(vak10,null, vak8, vak24);
            vak18.setVakjes(vak24, vak19,vak17, null);
            vak16.setVakjes(vak17,null, vak15, vak23);
            vak7.setVakjes(vak8, vak15, vak6, null);
            vak5.setVakjes(vak6, null, vak4, vak14);

            startVakjes.Add(vak1);
            startVakjes.Add(vak2);
            startVakjes.Add(vak3);

            wisselVakjes.Add(vak5);
            wisselVakjes.Add(vak7);
            wisselVakjes.Add(vak16);
            wisselVakjes.Add(vak9);
            wisselVakjes.Add(vak18);

            // alle vakken in een lijst zetten
            vakjes.Add(vak1);
            vakjes.Add(vak2);
            vakjes.Add(vak3);
            vakjes.Add(vak4);
            vakjes.Add(vak5);
            vakjes.Add(vak6);
            vakjes.Add(vak7);
            vakjes.Add(vak8);
            vakjes.Add(vak9);
            vakjes.Add(vak10);
            vakjes.Add(vak11);
            vakjes.Add(vak12);
            vakjes.Add(vak13);
            vakjes.Add(vak14);
            vakjes.Add(vak15);
            vakjes.Add(vak16);
            vakjes.Add(vak17);
            vakjes.Add(vak18);
            vakjes.Add(vak19);
            vakjes.Add(vak20);
            vakjes.Add(vak21);
            vakjes.Add(vak22);
            vakjes.Add(vak23);
            vakjes.Add(vak24);
            myGenerator = new Random();
            // zorgen dat deze in de volgoorde komen (achterstevoren) van welke
            // ze controleren in de while loop bij stap()
            // de velden moeten van achter naar vooren gemoved worden.
            // anders vliegen ze naar het laatste veld
        }
        
       

        public String getWaarde(int value)
        {
            return vakjes.ElementAt(value).getWaarde();
        }

        public void addRandom()
        {
            // kies een random start vakje om een kar toe te voegen.
            int nextRand = myGenerator.Next(3);
            startVakjes.ElementAt(nextRand).kar = new Kar();
            Console.WriteLine("added random at " + nextRand);
        }

        public void stap()
        {
            for(int i = vakjes.Count() ; i > 0 ; i --)
            {
                if(vakjes.ElementAt(i -1).kar != null)
                    vakjes.ElementAt(i - 1).Move();
            }
        }

        public void changeSwitch(int index)
        {

            wisselVakjes.ElementAt(index - 1).Wissel();
        }
    }
}
