using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library_Books_project.service
{
    class ShowData
    {
        public static void showData()
        {
            data.Repositories repositories = new data.Repositories();
            DataTable dt = repositories.showAll();

            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine($"Book Id = {row["Id"]}");
                Console.WriteLine($"TItle = {row["Title"]}");
                Console.WriteLine($"Book type = {row["BookType"]}");
                Console.WriteLine($"Price = {row["Price"]}");
                Console.WriteLine($"Maintenance Cost = {row["MaintenanceCost"]}");
                Console.WriteLine($"Final Price = {row["FinalPrice"]}");
                Console.WriteLine();
            }
        }
    }
}
