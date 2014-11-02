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
        private Thread makeStep;
        private int score = 0;
        private double timeLeft;
        private int addCartCounter = 0;
        private int BootCounter = 0;
        Boolean running;
        private Schip boot;
        private Schip boot2;

        public Controller()
        {
            inputview = new InputView();
            outputview = new OutputView();
        }
        public void Go()
        {

            bool doorgaan = true;
            Boolean first = true;
            while (doorgaan)
            {
                if (first)
                {
                    outputview.ShowGameStart();
                    boot = new Schip();
                    boot2 = new Schip();
                    first = false;

                    bord = new Bord();
                    running = true;

                    makeStep = new Thread(MakeStep);
                    makeStep.Start();
                    outputview.ShowGame(bord, score, timeLeft, null, null);

                }
                HandleSwitch();

            }

        }

        // Om een bepaalde tijd het spel een stap laten doen
        private void MakeStep()
        {
            int scoreToAdd;
            while (running)
            {
                timeLeft = calculateRoundTime();
                while (timeLeft > 0)
                {
                    Thread.Sleep(100);
                    timeLeft = (timeLeft - 100);
                    Console.Clear();
                    outputview.ShowGame(bord, score, timeLeft, boot, boot2);
                }

                // score controleren bij elke stap
                scoreToAdd = bord.stap();
                if (scoreToAdd == -1)// score -1 betekend wagons gebotst
                {
                    outputview.GameEnd(score);
                    Environment.Exit(0);
                }
                else // score toevoegen

                    addCartCounter++;
                if (addCartCounter == 2)
                {
                    bord.addRandom();
                    addCartCounter = 0;
                }

                BootCounter++;

                if (BootCounter == 12)
                {
                    if (boot.lading == 8)
                    {
                        score = score + 10;
                    }
                    if (boot2.lading == 8)
                    {
                        score = score + 10;
                    }
                    boot = null;
                    boot2 = null;
                }
                if (BootCounter == 17)
                {

                    boot2 = new Schip();
                    boot = new Schip();
                    BootCounter = 0;
                }

                if (BootCounter > 0 &&
                    BootCounter < 12)
                {
                    score = score + scoreToAdd;

                    scoreToAdd = 0;
                }




            }
        }



        //Afhandelen van de switch invoer.
        public void HandleSwitch()
        {
            int valueSwith = inputview.AskSwitch();
            bord.changeSwitch(valueSwith);
            outputview.ShowGame(bord, score, timeLeft, boot, boot2);
        }

        //Zorgen dat de tijd steeds korter wordt
        public double calculateRoundTime()
        {
            double roundTime = 2000;
            roundTime = roundTime - ((score / 20) * 100);
            if (roundTime < 1000)
                return 1000;
            return roundTime;
        }
    }
}
