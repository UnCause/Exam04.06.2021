using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Primes primes = new Primes(0, 100);
            primes.Start();
        }
    }
}
