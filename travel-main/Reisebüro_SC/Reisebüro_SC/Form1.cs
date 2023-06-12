using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Reisebüro_SC
{
    public partial class Reisebüro : Form
    {

        public Reisebüro() => InitializeComponent();
        
        private void Reisebüro_Load(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            MySqlDataReader dataReader = null;
            try
            {
                MySqlCommand select = new MySqlCommand("SELECT hotel_name, place, price FROM travels WHERE travel_id = 1");
                dataReader = select.ExecuteReader();
                ListViewItem item = null;

                while (dataReader.Read())
                {
                    item = new ListViewItem(new string[]
                    {
                        Convert.ToString(dataReader["hotel_name"]),
                        Convert.ToString(dataReader["place"]),
                        Convert.ToString(dataReader["price"])
                    });
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }

            /*SQL sql = new SQL();
            //MySqlConnection sql = new MySqlConnection("server=localhost;username=root;password=;database=travel_agancy");
            MySqlDataReader reader;
            //sql.ConnectionString = "server=localhost;username=root;password=;database=travel_agancy";
            MySqlCommand cmd = new MySqlCommand("SELECT hotel_name, place, price FROM travels WHERE travel_id = 1", sql.getConnection());
            //cmd.Connection = sql;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT hotel_name, place, price FROM travels WHERE travel_id = 1";
            sql.openConnection();
            reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                HotelName.Text = (reader["hotel_name"].ToString());
                Place.Text = (reader["place"].ToString());
                Price.Text = (reader["price"].ToString());
            }
            sql.closeConnection();*/

            /*MySqlCommand comando = new MySqlCommand();
            string myConnectionString = "server=localhost;username=root;password=;database=travel_agancy";
            MySqlConnection conn = new MySqlConnection(myConnectionString);
            comando.Connection = conn;
            comando.CommandText = "SELECT hotel_name, place, price FROM travels WHERE travel_id = 1";
            conn.Open();
                HotelName.Text = comando.ExecuteScalar().ToString();
                Place.Text = comando.ExecuteScalar().ToString();
                Price.Text = comando.ExecuteScalar().ToString();
            conn.Close();*/

            /*MySqlConnection connection = new MySqlConnection("server=localhost;username=root;password=;database=travel_agancy");
            SQL sql = new SQL();

            MySqlCommand select = new MySqlCommand("SELECT hotel_name, place, price FROM travels WHERE travel_id = 1");
            sql.openConnection();
            MySqlDataReader reader;
            reader = select.ExecuteReader();
            
            while(reader.Read())
            {
                HotelName.Text = (reader["hotel_name"].ToString());
                Place.Text = (reader["place"].ToString());
                Price.Text = (reader["price"].ToString());
            }
            reader.Close();
            reader.Dispose();
            sql.closeConnection();
            select.Dispose();*/

            /*SQL sql = new SQL();
            using (MySqlConnection connection = new MySqlConnection())
            {
                using (MySqlCommand display = new MySqlCommand("SELECT hotel_name, place, price FROM travels WHERE travel_id = 1"))
                {
                    display.CommandType = CommandType.Text;
                    display.Connection = connection;
                    sql.openConnection();
                    using (MySqlDataReader reader = display.ExecuteReader())
                    {
                        reader.Read();
                        HotelName.Text = reader["hotel_name"].ToString();
                        Place.Text = reader["place"].ToString();
                        Price.Text = reader["price"].ToString();
                    }
                    sql.closeConnection();
                }
            }*/

            /*SQL sql = new SQL();

            sql.openConnection();
            
            MySqlCommand display = new MySqlCommand("SELECT hotel_name, place, price FROM travels WHERE travel_id = 1");
                display.Parameters.AddWithValue("@hotel_name", HotelName.Text);
                display.Parameters.AddWithValue("@place", Place.Text);
                display.Parameters.AddWithValue("@price", Price.Text);
                //display.Parameters.AddWithValue("@travel_id", TravelID.Text);

            MySqlDataReader travels = display.ExecuteReader();

            while (travels.Read())
            {
                //TravelID.Button = travels.GetValue(0).ToString();
                HotelName.Text = travels.GetValue(0).ToString();
                Place.Text = travels.GetValue(1).ToString();
                Price.Text = travels.GetValue(2).ToString();
            }
            sql.closeConnection();*/
        }

        public void ZurBuchung_Click(object sender, EventArgs e)
        {
            Buchung checkout = new Buchung();
            checkout.ShowDialog(this);
        }
        
    }
}
