using System;
using System.Collections.Generic;
using System.Linq;
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
            throw new NotImplementedException();
        }

        public override void ListNodes()
        {
            throw new NotImplementedException();
        }

        public Node RemoveAt(int position)
        {
            int x = 0; 
            while (current.Next != null)
            {
                x++;
                current = current.Next;
                if (x == position)
                {
                    current = current.Next; 
                }
            }
        }

        public Node NodeAt(int position)
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
