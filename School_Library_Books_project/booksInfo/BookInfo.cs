using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library_Books_project.booksInfo
{
    class BookInfo
    {
        public string bookType { get; set; }
        public string title { get; set; }
        public double price { get; set; } = 0;
        public double maintenance_cost { get; set; } = 0;
        public double final_price { get; set; } = 0;

    }
}
