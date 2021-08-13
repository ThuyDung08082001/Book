using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctdt_Book
{
    class Book
    {
        private static int _count = 0;
        private string _title;
        private int _id;
        private string _author;
        private double _price;
        private DateTime _date;

        public static int Count
        {
            get
            {
                return _count;
            }

            set
            {
                _count = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }

        public Book()
        {
            Count++;
            this.Title = "";
            this.Id = 0;
            this.Author = "";
            this.Price = 0.0;
            this.Date = new DateTime();
        }

        public Book(string title, string author, double price, DateTime date)
        {
            Count++;
            this.Title = title;
            this.Id = Count;
            this.Author = author;
            this.Price = price;
            this.Date = date;
        }

        public string toString()
        {
            return $"BOOK.\n\tTitle:{this._title}\n\tID:{this._id}\n\tAuthor:{this._author}\n\tPrice:{this._price}\n\tDate:{this._date}";
        }
    }
}
