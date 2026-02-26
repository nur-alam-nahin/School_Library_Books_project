using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library_Books_project
{
    class Program
    {
        static void Main(string[] args)
        {
            booksInfo.BookInfo bookInfo = new booksInfo.BookInfo();
            data.Repositories repositories = new data.Repositories();

            int num;
            do
            {
                Console.WriteLine("----- Library Books System -----");
                Console.WriteLine("1. Add Books");
                Console.WriteLine("2. show all Books");
                Console.WriteLine("3. Exite");
                num = Convert.ToInt32(Console.ReadLine());

                if(num >= 1 && num < 3)
                {
                    switch (num)
                    {
                        case 1:
                            Console.Write("Book type \n 1. Printed Book \n 2. Digital Book \n");
                            int type = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Title = ");
                            bookInfo.title = Console.ReadLine();

                            Console.Write("Price = ");
                            bookInfo.price = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Maintenance Cost = ");
                            bookInfo.maintenance_cost = Convert.ToDouble(Console.ReadLine());


                            bookInfo.final_price = service.Billing.billing(bookInfo.price, bookInfo.maintenance_cost);

                            repositories.insertData(type, bookInfo.title, bookInfo.price, bookInfo.maintenance_cost, bookInfo.final_price);


                            break;

                        case 2:
                            service.ShowData.showData();
                            break;
                    }

                }
                else{
                    if(num == 3)
                    Environment.Exit(3);
                }
            } while (true);


           
        }
    }
}
