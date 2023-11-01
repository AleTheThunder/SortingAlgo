using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class Sorter
    {
        public static void BubbleSort(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void SelectionSort(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        public static void InsertionSort(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        public static void MergeSort(List<int> arr)
        {
            if (arr.Count <= 1)
            {
                return;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = arr.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(arr[i]);
            }
            for (int i = middle; i < arr.Count; i++)
            {
                right.Add(arr[i]);
            }

            MergeSort(left);
            MergeSort(right);
            Merge(arr, left, right);
        }

        private static void Merge(List<int> arr, List<int> left, List<int> right)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Count && j < right.Count)
            {
                if (left[i] < right[j])
                {
                    arr[k++] = left[i++];
                }
                else
                {
                    arr[k++] = right[j++];
                }
            }

            while (i < left.Count)
            {
                arr[k++] = left[i++];
            }

            while (j < right.Count)
            {
                arr[k++] = right[j++];
            }
        }
        public static void QuickSort(List<int> arr)
        {
            if (arr.Count <= 1)
            {
                return;
            }

            int pivotIndex = arr.Count / 2;
            int pivot = arr[pivotIndex];
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (i == pivotIndex)
                {
                    continue;
                }

                if (arr[i] <= pivot)
                {
                    left.Add(arr[i]);
                }
                else
                {
                    right.Add(arr[i]);
                }
            }

            QuickSort(left);
            QuickSort(right);

            arr.Clear();
            arr.AddRange(left);
            arr.Add(pivot);
            arr.AddRange(right);
        }

    }
}