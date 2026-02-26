using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library_Books_project.data
{
    class DBConnection
    {
        private readonly string connection_query = "server=.;Database=SchoolLibraryBooksPJ; Integrated Security = true;";
        public SqlConnection getConnection()
        {
            return new SqlConnection(connection_query);
        }


    }
}
