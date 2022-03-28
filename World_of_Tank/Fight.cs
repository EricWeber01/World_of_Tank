using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace World_of_Tank
{
    class Fight
    {
            private static readonly Random rnd = new Random();
            private static readonly Object mylock = new Object();
            public static int Getrandom(int min, int max)
            {
                lock (mylock)
                { return rnd.Next(min, max); }
            }
            Tank[] t34 = new Tank[5];
            Tank[] pant = new Tank[5];
            public void Start()
            {
                int t = 0;
                int p = 0;
                for (int i = 0; i < 5; i++)
                    t34[i] = new Tank("Т-34", Getrandom(1, 100), Getrandom(1, 100), Getrandom(1, 100));
                for (int i = 0; i < 5; i++)
                    pant[i] = new Tank("Panter", Getrandom(1, 100), Getrandom(1, 100), Getrandom(1, 100));

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(t34[i] + " V.S. " + pant[i]);
                    if (t34[i] * pant[i])
                    {
                        Console.WriteLine("Win T-34");
                        t++;
                    }
                    else
                    {
                        Console.WriteLine("Win Panter");
                        p++;
                    }
                }
                if (t > p)
                    Console.WriteLine("\nT-34 team win!");
                else if (t == p)
                    Console.WriteLine("\nTie!");
                else
                    Console.WriteLine("\nPanter team win");
            }
    }
}
