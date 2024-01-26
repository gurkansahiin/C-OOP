using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje
{
    public class trigger
    {

       public static void PerformDatabaseAction(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Bağlantı başarıyla açıldı.");

               
                    string sqlCommand = "DELETE FROM UyeTbl WHERE UBitis < GETDATE()";
                    SqlCommand command = new SqlCommand(sqlCommand, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı açılırken hata oluştu: " + ex.Message);
                }
            }
        }

    }
}
