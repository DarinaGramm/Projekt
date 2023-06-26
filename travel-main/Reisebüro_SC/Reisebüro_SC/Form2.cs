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
using Org.BouncyCastle.Ocsp;
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Reisebüro_SC
{
    public partial class Buchung : Form
    {
        string id_button;

        private void Reserve_Click(object sender, EventArgs e)
           
        {
           
            if (string.IsNullOrEmpty(Title.Text) || string.IsNullOrEmpty(FirstName.Text) || string.IsNullOrEmpty(Surname.Text) || string.IsNullOrEmpty(DateOfBirth.Text) || string.IsNullOrEmpty(TelephoneNumber.Text) || string.IsNullOrEmpty(E_Mail.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus!");
            }
            else
            {
                if (!isValidated(E_Mail.Text, "email") && !isValidated(TelephoneNumber.Text, "telefonnumber") && !isValidated(Title.Text, "title")) {



                    DB db = new DB();

                    MySqlCommand insert = new MySqlCommand("INSERT INTO clients(`title`, " +
                        "`name`, `surname`, `date_of_birth`, `telephone_number`, `e-mail`, `travel_id`" +
                        " ) VALUES('" + this.Title.Text + "','" + this.FirstName.Text + "','" +
                        this.Surname.Text + "','" + this.DateOfBirth.Text + "','" + this.TelephoneNumber.Text +
                        "','" + this.E_Mail.Text + "','" + id_button + "')", db.getConnection());

                    db.openConnection();

                    insert.ExecuteNonQuery();

                    db.closeConnection();

                    MessageBox.Show("Vielen Dank für Ihre Buchung!");


                    Reisebüro checkout = new Reisebüro();
                    checkout.ShowDialog(this);
                }
            }
        }


        public Buchung(string optionalParameter = null)
        {
            InitializeComponent();
           
            if (optionalParameter != null)
            {
                id_button = optionalParameter;
   
            }
            
        }





        private void Titel_Enter(object sender, EventArgs e)
        {
            if (Title.Text == "Anrede eingeben")
            {
                Title.Text = "";
            }
        }

        private void Titel_Leave(object sender, EventArgs e)
        {
            if (Title.Text == "")
            {
                Title.Text = "Anrede eingeben";
                Title.ForeColor = Color.Gray;
            }
        }

        private void FirstName_Enter(object sender, EventArgs e)
        {
            if (FirstName.Text == "Vornamen eingeben")
            {
                FirstName.Text = "";
            }
        }

        private void FirstName_Leave(object sender, EventArgs e)
        {
            if (FirstName.Text == "")
            {
                FirstName.Text = "Vornamen eingeben";
                FirstName.ForeColor = Color.Gray;
            }
        }

        private void Surname_Enter(object sender, EventArgs e)
        {
            if (Surname.Text == "Nachnamen eingeben")
            {
                Surname.Text = "";
            }
        }

        private void Surname_Leave(object sender, EventArgs e)
        {
            if (Surname.Text == "")
            {
                Surname.Text = "Nachnamen eingeben";
                Surname.ForeColor = Color.Gray;
            }
        }

        bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            bool isValid = Regex.IsMatch(email, pattern);

            return isValid;
        }


        static bool isValidated(string strinG, string type)
        {
            switch (type)
            {
                case "telefonnumber":
                    if (strinG.Length != 11)
                    {
                        MessageBox.Show("Ungültige Telefonnummer");
                        return true;
                    }
                    break;

                case "email":
                    string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
                    bool isValid = Regex.IsMatch(strinG, pattern);
                    if(!isValid)
                    {
                        MessageBox.Show("Ungültige E-Mail-Adresse");
                        return true;
                    }
                    break;
                case "title":

                    string lowerInput = strinG.ToLower();

                    if(lowerInput.StartsWith("frau") || lowerInput.StartsWith("herr") || lowerInput.StartsWith("dr"))
                    {
                        return false;
                    }else
                    {
                        MessageBox.Show("Ungültige Anrede");
                        return true;
                    }
                    
            }

            return false; 
        }


        private void E_Mail_Enter(object sender, EventArgs e)
        {
            if (E_Mail.Text == "E-Mail-Adresse eingebe")
            {
                E_Mail.Text = "";
            }
        }

        private void E_Mail_Leave(object sender, EventArgs e)
        {
            if (E_Mail.Text == "")
            {
                E_Mail.Text = "E-Mail-Adresse eingeben";
                E_Mail.ForeColor = Color.Gray;
            }
        }

        private void TelephoneNumber_Enter(object sender, EventArgs e)
        {
            if (TelephoneNumber.Text == "Telefonnummer eingeben")
            {
                TelephoneNumber.Text = "";
            }
        }

        private void TelephoneNumber_Leave(object sender, EventArgs e)
        {
            if (TelephoneNumber.Text == "")
            {
                TelephoneNumber.Text = "Telefonnummer eingeben";
                TelephoneNumber.ForeColor = Color.Gray;
            }
        }

        private void backButton(object sender, EventArgs e)
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
