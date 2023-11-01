using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sort
{
    public class Program
    {
        static void PrintArray(List<int> arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 64, 34, 25, 12, 22, 11, 90 };

            List<Action<List<int>>> sortingAlgorithms = new List<Action<List<int>>>
        {
            Sorter.BubbleSort,
            Sorter.SelectionSort,
            Sorter.InsertionSort,
            Sorter.MergeSort,
            Sorter.QuickSort
        };

            foreach (var algorithm in sortingAlgorithms)
            {
                List<int> copy = new List<int>(numbers);
                Console.WriteLine($"Sorting with {algorithm.Method.Name}:");
                Stopwatch stopwatch = Stopwatch.StartNew();
                algorithm(copy);
                stopwatch.Stop();
                PrintArray(copy);
                Console.WriteLine($"Time taken: {stopwatch.Elapsed.TotalMilliseconds} ms\n");
            }
        }
    }
}
