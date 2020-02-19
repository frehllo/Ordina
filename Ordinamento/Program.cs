using System;
using System.Diagnostics;
using MetodiOrdinamenti;
using System.IO;

namespace Ordinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "ordinamenti.csv";
            using (StreamWriter w = new StreamWriter(file))
            {
                w.WriteLine("Algoritmo;Dimensione;Tempo");

                Random rnd = new Random();
                int[] dimensioni = { 100, 500, 1000, 10000, 15000, 20000,30000, 40000, 50000, 60000, 70000, 80000, 90000 };
                foreach (int dim in dimensioni)
                {
                    int[] a = new int[dim];
                    for (int i = 0; i < dim; i++)
                    {
                        a[i] = rnd.Next(0, 300000);
                    }
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    a = MetodiOrdinamenti.InsertSort.Insert_Sort(a);
                    s.Stop();
                    long elapsed = s.ElapsedMilliseconds;
                    w.WriteLine($"InsertSort;{dim};{elapsed}");
                    Console.WriteLine($"{dim}");
                    s.Reset();
                    s.Start();
                    a = MetodiOrdinamenti.BubbleSort.Bubble_Sort(a);
                    s.Stop();
                    elapsed = s.ElapsedMilliseconds;
                    w.WriteLine($"BubbleSort;{dim};{elapsed}");
                    Console.WriteLine($"{dim}");
                }
                w.Flush();
            }
        }
    }
}
