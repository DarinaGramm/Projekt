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
using Org.BouncyCastle.Utilities;
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
            string booked_travel_ids = "0";
            DB db = new DB();
            MySqlCommand display1 = new MySqlCommand("SELECT DISTINCT `travel_id` FROM clients WHERE `travel_id` IS NOT NULL",
            db.getConnection());
            db.openConnection();
            MySqlDataReader bookings = display1.ExecuteReader();

            while (bookings.Read()) {
                if (booked_travel_ids != "")
                {
                    booked_travel_ids += ",";
                }
                booked_travel_ids += bookings.GetString(0);
            }
            db.closeConnection();
 
            MySqlCommand display = new MySqlCommand($"SELECT `hotel_name`, `city`, `price`, `travel_id`," +
                $" `number_of_persons`, `start_date`, `end_date`, `country` FROM travels WHERE travel_id NOT IN " +
                $"({booked_travel_ids})", db.getConnection());
            db.openConnection();
            MySqlDataReader travels = display.ExecuteReader();
            List<string> placesList = new List<string>();
            List<string> numberPersonList = new List<string>();
            List<int> priceList = new List<int>();

            while (travels.Read())
            {
               
                var hotel = travels.GetString(0);
                var city = travels.GetString(1);
                var price = travels.GetString(2);
                var id = travels.GetString(3);
                var numberPerson = travels.GetString(4);
                var startDate = travels.GetString(5);
                var endDate = travels.GetString(6);
                var country = travels.GetString(7);
                string[] startDateSplit = startDate.Split(' ');
                string[] endDateSplit = endDate.Split(' ');

                Panel panel = CreatePanel(numberPerson, startDateSplit[0], endDateSplit[0]);
                Label labelHotel = CreateLabel(hotel, "hotelNAME", new Size(190, 20));
                Label labelPlace = CreateLabel($"{country + ", " + city}" , "placeName", new Size(170, 35));
                Label labelPrice = CreateLabel($"{price}€", "priceName", new Size(100, 20));

                PictureBox pb = CreatePb("../Bilder/" + hotel + ".jpg", new Size(183, 137));
                System.Windows.Forms.Button myButton = CreateButton("Buchen", $"{id}", buchungButton_Click);
        
                panel.Controls.Add(pb);
                panel.Controls.Add(labelHotel);
                panel.Controls.Add(labelPlace);
                panel.Controls.Add(labelPrice);
                panel.Controls.Add(myButton);
               
                    placesList.Add(country);
                    panel.Name = country;
                    numberPersonList.Add(numberPerson);
                    priceList.Add(int.Parse(price));
                    flp.Controls.Add(panel);
                    panelList.Add(panel);
            
            }
            

            db.closeConnection();

            setComboBox(placesList, cbCountry);
            setComboBox(numberPersonList, cbNP);
            setComboBoxPrice(priceList);

        }

        Panel CreatePanel(string number, string dateStart, string dateEnd)
        {
            Panel panel = new FlowLayoutPanel
            {
                Padding = new Padding(5, 0, 0, 0),
                BackColor = Color.White,
                Size = new Size(200, 268),
                Tag = number + ',' + dateStart + ',' + dateEnd

            };
            
            return panel;
        }

        Label CreateLabel(string text, string name, Size size)
        {
            Label label = new Label
            {
                Text = text,
                Name = name,
                Size = size,
                Font = new Font("Segoe UI Emoji", 8)
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
                Margin = new Padding { Top = 20 },
                Tag = name,
                Font = new Font("Segoe UI Emoji", 8)
            };


            button.Click += clickHandler;

            return button;
        }

        public void setComboBox(List<string> list, dynamic cb) {
            cb.Items.Add("Alles");
            list.Sort();
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
        public void setComboBoxPrice(List<int> prices)
        {
            prices.Sort();

            cbPrice.Items.Add("200 - 500");
            cbPrice.Items.Add("500 - 700");
            cbPrice.Items.Add("700 - 1000");
            cbPrice.Items.Add("1000 - 1500");
            cbPrice.Items.Add("1500 - 3000");

        }
        public bool priceInRange(string priceHotel, string priceSelected)
        {
            string ps = priceSelected.Replace(" ", "");
            string ph = priceHotel.Replace(" ", "");
            string[] parts = ps.Split('-');
            string[] priceHotelParts = ph.Split('€');
            int priceMin = int.Parse(parts[0]);
            int priceMax = int.Parse(parts[1]);
            int priceH = int.Parse(priceHotelParts[0]);

            if (priceH >= priceMin && priceH <= priceMax)
            {
                return true;
            }else
            {
                return false;
            }
        }


        public Reisebüro()
        {
            InitializeComponent();
            Startpage();
        }

        public void buchungButton_Click(object sender, EventArgs e)
        {
            string customParameter = ((System.Windows.Forms.Button)sender).Tag.ToString();
            Buchung checkout = new Buchung(customParameter);
            checkout.ShowDialog(this);
        }
        private void search_Click(object sender, EventArgs e)
        {
            string placeSelected = cbCountry.Text;
            string priceSelected = cbPrice.Text;
            
            Panel[] panelArray = panelList.ToArray();

            for (int i = 0; i < panelArray.Length; i++)
            {
                Label price = panelArray[i].Controls.Find("priceName", true).FirstOrDefault() as Label;
               
                if (panelArray[i].Name == placeSelected && priceInRange(price.Text, priceSelected))
                {
                    flp.Controls.Add(panelArray[i]);
                }
                else 
                {
                    flp.Controls.Remove(panelArray[i]);

                }
            }

            if (cbCountry.Text == "Alles")
            {
                flp.Controls.AddRange(panelArray);
            
            }
            
        }

        private void Reisebüro_Load(object sender, EventArgs e)
        {

        }
    }
}
