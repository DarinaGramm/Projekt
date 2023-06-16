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
using System.Windows.Forms.VisualStyles;
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

                Panel panel = CreatePanel();
                Label labelHotel = CreateLabel(hotel, "hotelNAME", new Size(190, 20));
                Label labelPlace = CreateLabel(place, "placeName", new Size(170, 35));
                Label labelPrice = CreateLabel($"{price}€", "priceName", new Size(100, 20));

                PictureBox pb1 = CreatePb("../Bilder/" + hotel + ".jpg", new Size(183, 137));
                System.Windows.Forms.Button myButton = CreateButton("Buchen", "buchungButton", buchungButton_Click);

                panel.Controls.Add(pb1);
                panel.Controls.Add(labelHotel);
                panel.Controls.Add(labelPlace);
                panel.Controls.Add(labelPrice);
                panel.Controls.Add(myButton);

                MatchCollection matchedcountries = rg.Matches(place);
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

        // Function to create a Panel with common settings
        Panel CreatePanel()
        {
            Panel panel = new FlowLayoutPanel
            {
                Padding = new Padding(5, 0, 0, 0),
                BackColor = Color.White,
                Size = new Size(200, 268)
            };

            return panel;
        }

        Label CreateLabel(string text, string name, Size size)
        {
            Label label = new Label
            {
                Text = text,
                Name = name,
                Size = size
            };

            return label;
        }

        PictureBox CreatePb(string imageLocation, Size size)
        {
            PictureBox pb = new PictureBox
            {
                ImageLocation = imageLocation,
                Size = size,
                Margin = new Padding { Bottom = 15, Top = 10 },
                Padding = new Padding { Left = 5 },
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            return pb;
        }

        System.Windows.Forms.Button CreateButton(string text, string name, EventHandler clickHandler)
        {
            System.Windows.Forms.Button button = new System.Windows.Forms.Button
            {
                Text = text,
                Name = name,
                Margin = new Padding { Top = 20 }
            };

            button.Click += clickHandler;

            return button;
        }

        public void styleElement(dynamic element, int number, dynamic position) {

           var elementStyled = element;
            //element = new Thickness(15);
            //elementStyled.position = number;
            elementStyled.Left = number;
            element = elementStyled;
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

            string placeSelected = cbPlace.Text;
            Panel[] panelArray = panelList.ToArray();
         
            for (int i = 0; i < panelArray.Length; i++)
            {
                if (panelArray[i].Name != placeSelected)
                {
                    flp.Controls.Remove(panelArray[i]);

                }
                else
                {
                    flp.Controls.Add(panelArray[i]);
                }
                if (cbPlace.Text == "Alles"){
                    flp.Controls.Add(panelArray[i]);
                   
                }
            }
            
        }
    }
}
