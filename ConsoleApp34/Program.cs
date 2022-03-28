using System;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] uczestnicy = { 19,34,23,54,31};
            int suma = 0;
            double srednia;
            Console.WriteLine("Wiek uczestników");
            for (int i = 0; i < uczestnicy.Length; i++)
            {
                Console.Write(" {0} ", uczestnicy[i]);
                    suma += uczestnicy[i];
            }
            srednia = (double)suma / uczestnicy.Length;
            Console.WriteLine();
            Console.WriteLine("Średnia: {0}", srednia);
            //Console.ReadKey();
          suma =0;
            //wersja foreach
            Console.WriteLine("Wersja forech");
            foreach (int x  in uczestnicy)
            {
                Console.Write(" {0} ", x);
                suma += x;
            }
            srednia = (double)suma / uczestnicy.Length;
            Console.WriteLine();
            Console.WriteLine("Średnia: {0}", srednia);
        }
    }
}
