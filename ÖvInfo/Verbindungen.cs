using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖvInfo
{
    public partial class Verbindungen : Form
    {

        //Member Variabeln (From, To)
        private string m_From;
        private string m_To;
        private Connections m_connection;

        //Konstruktor ohne Parameter
        public Verbindungen()
        {
            InitializeComponent();
        }


        //Konstruktor mit Parameter (From,To)
        public Verbindungen(string From, string to, Connections connection)
        {
            m_From = From;
            m_To = to;
            m_connection = connection; 
            InitializeComponent();
        }


        // Anzeige der Daten in der List View
        private void Verbindungen_Load(object sender, EventArgs e)
        {
            //List View Column benennen und Spaltenbreite definieren
            listConnection.Columns.Add("", 26, HorizontalAlignment.Left);
            listConnection.Columns.Add("", 80, HorizontalAlignment.Left);
            listConnection.Columns.Add("Point of Departure:", 140, HorizontalAlignment.Left);
            listConnection.Columns.Add("Departure:", 100, HorizontalAlignment.Left);
            listConnection.Columns.Add("Platform:", 30, HorizontalAlignment.Left);
            listConnection.Columns.Add("Destination:", 140, HorizontalAlignment.Left);
            listConnection.Columns.Add("Arrival:", 100, HorizontalAlignment.Left);
            listConnection.Columns.Add("Platform:", 30, HorizontalAlignment.Left);  
            listConnection.Columns.Add("Duration", 100, HorizontalAlignment.Left);




            //Counter für Nummerierung der ListView Items 
            int lconn = 1;

            //Listview Items erstellen und hinzufügen + Counter erhöhen + Zeit Format Anpassen
            foreach (Connection conn in m_connection.ConnectionList )
            {

                
                //Zeit format der Ankunft, der Abfahrt un der Dauer ins richtige Format bringen
                DateTime Departure = DateTime.Parse(conn.From.Departure);
                DateTime Arrival = DateTime.Parse(conn.To.Arrival);
                String Duration = conn.Duration.Remove(0, 3);
                Duration = Duration.Remove(5, 3);

                int Arrival_Hour = Arrival.Hour;
                int Arrival_Minute = Arrival.Minute;
                int Departure_Hour = Departure.Hour;
                int Departure_Minute = Departure.Minute;
                string Arrivals;
                string Departures;
                int Departure_minute_count = Departure_Minute.ToString().Length;
                int Arrive_minute_count = Arrival_Minute.ToString().Length;

                if (Arrive_minute_count == 1)
                    {
                      Arrivals = Arrival_Hour + ":" + "0" + Arrival_Minute;
                    }
                    else
                        {
                          Arrivals = Arrival_Hour + ":" + Arrival_Minute;
                        }

                if (Departure_minute_count == 1)
                    {
                     Departures = Departure_Hour + ":" + "0" + Departure_Minute;
                    }
                    else
                        {
                         Departures = Departure_Hour + ":" + Departure_Minute;
                        }


                //Listview Items erstellen und hinzufügen + Counter erhöhen
                ListViewItem connline = new ListViewItem(lconn.ToString());
                connline.SubItems.Add(Departure.ToShortDateString());
                connline.SubItems.Add(m_From);
                connline.SubItems.Add(Departures + " Uhr");
                connline.SubItems.Add(conn.From.Platform);
                connline.SubItems.Add(m_To);
                connline.SubItems.Add(Arrivals + " Uhr");
                connline.SubItems.Add(conn.To.Platform);
                connline.SubItems.Add(Duration + " HH:MM");

                listConnection.Items.Add(connline);

                lconn++;
            }


        }


    }
}
