using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram doge = new Ram();

            fxs.MainColor = "red";
            modelS.MainColor = "blue";
            mx410.MainColor = "white";
            doge.MainColor = "black";

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();

            mx410.Drive();
            mx410.Stop();
            mx410.Turn();

            doge.Drive();
            doge.Turn();
            doge.Stop();
        }
    }
}