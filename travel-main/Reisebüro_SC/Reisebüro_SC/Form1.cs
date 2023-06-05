using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Reisebüro_SC
{
    public partial class Reisebüro : Form
    {
        public Reisebüro() => InitializeComponent();

        public void ZurBuchung_Click(object sender, EventArgs e)
        {
            /*String hotel_name = HotelName.Text;
            String place = Place.Text;
            String price = Price.Text;
            Button travel_id = TravelID.ID;
            
            DB db = new DB();

            MySqlCommand display = new MySqlCommand("select from travels(`hotel_name`, `place`, `price`) values('" + this.Title.Text + "','" + this.FirstName.Text + "','" + this.Surname.Text + "','" + this.DateOfBirth.Text + "','" + this.TelephoneNumber.Text + "','" + this.E_Mail.Text + "')", db.getConnection());

            db.openConnection();

            display.ExecuteNonQuery();

            db.closeConnection();

            MessageBox.Show("Vielen Dank für Ihre Buchung!");

            MySqlCommand select = new MySqlCommand("SELECT * FROM `travels`)", db.getConnection());
            select.Parameters.Add("@HotelName", MySqlDbType.VarChar).Value = HotelName.Text;
            select.Parameters.Add("@Place", MySqlDbType.VarChar).Value = Place.Text;
            select.Parameters.Add("@Price", MySqlDbType.VarChar).Value = Price.Text;
            select.Parameters.Add("TravelID", MySqlDbType.Int16).Value = TravelID.ID;
            */

            Buchung checkout = new Buchung();
            checkout.ShowDialog(this);
        }

    }
}
