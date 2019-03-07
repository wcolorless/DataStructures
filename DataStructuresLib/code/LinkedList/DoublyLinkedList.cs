using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLib
{


    internal class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Prev { get; set; }
        public T Value { get; set; }
        public DoublyLinkedListNode(T Value)
        {
            this.Value = Value;
        }
    }


    public class DoublyLinkedList<T> : ICollection<T>
    {

        private DoublyLinkedListNode<T> _Head;
        private DoublyLinkedListNode<T> _Tail;
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
            DoublyLinkedListNode<T> NewNode = new DoublyLinkedListNode<T>(obj);
            if (_Head == null)
            {
                _Head = NewNode;
                _Tail = NewNode;
            }
            else
            {
                _Tail.Next = NewNode;
                NewNode.Prev = _Tail;
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
            DoublyLinkedListNode<T> currentNode = _Head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item)) return true;
                currentNode = currentNode.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            DoublyLinkedListNode<T> currentNode = _Head;
            while (currentNode != null)
            {
                array[arrayIndex++] = currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        public bool Remove(T item)  
        {
            DoublyLinkedListNode<T> currentNode = _Head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item))  break;
                currentNode = currentNode.Next;
            }
            if(currentNode != null)
            {
                if(currentNode.Next != null)
                {
                    currentNode.Next.Prev = currentNode.Prev;
                }
                else
                {
                    _Tail = currentNode.Prev;
                }
                if(currentNode.Prev != null)
                {
                    currentNode.Prev.Next = currentNode.Next;
                }
                else
                {
                    _Head = currentNode.Next;
                }
                _Count--;
                return true;
            }
            return false;
        }


        

        public IEnumerator<T> GetEnumerator()
        {
            DoublyLinkedListNode<T> currentNode = _Head;
            while (currentNode != null)
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
