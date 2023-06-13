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
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
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
            //display.Parameters.AddWithValue("@hotel_name", .Text);
          
            MySqlDataReader travels = display.ExecuteReader();
            List<string> placesList = new List<string>();
           

            // MatchCollection matchedcountries;
            while (travels.Read())
            {

                var hotel = travels.GetString(0);
                var place = travels.GetString(1);
                var price = travels.GetString(2);
                Panel panel = new FlowLayoutPanel();
                
                panel.BackColor = Color.White;
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

                System.Windows.Forms.Button myButton = new System.Windows.Forms.Button();
                myButton.Text = "Buchen";
                myButton.Name = "buchungButton";
                myButton.Click += buchungButton_Click;

                panel.Controls.Add(labelHotel);
                panel.Controls.Add(labelPlace);
                panel.Controls.Add(labelPrice);
                panel.Controls.Add(myButton);



                
                for (int count = 0; count < matchedcountries.Count; count++)
                {
                    placesList.Add(matchedcountries[count].Value);
                    //string val = matchedcountries[count].Value;
                    panel.Name = matchedcountries[count].Value;

                    //pa.Add(matchedcountries[count].Value, panel);
                    // Panel ha = pa[matchedcountries[count].Value];


                    /* if (pai.ContainsKey(matchedcountries[count].Value)) {
                         MessageBox.Show(matchedcountries[count].Value);
                         // pai = new Dictionary<String, List <Panel>>();
                        pai[val] = panel;


                         //pai[matchedcountries[count].Value].
                     }else
                     {
                         pai.Add(matchedcountries[count].Value, panel);
                     }
                    */




                }
                
                flp.Controls.Add(panel);

                panelList.Add(panel);

                /*
                cbPlace.Items.Clear();
                for (int i = 0; i < list[0].Count; i++)
                {
                    cbPlace.Items.Add(list[0][i]);
                }
                */

                //TravelID.Button = travels.GetValue(0).ToString();

                //MessageBox.Show(hotel);
                //MessageBox.Show(price);
                //MessageBox.Show(place);
                // hotelName.Text = travels.GetValue(0).ToString();
                //place.Text = travels.GetValue(1).ToString();
                //price.Text = travels.GetValue(2).ToString();
            }

            //setComboBox(matchedcountries1, cbPlace: cbPlace);


            setComboBox(placesList, cbPlace);


            db.closeConnection();
        }

      
        
        public void setComboBox(List<string> list, dynamic cb) {
            cb.Items.Add("Alles");
            string[] places = list.ToArray();
            //string[] 
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
