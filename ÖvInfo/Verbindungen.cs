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
        private string m_From;
        private string m_To;
        public Verbindungen()
        {
            InitializeComponent();
        }

        public Verbindungen(string From, string to)
        {
            m_From = From;
            m_To = to;
            InitializeComponent();
        }

        private void Verbindungen_Load(object sender, EventArgs e)
        {
            listConnection.Columns.Add("", 30, HorizontalAlignment.Left);
            listConnection.Columns.Add("Point of Departure:", 160, HorizontalAlignment.Left);
            listConnection.Columns.Add("Departure:", 120, HorizontalAlignment.Left);
            listConnection.Columns.Add("Destination:", 160, HorizontalAlignment.Left);
            listConnection.Columns.Add("Arrival:", 120, HorizontalAlignment.Left);
            listConnection.Columns.Add("Duration", 120, HorizontalAlignment.Left);



            Transport trans = new Transport();
             Connections connection = new Connections();

            connection = trans.GetConnections(m_From, m_To);
            int lconn = 1; 
            foreach (Connection conn in connection.ConnectionList )
            {
                string Arrival = conn.To.Arrival;
                string Departure = conn.From.Departure;

                Departure = Departure.Remove(0, 11);
                Arrival = Arrival.Remove(0, 11);
                Arrival = Arrival.Remove(6, 8);
                Departure = Departure.Remove(6, 8);

                ListViewItem connline = new ListViewItem(lconn.ToString());
                connline.SubItems.Add(m_From);
                connline.SubItems.Add(Departure);
                connline.SubItems.Add(m_To);
                connline.SubItems.Add(Arrival);
                connline.SubItems.Add(conn.Duration);

                listConnection.Items.Add(connline);

                lconn++;
            }


        }
    }
}
