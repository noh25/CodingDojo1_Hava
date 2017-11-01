using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Element<E>
    {
        public E desc { get; set; } //the element description
        public Element<E> prev; //previously stacked element
    }
}
