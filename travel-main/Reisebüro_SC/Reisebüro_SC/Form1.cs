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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace Reisebüro_SC
{
    public partial class Reisebüro : Form
    {
        public void Startpage()
        {
            DB db = new DB();
            MySqlCommand display = new MySqlCommand("SELECT hotel_name, place, price FROM travels WHERE travel_id = 1", db.getConnection());

            db.openConnection();

            display.Parameters.AddWithValue("@hotel_name", HotelName.Text);
            display.Parameters.AddWithValue("@place", Place.Text);
            display.Parameters.AddWithValue("@price", Price.Text);

            MySqlDataReader travels = display.ExecuteReader();
        
            while (travels.Read())
            {
                //TravelID.Button = travels.GetValue(0).ToString();
                HotelName.Text = travels.GetValue(0).ToString();
                Place.Text = travels.GetValue(1).ToString();
                Price.Text = travels.GetValue(2).ToString();
            }

            db.closeConnection();
        }

        public Reisebüro()
        {
            InitializeComponent();
            Startpage();
        }

        public void ZurBuchung_Click(object sender, EventArgs e)
        {
            /*TravelID = "ZurBuchung";
            using (Add add = new Add())
            {
                add.buttonID = TravelID;
                add.ShowDialog();
            }
            @travel_id.HiddenFor(model => );
            //display.Parameters.AddWithValue("@travel_id", TravelID.Text);*/
            Buchung checkout = new Buchung();
            checkout.ShowDialog(this);
        }
    }
}
