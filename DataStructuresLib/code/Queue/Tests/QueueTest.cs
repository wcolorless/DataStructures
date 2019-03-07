using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace DataStructuresLib
{
    public class QueueTest
    {
        [Fact]
        public void TestEnqueueAndDequeue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.Equal(1, queue.Dequeue());
            Assert.Equal(2, queue.Dequeue());
            Assert.Equal(3, queue.Dequeue());
        }

        [Fact]
        public void TestQueueForeach()
        {
            int index = 0;
            string[] TestValues = new string[] { "Data" , "Structure", "Queue" };
            Queue<string> queue = new Queue<string>();
            foreach (string value in TestValues)
            {
                queue.Enqueue(value);
            }
            foreach (string value in queue)
            {
                Assert.Equal(TestValues[index++], value);
            }
        }
    }
}
