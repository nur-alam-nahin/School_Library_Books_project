using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library_Books_project.booksInfo
{
    class BookType
    {
        public static string bookType(int num)
        {
            if(num == 1)
            {
                string printedBook = "Printed Book";
                return printedBook;
            }
            else
            {
                string digitalBook = "Digital Book";
                return digitalBook;
            }
        }
        
         
    }
}
