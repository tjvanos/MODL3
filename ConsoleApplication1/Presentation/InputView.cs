using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Presentation
{
    class InputView
    {
        public int AskSwitch()
        {
            int returnValue = 0;


            bool doorgaan = true;
            ConsoleKeyInfo input;
            ConsoleKey k = ConsoleKey.Escape;
            while (doorgaan)
            {
                Console.WriteLine("Gebruik 1,2,3,4,5 om de wissels te besturen");
                input = Console.ReadKey();
                k = input.Key;
                if (k != ConsoleKey.D1 && k != ConsoleKey.D2 && k != ConsoleKey.D3 && k != ConsoleKey.D4 && k != ConsoleKey.D5)
                {
                    Console.WriteLine("Ongeldige invoer");
                }
                else
                {
                    doorgaan = false;
                }
            }
            Console.Clear();
            switch (k)
            {
                case ConsoleKey.D1:
                    returnValue = 1;
                    break;

                case ConsoleKey.D2:
                    returnValue = 2;
                    break;

                case ConsoleKey.D3:
                    returnValue = 3;
                    break;

                case ConsoleKey.D4:
                    returnValue = 4;
                    break;

                case ConsoleKey.D5:
                    returnValue = 5;
                    break;


            }
            return returnValue;
        }
    }
}
