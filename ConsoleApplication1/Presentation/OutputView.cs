using ConsoleApplication1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Presentation
{
    class OutputView
    {

        // toon het bord
        public void ShowGame(Bord myBord, double score, double timeLeft)
        {
            Console.WriteLine("Score : " + score + " Time till next step : "+ timeLeft);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("44444444444444444444444444444444444444444444444444");
            Console.WriteLine("44444444444444444444444444444444444444444444444444");
            Console.WriteLine("44444444444444444444444444444444444444444444444444");
            Console.WriteLine("12345678901234567890123456789012345678901234567890");

            //1
            Console.ResetColor();
            
            Console.Write(myBord.getWaarde(12));
            Console.Write("============");
            Console.Write(myBord.getWaarde(11));
            Console.Write("========");
            Console.Write(myBord.getWaarde(10));
            Console.Write("====");
            Console.WriteLine();
            //2
            Console.Write("                                    ====");
            Console.WriteLine();
            //3    
            Console.Write(myBord.getWaarde(0));
            Console.Write(myBord.getWaarde(3));
            Console.Write("            ====");
            Console.Write(myBord.getWaarde(7));
            Console.Write("====        ====");
            Console.WriteLine();
            //4  '    '
            Console.Write("        ");
            Console.Write(myBord.getWaarde(4));
            Console.Write(myBord.getWaarde(5));
            Console.Write(myBord.getWaarde(6));
            Console.Write("            ====    ");
            Console.Write(myBord.getWaarde(9));
            Console.WriteLine();
            //5
            Console.Write(myBord.getWaarde(1));
            Console.Write(myBord.getWaarde(13));
            Console.Write("            ====        ====    ====");
            Console.WriteLine();

            //6
            Console.Write("                    ");
            Console.Write(myBord.getWaarde(14));
            Console.Write("        ");
            Console.Write(myBord.getWaarde(8));
            Console.Write("====");
            Console.WriteLine("");


            //7
            Console.WriteLine("                    ====        ====    ");

            //8
            Console.Write("                    ====        ");
            Console.Write(myBord.getWaarde(23));
            Console.Write("    ");
            Console.WriteLine("");

            //9
            Console.Write(myBord.getWaarde(2));
            Console.Write("========");
            Console.Write(myBord.getWaarde(22));
            Console.Write("====");
            Console.Write(myBord.getWaarde(15));
            Console.Write(myBord.getWaarde(16));
            Console.Write(myBord.getWaarde(17));
            Console.WriteLine("");

            //10
            Console.Write("                                ");
            Console.Write(myBord.getWaarde(18));
            Console.WriteLine("");

            //10
            Console.Write(myBord.getWaarde(21));
            Console.Write("========");
            Console.Write(myBord.getWaarde(20));
            Console.Write("========");
            Console.Write(myBord.getWaarde(19));
            Console.Write("====");
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("44444444444444444444444444444444444444444444444444");
            Console.WriteLine("44444444444444444444444444444444444444444444444444");
            Console.WriteLine("44444444444444444444444444444444444444444444444444");
            Console.ResetColor();
            Console.WriteLine();
        }


        // toon het startscherm
        public void ShowGameStart()
        {            
            Console.WriteLine("┌────────────────────────────────────────────────────┐");
            Console.WriteLine("| Welkom bij Goudkoort                               |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("| betekenis van de symbolen   |   doel van het spel  |");
            Console.WriteLine("|                             |                      |");
            Console.WriteLine("| spatie : outerspace         |   Vul de boten met   |");
            Console.WriteLine("|      █ : muur               |   lading van de kar  |");
            Console.WriteLine("|      · : vloer              |   voor highscore     |");
            Console.WriteLine("|      O : krat               |                      |");
            Console.WriteLine("|      0 : krat op bestemming |                      |");
            Console.WriteLine("|      x : bestemming         |                      |");
            Console.WriteLine("|      @ : truck              |                      |");
            Console.WriteLine("|                             |                      |");
            Console.WriteLine("| Input                       |   Vul de boten met   |");
            Console.WriteLine("|      1 : switch 1           |   lading van de kar  |");
            Console.WriteLine("|      2 : switch 2           |   voor highscore     |");
            Console.WriteLine("|      3 : switch 3           |                      |");
            Console.WriteLine("|      4 : switch 4           |                      |");
            Console.WriteLine("|      5 : switch 5           |                      |");
            Console.WriteLine("└────────────────────────────────────────────────────┘");
            Console.WriteLine("");
            Console.WriteLine("Druk op enter om het spel te starten.");

            Console.WriteLine("");
            Console.ReadKey();
        }

        // toon het scherm als het spel is afgelopen
        public void GameEnd()
        {
            Console.Clear();
            Console.WriteLine("Waiting for input");
            Console.ReadKey();
        }
        
    }
}
