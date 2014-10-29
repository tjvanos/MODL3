using ConsoleApplication1.Domain;
using ConsoleApplication1.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApplication1.Process
{
    class Controller
    {
        private InputView inputview;
        private OutputView outputview;
        private Bord bord;
        private Thread addCartThread;
        private Thread makeStep;
        Boolean running;

        public Controller()
        {
            inputview = new InputView();
            outputview = new OutputView();
        }
        public void Go()
        {
            bool doorgaan = true;
            Boolean first = true;
            Boolean second = false;
            while(doorgaan)
            {
                if(first)
                {
                    outputview.ShowGameStart();
                    first = false;
                    second = true;
                    bord = new Bord();
                }
                if (second)
                {                    
                    running = true;
                    addCartThread = new Thread(StartAddCartTimer);
                    addCartThread.Start();
                    makeStep = new Thread(MakeStep);
                    makeStep.Start();
                    second = false;
                    outputview.ShowGame();
                }
                HanleSwitch();
               
            }

            Console.ReadLine();
            
        }

        private void MakeStep()
        {
            while(running)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Doe een stap");
            }
        }

        public void StartAddCartTimer()
        {
            while(running)
            {
                Thread.Sleep(4000);
                Console.WriteLine("Voeg een Kar toe aan het bord");
            }            
        }

        public void HanleSwitch()
        {
            int valueSwith = inputview.AskSwitch();
            outputview.ShowGame();
        }
    }
}
