using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<E>
    {
        private Element<E> top;
        private Element<E> temp;

        public E Peek() //look at the top element
        {
            if (top == null)
            {
                return default(E);
            }
            else return top.desc; 
        }

        public void Push(E element) //push current element to the top of the stack
        {
            if (top == null)
            {
                top = new Element<E> { desc = element, prev = null };
            }
            else
            {
                temp = new Element<E> { desc = element, prev = top };
                top = temp;
            }
        }

        public E Pop() //remove the top element of the stack
        {
            if (top == null)
            {
                Console.WriteLine("No elements on Stack to pop");
                throw new NullReferenceException();
            }
            else
            {
                E temp = top.desc;
                top = top.prev;
                return temp;
            }
        }
    }
}
