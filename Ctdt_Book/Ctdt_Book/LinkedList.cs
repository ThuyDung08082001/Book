using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctdt_Book
{
    class LinkedList
    {
        private Node last;
        private Node first;
        private int count;

        internal Node Last
        {
            get
            {
                return last;
            }

            set
            {
                last = value;
            }
        }

        internal Node First
        {
            get
            {
                return first;
            }

            set
            {
                first = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }
        public LinkedList()
        {
            this.last = null;
            this.first = null;
            this.count = 0;
        }
        public Node AddFirst(Book book)
        {
            Node node = new Node(book);
            if (count == 0)
            {
                this.first = node;
                this.last = this.first;
            }
            else
            {
                node.Next = this.first;
                this.first = node;
            }
            this.Count++;
            return node;
        }
        public void AddFirst(Node node)
        {
            Node nodes = null;
            if (count == 0)
            {
                this.first = nodes;
                this.last = this.first;
            }
            else
            {
                nodes.Next = this.first;
                this.first = nodes;
            }

            this.Count++;
        }
        public bool AddAfter(Node node, Book book)
        {
            bool kq = true;
            Node nodes = new Node(book);
            if (node.Next != null)
            {
                nodes.Next = node.Next;
                node.Next = nodes;
            }
            else
            {
                node.Next = nodes;
                this.last = nodes;
                kq = false;
            }
            return kq;
        }
        public bool AddAfter(Node node, Node newNode)
        {
            bool kq = true;
            Node nodes = null;
            if (node.Next != null)
            {
                nodes.Next = node.Next;
                node.Next = nodes;
            }
            else
            {
                node.Next = nodes;
                this.last = nodes;
            }
            kq = false;
            return kq;
        }


        public Book RemoveAfter(Node node, int id)
        {
            Book book = new Book();

            if (node.Next != null)
            {
                if (node.Next.Next != null)
                {
                    Node nodes = node.Next;
                    node.Next = node.Next.Next;
                    node.Next = null;
                }
                else
                {
                    node.Next = null;
                    this.last = node;
                }

            }
            return book;
        }
        public Book Find(string title)
        {
            Book book = new Book();
            Node node = null;
            for (Node i = this.first; i != null; i = i.Next)
            {
                if (i.Value.Title.Equals(title))
                {
                    node = i;
                    break;
                }
            }
            return book;
        }
        public Book FindLast(string title)
        {
            Book book = new Book();
            Node node = null;
            for (Node i = this.Last; i != null; i = i.Next.Next)
            {
                if (i.Value.Title.Equals(title))
                {
                    node = i;
                    break;
                }
            }
            return book;
        }
        public void InterchangeSort()
        {

            for (Node i = this.first; i != null; i = i.Next)
            {
                for (Node j = this.first; j != null; j = j.Next)
                {
                    Swap(ref i, ref j);
                }
            }

        }
        public void Swap(ref Node node1, ref Node node2)
        {
            Book book = node1.Value;
            node1.Value = node2.Value;
            node2.Value = book;
        }
        public void BubbleSort()
        {
            for (Node i = this.last; i != null; i = i.Next)
            {
                for (Node j = this.First; j != null; j = j.Next)
                {
                    Swap(ref j, ref j);
                }
            }
        }

    }
}
