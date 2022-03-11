using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero(15.5, "Red", 2);
            Tesla modelS = new Tesla(30.0, "Black", 5);
            Cessna mx410 = new Cessna(100, "White", 4);
            Ram proMaster = new Ram(40, "Blue", 8);

            fxs.Drive();
            fxs.Turn("Left");
            fxs.Stop();
            Console.WriteLine("");
            modelS.Drive();
            modelS.Turn("Right");
            modelS.Stop();
            Console.WriteLine("");
            mx410.Drive();
            mx410.Turn("Left");
            mx410.Stop();
            Console.WriteLine("");
            proMaster.Drive();
            proMaster.Turn("Back");
            proMaster.Stop();
        }
    }
}