using ConsoleApplication1.Domain;
using ConsoleApplication1.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.Process
{
    class Controller
    {
        private InputView inputview;
        private OutputView outputview;
        private Bord bord;

        public Controller()
        {
            inputview = new InputView();
            outputview = new OutputView();
        }
        public void Go()
        {
            bool doorgaan = true;
            Boolean first = true;
            while(doorgaan)
            {
                if(first)
                {
                    outputview.ShowGameStart();
                    first = false;
                    bord = new Bord();
                }
                Console.ReadLine();
            }
            Console.ReadLine();
            
        }
    }
}
