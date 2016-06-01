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
        //Member Variabel für die Destination 
        private string m_Destination;
        private StationBoardRoot m_StationRoot;


        //Konstruktor ohne Parameter
        public Stationboard()
        {
            InitializeComponent();
        }


        //Konstruktor mit Parameter (To)
        public Stationboard(string Destination, StationBoardRoot StationRoot)
        {
            m_Destination = Destination;
            InitializeComponent();
            m_StationRoot = StationRoot;
        }


        //Erhalten der Daten für das StationBoard + Anzeige der Daten
        private void Stationboard_Load(object sender, EventArgs e)
        {

            //List View Column benennen und Spaltenbreite definieren
            liststationboard.Columns.Add("", 30, HorizontalAlignment.Left);
            liststationboard.Columns.Add("Date/Time:", 160, HorizontalAlignment.Left);
            liststationboard.Columns.Add("Train:", 120, HorizontalAlignment.Left);
            liststationboard.Columns.Add("To:", 160, HorizontalAlignment.Left);


            //Counter für Nummerierung der ListView Items 
            int scount = 1;

            //Listview Items erstellen und hinzufügen + Counter erhöhen
            foreach (StationBoard station in m_StationRoot.Entries)
            {
                
                ListViewItem connline = new ListViewItem(scount.ToString());
                connline.SubItems.Add(station.Stop.Departure + " Uhr");
                connline.SubItems.Add(station.Name);
                connline.SubItems.Add(station.To);

                liststationboard.Items.Add(connline);

                scount++;
            }
        
           

        }
    }
}
