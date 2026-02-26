using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library_Books_project.data
{
    class Repositories
    {
        DBConnection DBConnection = new DBConnection();

       
        // data insert method
        public void insertData(int type , string title, double price, double maintenance , double finalPrice)
        {
            string bookType = booksInfo.BookType.bookType(type);
            
            string insert_quert = @"insert into tlb_BooksSystem(BookType,Title,Price,MaintenanceCost,FinalPrice) values(@BookType,@Title,@Price,@MaintenanceCost,@FinalPrice)";

            using(var connection = DBConnection.getConnection())
            using (SqlCommand cmd = new SqlCommand(insert_quert, connection))
            {
                connection.Open();
                cmd.Parameters.AddWithValue(@"BookType", bookType);
                cmd.Parameters.AddWithValue(@"Title", title);
                cmd.Parameters.AddWithValue(@"Price", price);
                cmd.Parameters.AddWithValue(@"MaintenanceCost", maintenance);
                cmd.Parameters.AddWithValue(@"FinalPrice", finalPrice);

                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }

        public  DataTable showAll()
        {
            string showAll_query = "select * from tlb_BooksSystem";
            DataTable dt = new DataTable();
            using (var connection = DBConnection.getConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(showAll_query, connection))
            {
                adapter.Fill(dt);
            }


            return dt;
        }

    }
}
