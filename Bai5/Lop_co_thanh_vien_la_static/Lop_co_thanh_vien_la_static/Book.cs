using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lop_co_thanh_vien_la_static
{
    internal class Book
    {
        //prop
        public string bid { get; set; }
        public string bname { get; set; }
        public int numberPage { get; set; }
        public double price { get; set; }
        static int count = 0;

        //ctor
        public Book()
        {
            count++;
        }

        public Book(string bid, string bname, int numberPage, double price)
        {
            count++;
            this.bid = bid;
            this.bname = bname;
            this.numberPage = numberPage;
            this.price = price;
        }

        public static int GetNumberOfBook()
        {
            return count;
        }


        public override string ToString()
        {
            return bid + "\t" + bname + "\t" + numberPage + "\t" + price;
        }
    }
}
