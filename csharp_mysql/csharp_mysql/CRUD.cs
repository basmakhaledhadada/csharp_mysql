using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace csharp_mysql
{
    class CRUD
    {
        public static string constring = "datasource=localhost;port=3306;username=root;password=";
        public static string sql = "";
        public static MySqlConnection con = new MySqlConnection(constring);
        public static MySqlCommand cmd = default(MySqlCommand);

        public static DataTable PreformCRUD(MySqlCommand com)
        {
            MySqlDataAdapter adapter = default(MySqlDataAdapter);
            DataTable dt = new DataTable();
            try
            {
                adapter = new MySqlDataAdapter();
                adapter.SelectCommand = com ;
                adapter.Fill(dt);
                return dt;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error executing!" + ex);
            }
            return dt;

        }

    }


}
