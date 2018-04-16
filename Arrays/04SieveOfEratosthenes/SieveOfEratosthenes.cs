using System;

namespace _04SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            
            //до n или до n+1?
            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = false;
            primes[1] = false;

            for (int p = 2; p <= n; p++)
            {
                if (primes[p])
                {
                    Console.Write($"{p} ");
                    for (int i = 1; i <= n / p; i++)
                    {
                        primes[i * p] = false;
                    }
                }
            }
        }
    }
}
