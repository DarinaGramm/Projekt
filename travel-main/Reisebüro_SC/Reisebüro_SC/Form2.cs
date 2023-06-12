using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Reisebüro_SC
{
    public partial class Buchung : Form
    {
        public Buchung() => InitializeComponent();

        /*Buchung(Reisebüro parentForm) : base()
        {
            this.parentForm = parentForm;
        }
        Reisebüro parentForm;*/

        private void Reserve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Title.Text) || string.IsNullOrEmpty(FirstName.Text) || string.IsNullOrEmpty(Surname.Text) || string.IsNullOrEmpty(DateOfBirth.Text) || string.IsNullOrEmpty(TelephoneNumber.Text) || string.IsNullOrEmpty(E_Mail.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus!");
            }
            else
            {
                DB db = new DB();

                MySqlCommand insert = new MySqlCommand("insert into clients(`title`, `name`, `surname`, `date_of_birth`, `telephone_number`, `e-mail`) values('" + this.Title.Text + "','" + this.FirstName.Text + "','" + this.Surname.Text + "','" + this.DateOfBirth.Text + "','" + this.TelephoneNumber.Text + "','" + this.E_Mail.Text + "')", db.getConnection());

                db.openConnection();

                insert.ExecuteNonQuery();

                db.closeConnection();

                MessageBox.Show("Vielen Dank für Ihre Buchung!");
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
    }
}
