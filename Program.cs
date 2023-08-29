using System;

namespace FishMovement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Fish nemo = new Nemo();

            nemo.DisplayInfo(nemo);
            Console.WriteLine();
            nemo.Reservoirs(nemo);
            Console.WriteLine();

            Fish dory = new Dory();

            dory.DisplayInfo(dory);
            Console.WriteLine();
            dory.Reservoirs(dory);
            Console.WriteLine();

            Fish gill = new Gill();

            gill.DisplayInfo(gill);
            Console.WriteLine();
            gill.Reservoirs(gill);
            Console.WriteLine();
        }
    }
}