using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundel_linkedlist
{
    class LinkedList
    {
        public Node Add(Node Head, Node NewNode)
        {
            if (Head == null)
                return NewNode;
            Node Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = NewNode;
            return Head;
        }
        public Node Contains(Node Head, string SearchParam)
        {
            if (Head == null)
                return null;
            Node Current = Head;
            while (Current.Data.ToLower() != SearchParam.ToLower())
            {
                if (Current.Next == null)
                {
                    return null;
                }
                Current = Current.Next;
            }
            return Current;
        }
        public Node Remove(Node Head, string SearchParam)
        {
            if (Head == null)
                return null;
            Node Current = Head;
            Node PreviousNode;
            while (Current.Data.ToLower() != SearchParam.ToLower())
            {
                if (Current.Next == null)
                {
                    return null;
                }
                PreviousNode = Current;
                Current = Current.Next;
                if (Current.Data.ToLower() == SearchParam.ToLower())
                {
                    if(Current.Next == null && Current.Data.ToLower() == SearchParam.ToLower())
                    {
                        PreviousNode.Next = null;
                        return Head;
                    }
                    Node temp = Current.Next;
                    Current = PreviousNode;
                    Current.Next = temp;
                    return Head;
                }
            }
            Head = Current.Next;
            return Head;
        }
        public Node PrintAllNodes(Node Head)
        {
            if (Head == null)
                return null;
            Node Current = Head;
            Console.WriteLine(Current.Data);
            while (Current.Next != null)
            {
                Current = Current.Next;
                Console.WriteLine(Current.Data);
            }
            return Head;
        }
    }   
}
