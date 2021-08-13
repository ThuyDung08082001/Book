using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctdt_Book
{
    class Node
    {
        private Node next;
        private Book value;

        internal Node Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }

        internal Book Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }
        public Node()
        {

        }
        public Node(Book values)
        {
            this.value = values;
        }
    }
}
