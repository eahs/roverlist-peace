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
        
        public RoverList ()
        {

        }

        public override int Count => throw new NotImplementedException();

        public override void Add(T data)
        {
            throw new NotImplementedException();
        }

        public override void Add(int Position, T data)
        {
            throw new NotImplementedException();
        }

        public override void Clear()
        {
            throw new NotImplementedException();
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
