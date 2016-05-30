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

        //Konstruktor ohne Parameter
        public Verbindungen()
        {
            InitializeComponent();
        }


        //Konstruktor mit Parameter (From,To)
        public Verbindungen(string From, string to)
        {
            m_From = From;
            m_To = to;
            InitializeComponent();
        }


        //Erhalten der Daten für die Verbindungen + Anzeige der Daten
        private void Verbindungen_Load(object sender, EventArgs e)
        {
            //List View Column benennen und Spaltenbreite definieren
            listConnection.Columns.Add("", 26, HorizontalAlignment.Left);
            listConnection.Columns.Add("Point of Departure:", 160, HorizontalAlignment.Left);
            listConnection.Columns.Add("Departure:", 120, HorizontalAlignment.Left);
            listConnection.Columns.Add("Platform:", 30, HorizontalAlignment.Left);
            listConnection.Columns.Add("Destination:", 160, HorizontalAlignment.Left);
            listConnection.Columns.Add("Arrival:", 120, HorizontalAlignment.Left);
            listConnection.Columns.Add("Platform:", 30, HorizontalAlignment.Left);  
            listConnection.Columns.Add("Duration", 100, HorizontalAlignment.Left);


            Transport trans = new Transport();
             Connections connection = new Connections();


            //Daten mithilfe von Transport.cs erhalten
            connection = trans.GetConnections(m_From, m_To);

            //Counter für Nummerierung der ListView Items 
            int lconn = 1;

            //Listview Items erstellen und hinzufügen + Counter erhöhen + Zeit Format Anpassen
            foreach (Connection conn in connection.ConnectionList )
            {

                
                //Zeit format der Ankunft, der Abfahrt un der Dauer ins richtige Format bringen
                DateTime Departure = DateTime.Parse(conn.From.Departure);
                DateTime Arrival = DateTime.Parse(conn.To.Arrival);
                String Duration = conn.Duration.Remove(0, 4);
                Duration = Duration.Remove(4, 3);

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
