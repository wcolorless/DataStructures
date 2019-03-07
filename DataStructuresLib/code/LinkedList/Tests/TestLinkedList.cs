using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructuresLib
{
    public class TestLinkedList
    {
        [Fact]
        public void TestSinglyLinkedList()
        {
            int[] TestValues = new int[] { 1, 2, 3, 4 };
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < TestValues.Length; i++) list.Add(TestValues[i]);
            int index = 0;
            foreach(int num in list)
            {
                Assert.Equal(TestValues[index++], num);
            }
        }

        [Fact]
        public void TestRemoveFirstSinglyLinkedList()
        {
            int[] TestIniticalValues = new int[] { 1, 2, 3, 4 };
            int[] TestValues = new int[] { 2, 3, 4 };
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < TestIniticalValues.Length; i++) list.Add(TestIniticalValues[i]);
            int index = 0;
            list.Remove(1);
            foreach (int num in list)  Assert.Equal(TestValues[index++], num);
        }

        [Fact]
        public void TestRemoveLastSinglyLinkedList()
        {
            int[] TestIniticalValues = new int[] { 1, 2, 3, 4 };
            int[] TestValues = new int[] {1, 2, 3 };
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < TestIniticalValues.Length; i++) list.Add(TestIniticalValues[i]);
            int index = 0;
            list.Remove(4);
            foreach (int num in list)   Assert.Equal(TestValues[index++], num);
        }

        [Fact]
        public void TestRemoveInCenterSinglyLinkedList()
        {
            int[] TestIniticalValues = new int[] { 1, 2, 3, 4 };
            int[] TestValues = new int[] { 1, 3, 4 };
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < TestIniticalValues.Length; i++) list.Add(TestIniticalValues[i]);
            int index = 0;
            list.Remove(2);
            foreach (int num in list)  Assert.Equal(TestValues[index++], num);
        }

        [Fact]
        public void TestRemoveSingleValueSinglyLinkedList()
        {
            int[] TestIniticalValues = new int[] { 1 };
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < TestIniticalValues.Length; i++) list.Add(TestIniticalValues[i]);
            int index = 0;
            list.Remove(1);
            foreach (int num in list) index++;
            Assert.Equal(0, index);
        }
    }
}
