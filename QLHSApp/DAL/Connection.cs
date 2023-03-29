using System.Data.SqlClient;

namespace DAL
{
    public class Connection
    {
        static string cnstr = @"Data Source=LAPTOP-HH0VDAPF;Initial Catalog=QLHS;Integrated Security=True;User ID=;Password=";
        SqlConnection cnn = new SqlConnection(cnstr);
    }
}