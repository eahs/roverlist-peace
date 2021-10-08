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
            }
            else
            {
                current.Next = newNode;
                current = newNode;
            }
            count++;
        }

        public override void Add(int Position, T data)
        {
            Node newNode = new Node(data);
            
            throw new NotImplementedException();
        }

        public override void Clear()
        {
            head = null;
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
