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
                    
                    makeStep = new Thread(MakeStep);
                    makeStep.Start();
                    addCartThread = new Thread(StartAddCartTimer);
                    addCartThread.Start();
                    second = false;
                    outputview.ShowGame(bord);
                }
                HandleSwitch();
               
            }

            Console.ReadLine();
            
        }

        // Om een bepaalde tijd het spel een stap laten doen
        private void MakeStep()
        {
            while(running)
            {
                Thread.Sleep(1000);
                bord.stap();
                Console.Clear();
                outputview.ShowGame(bord);
                Console.WriteLine("refreshed");
            }
        }

        // Om een bepaalde tijd een wagen toevoegen aan een random startstation
        public void StartAddCartTimer()
        {
            while(running)
            {
                Thread.Sleep(3100);
                bord.addRandom();
                //Console.Clear();
                //outputview.ShowGame(bord);
                Console.WriteLine("Voeg een Kar toe aan het bord");

            }            
        }

        //Afhandelen van de switch invoer.
        public void HandleSwitch()
        {
            int valueSwith = inputview.AskSwitch();
            outputview.ShowGame(bord);
        }
    }
}
