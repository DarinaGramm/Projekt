using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crmf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Reisebüro_SC
{
    public partial class Reisebüro : Form
    {
        public string GetItemText { get; private set; }
        List<Panel> panelList = new List<Panel>();
        public void Startpage()
        {
            DB db = new DB();
            MySqlCommand display = new MySqlCommand("SELECT hotel_name, place, price FROM travels", db.getConnection());
            db.openConnection();
            string regex = @"^(.*?)\,";
            Regex rg = new Regex(regex);
            MySqlDataReader travels = display.ExecuteReader();
            List<string> placesList = new List<string>();
    
            while (travels.Read())
            {

                var hotel = travels.GetString(0);
                var place = travels.GetString(1);
                var price = travels.GetString(2);
                Panel panel = new FlowLayoutPanel();
                
                panel.BackColor = Color.White;
                panel.Size = new Size(200, 268);
                var padding = panel.Padding;
                padding.Left = 5;
                panel.Padding = padding;


                MatchCollection matchedcountries = rg.Matches(place);

                Label labelHotel = new Label();
                labelHotel.Text = hotel;
                labelHotel.Name = "hotelNAME";
               

                Label labelPlace = new Label();
                labelPlace.Text = place;
                labelPlace.Name = "placeName";
                

                Label labelPrice = new Label();
                labelPrice.Text = price;
                labelPrice.Name = "priceName";


                PictureBox pb1 = new PictureBox();
                //MessageBox.Show(hotel);
                pb1.ImageLocation = "../Bilder/" + hotel + ".jpg";
        
                pb1.Size = new Size(183, 137);
                var margin = pb1.Margin;
                margin.Bottom = 15;
                margin.Top = 10;
                padding.Right = 5;
                pb1.Margin = margin;
                pb1.Padding = padding;
                pb1.SizeMode = PictureBoxSizeMode.StretchImage;


                System.Windows.Forms.Button myButton = new System.Windows.Forms.Button();
                myButton.Text = "Buchen";
                myButton.Name = "buchungButton";
                margin = myButton.Margin;
                margin.Top = 25;
                myButton.Margin = margin;
                myButton.Click += buchungButton_Click;


                panel.Controls.Add(pb1);
                panel.Controls.Add(labelHotel);
                panel.Controls.Add(labelPlace);
                panel.Controls.Add(labelPrice);
                panel.Controls.Add(myButton);
               

                for (int count = 0; count < matchedcountries.Count; count++)
                {
                    placesList.Add(matchedcountries[count].Value);
                    panel.Name = matchedcountries[count].Value;
                }



                flp.Controls.Add(panel);
                panelList.Add(panel);
            }
            setComboBox(placesList, cbPlace);
            db.closeConnection();
        }

      
        
        public void setComboBox(List<string> list, dynamic cb) {
            cb.Items.Add("Alles");
            string[] places = list.ToArray();
            for (int i = 0; i < places.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (places[i] == places[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    cb.Items.Add(places[i]);
                   
                }
            }

        }

        public Reisebüro()
        {
            InitializeComponent();
            Startpage();
        }

        public void buchungButton_Click(object sender, EventArgs e)
        {
            Buchung checkout = new Buchung();
            checkout.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reisebüro_Load(object sender, EventArgs e)
        {
           


        }

        private void cbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void search_Click(object sender, EventArgs e)
        {

            string place = cbPlace.Text;
            Panel[] panels = panelList.ToArray();
         
            for (int i = 0; i < panels.Length; i++)
            {
                if (panels[i].Name != cbPlace.Text)
                {
                    flp.Controls.Remove(panels[i]);

                }
                else
                {
                    flp.Controls.Add(panels[i]);
                }
                if (cbPlace.Text == "Alles"){
                    flp.Controls.Add(panels[i]);
                   
                }
            }
            
        }
    }
}
