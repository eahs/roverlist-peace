using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public abstract class RoverListBase<T>
    {

        public class Node
        {
            public T Data { get; set; }
            public Node Next;

            public Node (T data)
            {
                this.Data = data;
            }
        }

        public abstract int Count
        {
            get;
        }

        /// <summary>
        /// The head of the list.
        /// </summary>
        protected Node head;

        /// <summary>
        /// The current node, used to avoid adding nodes before the head
        /// </summary>
        protected Node current;

        /// <summary>
        /// Add a new Node to end of the list.
        /// </summary>
        public abstract void Add(T data);

        /// <summary>
        /// Inserts a new Node to the list at the specified position, shifting everything from
        /// position on one to the right.
        /// </summary>
        /// <param name="Position">Zero-based position of the node to add (Position 0 is the first node, 1 is the second, etc)</param>         
        public abstract void Add(int Position, T data);


        /// <summary>
        ///  Throwing this in to help test the list - This should print the full contents of the list
        /// </summary>
        public abstract void ListNodes();


        /// <summary>
        /// Returns the element T in the specified position or null if does not exist
        /// </summary>
        /// <param name="Position">One based position of the node to retrieve</param>
        /// <returns>The desired node or null if inexistent</returns>
        public abstract T ElementAt(int Position);

        /// <summary>
        /// Delete a Node in the specified position
        /// </summary>
        /// <param name="Position">Position of node to be deleted</param>
        /// <returns>Successful</returns>
        public abstract bool RemoveAt(int Position);

        /// <summary>
        /// Removes all Nodes from the list
        /// </summary>
        /// <returns>void</returns>
        public abstract void Clear();

    }
}
