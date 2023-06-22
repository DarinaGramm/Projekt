using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Reisebüro_SC
{
    public partial class Buchung : Form
    {
        /*public void ComboBox()
        {
            DB db = new DB();
            MySqlCommand fill = new MySqlCommand("SELECT hotel_name FROM travels", db.getConnection());

            db.openConnection();

            fill.Parameters.AddWithValue("@hotel_name", TravelList.Items);

            MySqlDataReader travels = fill.ExecuteReader();

            while (travels.Read())
            {
                TravelList.Text = travels.GetValue(0).ToString();
            }

            db.closeConnection();
        }*/
        string id_button;

        private void Reserve_Click(object sender, EventArgs e)
           
        {
            if (string.IsNullOrEmpty(Title.Text) || string.IsNullOrEmpty(FirstName.Text) || string.IsNullOrEmpty(Surname.Text) || string.IsNullOrEmpty(DateOfBirth.Text) || string.IsNullOrEmpty(TelephoneNumber.Text) || string.IsNullOrEmpty(E_Mail.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus!");
            }
            else
            {
                DB db = new DB();
              
                MySqlCommand insert = new MySqlCommand("INSERT INTO clients(`title`, `name`, `surname`, `date_of_birth`, `telephone_number`, `e-mail`, `travel_id` ) VALUES('" + this.Title.Text + "','" + this.FirstName.Text + "','" + this.Surname.Text + "','" + this.DateOfBirth.Text + "','" + this.TelephoneNumber.Text + "','" + this.E_Mail.Text + "','" + id_button + "')", db.getConnection());

                db.openConnection();

                insert.ExecuteNonQuery();

                db.closeConnection();

                MessageBox.Show("Vielen Dank für Ihre Buchung!");
               
                Reisebüro checkout = new Reisebüro();
                checkout.ShowDialog(this);
            }
        }

        public Buchung()
        {
            InitializeComponent();
            //ComboBox();
        }
        public Buchung(string optionalParameter = null)
        {
            InitializeComponent();
           
            if (optionalParameter != null)
            {
                id_button = optionalParameter;
   
            }
            
        }

        private void FirstName_Enter(object sender, EventArgs e)
        {
            if (FirstName.Text == "Geben Sie Ihren Vornamen ein")
            {
                FirstName.Text = "";
            }
        }

        private void FirstName_Leave(object sender, EventArgs e)
        {
            if (FirstName.Text == "")
            {
                FirstName.Text = "Geben Sie Ihren Vornamen ein";
                FirstName.ForeColor = Color.Gray;
            }
        }

        private void Surname_Enter(object sender, EventArgs e)
        {
            if (Surname.Text == "Geben Sie Ihren Nachnamen ein")
            {
                Surname.Text = "";
            }
        }

        private void Surname_Leave(object sender, EventArgs e)
        {
            if (Surname.Text == "")
            {
                Surname.Text = "Geben Sie Ihren Nachnamen ein";
                Surname.ForeColor = Color.Gray;
            }
        }

        private void E_Mail_Enter(object sender, EventArgs e)
        {
            if (E_Mail.Text == "Geben Sie Ihre E-Mail-Adresse ein")
            {
                E_Mail.Text = "";
            }
        }

        private void E_Mail_Leave(object sender, EventArgs e)
        {
            if (E_Mail.Text == "")
            {
                E_Mail.Text = "Geben Sie Ihre E-Mail-Adresse ein";
                E_Mail.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          this.Hide();
       
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void Buchung_Load(object sender, EventArgs e)
        {

        }
    }
}
