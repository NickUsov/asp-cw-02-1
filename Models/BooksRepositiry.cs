using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class BooksRepositiry
    {
        public static int Count;
        static BooksRepositiry()
        {
            Count = 0;
        }
        public void Add(Book book)
        {
            Count++;
        }
    }
}