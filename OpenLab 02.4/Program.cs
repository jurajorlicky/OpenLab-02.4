using System;

namespace OpenLab_02._4
{
    class Program
    {
        public static int GetLegsCount(int chickens, int cows, int pigs)
        {
            return ((chickens * 2) + (cows * 4) + (pigs * 4));
        }
        static void Main(string[] args)
        {
            int chickens = 1;
            int cows = 1;
            int pigs = 1;
            Console.WriteLine(GetLegsCount(chickens, cows, pigs));
        }
    }
}