using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLib
{

    public class QueueNode<T>
    {
        public QueueNode<T> Next { get; set; }
        public T Value { get; set; }

        public QueueNode(T Value)
        {
            this.Value = Value;
        }
    }


    public class Queue<T> : IEnumerable<T>
    {

        private QueueNode<T> _Head;
        private QueueNode<T> _Tail;
        int _Count;

        public int Count
        {
            get { return _Count; }
        }

        public bool IsEmpty
        {
            get { return _Count == 0; }
        }

        public void Clear()
        {
            _Head = null;
            _Tail = null;
            _Count = 0;
        }

        public bool Contains(T Value)
        {
            QueueNode<T> Node = _Head;
            while(Node != null)
            {
                if(Node.Value.Equals(Value))
                {
                    return true;
                }
                Node = Node.Next;
            }
            return false;
        }

        public void Enqueue(T Value)
        {
            QueueNode<T> newNode = new QueueNode<T>(Value);
            if(_Head == null)
            {
                _Head = newNode;
                _Tail = newNode;
            }
            else
            {
                _Tail.Next = newNode;
                _Tail = newNode;
            }
            _Count++;
        }


        public T Dequeue()
        {
            if (_Count == 0) throw new InvalidOperationException("Нет элементов в очереди");
            T result = _Head.Value;
            _Head = _Head.Next;
            _Count--;
            return result;
        }


        public IEnumerator<T> GetEnumerator()
        {
            QueueNode<T> Node = _Head;
            while(Node != null)
            {
                yield return Node.Value;
                Node = Node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
