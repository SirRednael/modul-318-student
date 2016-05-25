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
            listConnection.Columns.Add("Platform:", 30, HorizontalAlignment.Left);
            listConnection.Columns.Add("Destination:", 160, HorizontalAlignment.Left);
            listConnection.Columns.Add("Arrival:", 120, HorizontalAlignment.Left);
            listConnection.Columns.Add("Platform:", 30, HorizontalAlignment.Left);  
            listConnection.Columns.Add("Duration", 120, HorizontalAlignment.Left);



            Transport trans = new Transport();
             Connections connection = new Connections();

            connection = trans.GetConnections(m_From, m_To);
            int lconn = 1; 
            foreach (Connection conn in connection.ConnectionList )
            {
                DateTime Arrival = DateTime.Parse(conn.From.Departure);
                DateTime Departure = DateTime.Parse(conn.To.Arrival);
                DateTime Duration = DateTime.Parse(conn.Duration);

            
                ListViewItem connline = new ListViewItem(lconn.ToString());
                connline.SubItems.Add(m_From);
                connline.SubItems.Add(Departure + " Uhr");
                connline.SubItems.Add(conn.From.Platform);
                connline.SubItems.Add(m_To);
                connline.SubItems.Add(Arrival + " Uhr");
                connline.SubItems.Add(conn.To.Platform);
                connline.SubItems.Add(Duration + " HH:MM");

                listConnection.Items.Add(connline);

                lconn++;
            }


        }


    }
}
