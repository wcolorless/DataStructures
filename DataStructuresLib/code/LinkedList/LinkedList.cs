using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLib
{
    internal class LinkedListNode<T>
    {
        public LinkedListNode<T> Next { get; set; }
        public T Value { get; set; }
        public LinkedListNode(T Value)
        {
            this.Value = Value;
        }
    }


    public class LinkedList<T> : ICollection<T>
    {

        private LinkedListNode<T> _Head;
        private LinkedListNode<T> _Tail;
        private int _Count;

        public int Count
        {
            get
            {
                return _Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T obj)
        {
            LinkedListNode<T> NewNode = new LinkedListNode<T>(obj);
            if (_Head == null)
            {
                _Head = NewNode;
                _Tail = NewNode;
            }
            else
            {
                _Tail.Next = NewNode;
                _Tail = NewNode;
            }
            _Count++;
        }

        public void Clear()
        {
            _Head = null;
            _Tail = null;
            _Count = 0;
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> currentNode = _Head;
            while (currentNode != null)
            {
                if(currentNode.Value.Equals(item))  return true;
                currentNode = currentNode.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> currentNode = _Head;
            while(currentNode != null)
            {
                array[arrayIndex++] = currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        public bool Remove(T item) // сДЕЛАТЬ ПРОВЕРКУ НА НУЛЛ
        {
            LinkedListNode<T> currentNode = _Head;
            LinkedListNode<T> prevNode = null;
            while(currentNode != null)
            {
                if (currentNode.Value.Equals(item))
                {
                    if(prevNode != null)
                    {
                        prevNode.Next = currentNode.Next;
                        if (currentNode.Next == null) _Tail = prevNode;
                    }
                    else
                    {
                        _Head = _Head.Next;
                        if (_Head == null) _Tail = null;
                    }
                    _Count--;
                    return true;
                }
                prevNode = currentNode;
                currentNode = currentNode.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> currentNode = _Head;
            while(currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
