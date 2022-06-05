using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            int k = 0;
            Random rnd = new Random();
            double[] mass = new double[12];

            for (int i = 0; i < 12; i++)
                mass[i] = rnd.Next(1000);


            for (int i = 0; i < 12 - 1; i++)
            {
                for (int j = i + 1; j < 12; j++)
                {
                    if (mass[i] < mass[j])
                    {
                        temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                        k++;
                    }
                }
            }

            foreach (double num in mass)
                Console.Write(num + " ");
            Console.ReadKey();
        }
    }
}