using System;
using System.Collections.Generic;

namespace Euler46
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> primes = new List<int> { 2, 3, 5, 7 };
            List<int> results = new List<int>();
            int n = 11;

            while(true)
            {
                n += 2;

                if (isPrime(n))
                {
                    primes.Add(n);
                    continue;
                }

                bool found = false;
                foreach (int p in primes)
                {
                    if (p >= n)
                        break;

                    int delta = (n - p) / 2;
                    int sqDelta = (int)Math.Truncate(Math.Sqrt(delta));
                    if(n == p + 2 * sqDelta * sqDelta)
                    {
                        found = true;
                        break;
                    }
                }

                if (found == false)
                {
                    results.Add(n);
                    Console.WriteLine(n);
                    break;
                }
            }

            Console.ReadLine();
        }

        public static bool isPrime(int n)
        {
            if (n == 2)
                return true;
            if (n < 2 || n % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
