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
                Node previous = head;
                int currPos = 0;
                
                while(currPos < position - 1)
                {
                    previous = previous.Next;
                    currPos++;
                }
                
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

        public override T ElementAt(int Position)
        {
            throw new NotImplementedException();
        }

        public override void ListNodes()
        {
            throw new NotImplementedException();
        }

        public override bool RemoveAt(int Position)
        {
            throw new NotImplementedException();
        }
    }
}
