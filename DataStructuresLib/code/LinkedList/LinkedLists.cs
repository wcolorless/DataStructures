using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLib
{
    public enum LinkedListType
    {
        LinkedList,
        DoublyLinkedList
    }

    public class LinkedLists
    {
        public static ICollection<T> Create<T>(LinkedListType type)
        {
            if (type == LinkedListType.DoublyLinkedList)
            {
                return new DoublyLinkedList<T>();
            }
            else if(type == LinkedListType.LinkedList)
            {
                return new LinkedList<T>();
            }
            else
            {
                return null;
            }

        }
    }
}
