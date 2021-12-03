using System;

namespace git
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputAngka = Convert.ToInt32(Console.ReadLine());
            int faktor = 0;
            for (int i=1; i<=inputAngka; i++)
            {
                if (inputAngka % i == 0)
                {
                    faktor++;
                }
            }
            if (faktor == 2)
            {
                Console.WriteLine("Bilangan Prima");
            }
            else
            {
                Console.WriteLine("Bukan Bilangan Prima");
            }
        }
    }
}
