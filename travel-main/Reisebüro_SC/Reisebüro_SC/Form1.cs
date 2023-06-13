using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
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
            MySqlCommand display = new MySqlCommand("SELECT hotel_name, place, price FROM travels", db.getConnection());

            db.openConnection();

            //display.Parameters.AddWithValue("@hotel_name", .Text);
           // display.Parameters.AddWithValue("@place", place.Text);
           // display.Parameters.AddWithValue("@price", price.Text);

            MySqlDataReader travels = display.ExecuteReader();
        
            while (travels.Read())
            {
                var hotel = travels.GetString(0);
                var place = travels.GetString(1);
                var price = travels.GetString(2);

                Panel panel = new FlowLayoutPanel();
                panel.Name = hotel;
                panel.BackColor = Color.White;
  
             
                Label labelHotel = new Label();
                labelHotel.Text = hotel;
                labelHotel.Name = "hotelNAME";
                
                
                
                Label labelPlace= new Label();
                labelPlace.Text = place;
                labelPlace.Name = "placeName";
                
                
                
                


           // panel.Controls.Add(labelPlace);

                Label labelPrice = new Label();
                labelPrice.Text = price;
                labelPrice.Name = "priceName";
                panel.Controls.Add(labelHotel);
                panel.Controls.Add(labelPlace);
                panel.Controls.Add(labelPrice);
                
               
                flp.Controls.Add(panel);


                //TravelID.Button = travels.GetValue(0).ToString();

                //MessageBox.Show(hotel);
                //MessageBox.Show(price);
                //MessageBox.Show(place);
                // hotelName.Text = travels.GetValue(0).ToString();
                //place.Text = travels.GetValue(1).ToString();
                //price.Text = travels.GetValue(2).ToString();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
