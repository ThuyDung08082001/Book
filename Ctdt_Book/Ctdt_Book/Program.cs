using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctdt_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.AddFirst(new Book("giam doc", "dung", 23000, new DateTime(19 / 8 / 2019)));
            linkedList.AddFirst(new Book("pho giam doc", "an", 22000, new DateTime(13 / 7 / 2020)));
            linkedList.AddFirst(new Book("nha xuat ban", "trang", 3000, new DateTime(3 / 2 / 2009)));
            linkedList.AddFirst(new Book("nha san xuat", "ly", 2000, new DateTime(9 / 3 / 2000)));

            for (Node i = linkedList.First; i != null; i = i.Next)
            {
                Console.WriteLine(i.Value.toString());
            }
            Console.WriteLine("****************************");
            LinkedList linkedList1 = linkedList.InterchangeSort();
            for (Node i = linkedList.First; i != null; i = i.Next)
            {
                Console.WriteLine(i.Value.toString());
            }
            Console.WriteLine("****************************");
            LinkedList linkedList2 = linkedList.InterchangeSort();
            for (Node i = linkedList.First; i != null; i = i.Next)
            {
                Console.WriteLine(i.Value.toString());
            }
        }
    }
}
