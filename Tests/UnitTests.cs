using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Tests
{
    class UnitTests
    {
[TestClass]
    public class SortingAlgorithmsTests
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            List<int> input = new List<int> { 5, 3, 1, 4, 2 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5 };
            Sorter.BubbleSort(input);
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void SelectionSortTest()
        {
            List<int> input = new List<int> { 5, 3, 1, 4, 2 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5 };
                Sorter.SelectionSort(input);
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            List<int> input = new List<int> { 5, 3, 1, 4, 2 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5 };
                Sorter.InsertionSort(input);
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void MergeSortTest()
        {
            List<int> input = new List<int> { 5, 3, 1, 4, 2 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5 };
                Sorter.MergeSort(input);
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void QuickSortTest()
        {
            List<int> input = new List<int> { 5, 3, 1, 4, 2 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5 };
            Sorter.QuickSort(input);
            CollectionAssert.AreEqual(expected, input);
        }
    }

}
}
