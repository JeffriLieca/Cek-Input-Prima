using System;

namespace Cek_Input_Prima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cek Input apakah Bilangan Prima atau Bukan");
            Console.Write("Input :");
            int Input = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for(int i = 1; i <= Input; i++)
            {
                if (Input % i == 0)
                {
                    counter++;
                }
            }
        }
    }
}
