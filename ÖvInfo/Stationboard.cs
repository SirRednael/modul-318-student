using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace ÖvInfo
{
    public partial class Stationboard : Form
    {
        private string m_Destination;
        public Stationboard()
        {
            InitializeComponent();
        }
        public Stationboard(string Destination)
        {
            m_Destination = Destination;
            InitializeComponent();
        }

        private void Stationboard_Load(object sender, EventArgs e)
        {
            liststationboard.Columns.Add("", 30, HorizontalAlignment.Left);
            liststationboard.Columns.Add("Time:", 160, HorizontalAlignment.Left);
            liststationboard.Columns.Add("Train:", 120, HorizontalAlignment.Left);
            liststationboard.Columns.Add("To:", 160, HorizontalAlignment.Left);

            StationBoard Stations = new StationBoard();
            StationBoardRoot StationRoot = new StationBoardRoot();
            Transport transporter = new Transport();

            StationRoot = transporter.GetStationBoard(m_Destination, transporter.GetStationBoard(m_Destination));

            int scount = 1;

            foreach (StationBoard station in StationRoot.Entries)
            {
                
               
         
                ListViewItem connline = new ListViewItem(scount.ToString());
                connline.SubItems.Add(station.Stop.Departure + " Uhr");
                connline.SubItems.Add(station.Name);
                connline.SubItems.Add();
  

                liststationboard.Items.Add(connline);

                scount++;
            }
        
           

        }
    }
}
