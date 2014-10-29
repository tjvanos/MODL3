using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Presentation
{
    class OutputView
    {

        public void ShowGame()
        {

            Console.Clear();
            Console.WriteLine("┌────────────────────────────────────────────────────┐");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("|44444444444444444444444444444444444444444444444444  |");
            Console.WriteLine("└────────────────────────────────────────────────────┘");
        }


        public void ShowGameStart()
        {
            Console.Clear();
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

        public void GameEnd()
        {
            Console.Clear();
            Console.WriteLine("Waiting for input");
            Console.ReadKey();
        }

    }
}
