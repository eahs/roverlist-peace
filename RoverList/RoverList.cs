using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public class RoverList<T> : RoverListBase<T>
    {
        // Add any variables you need here
        private int count;
        
        public RoverList ()
        {
            count = 0;
        }

        public override int Count => count;

        public override void Add(T data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                current = newNode;
            }
            else
            {
                current.Next = newNode;
                current = newNode;
            }
            count++;
        }

        public override void Add(int position, T data)
        {
            Node newNode = new Node(data);

            if (position >= count || head == null)
            {
                Add(data);
            }
            else if (position == 0)
            {
                Node old = head;
                head = newNode;
                head.Next = old;
            }
            else
            {
                Node previous = NodeAt(position - 1);
                Node old = previous.Next;
                previous.Next = newNode;
                newNode.Next = old;
            }
            count++;
        }

        public override void Clear()
        {
            head = null;
            count = 0;
        }

        public override T ElementAt(int position)
        {
            throw new NotImplementedException(); //not sure how to do this. I think theres already an ElementAt method in c#. 
        }

        public override void ListNodes()
        {
            int z = 0; 
            while (current.Next != null)
            {
                Console.WriteLine(NodeAt(z));
                current = current.Next; 
                z++; 
            }
            //throw new NotImplementedException();
        }

        public override T RemoveAt(int position)
        {
            T removedValue = default(T);
            
            if (position == 0)
            {
                removedValue = head.Data;
                head = head.Next; 
            }
            else
            {
                Node previous = NodeAt(position - 1);
                removedValue = previous.Data;
                previous.Next = previous.Next.Next; 
            }

            return removedValue;
        }

        private Node NodeAt(int position)
        {
            Node previous = head;
            int currPos = 0;
                
            while(currPos <= position)
            {
                previous = previous.Next;
                currPos++;
            }

            return previous;
        }
        
        
    }
}
