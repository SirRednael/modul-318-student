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
    public partial class ConnectionSearch : Form
    {
        public ConnectionSearch()
        {
            InitializeComponent();
        }


        //Konstruktor mit String Übergabe (Abfahrtsort, Zielort)
        public ConnectionSearch(string From, string To)
        {
            InitializeComponent();
            selectionFrom.Text = From;
            selectionTo.Text = To;
        }


        //Der Verbindung suchen Button wird geklickt, Die Komboboxen werden nach ihrem Wert abgefragt,
        //das Fenster Verbindung wird geöffnet die Parameter werden mitgegeben(Abfahrtsort, Zielort) 
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string From = selectionFrom.Text;
            string To = selectionTo.Text;

            Verbindungen Verbindung = new Verbindungen(From, To);
            Verbindung.Show();
            
        }


        //Der Kombobox DropDown wird geöffnet wenn in die Kobobox geklickt wird
        private void selectionFrom_MouseClick(object sender, MouseEventArgs e)
        {
            selectionFrom.DroppedDown = true;
        }


        //Der Kombobox DropDown wird geöffnet wenn in die Kobobox geklickt wird
        private void selectionTo_MouseClick(object sender, MouseEventArgs e)
        {
            selectionTo.DroppedDown = true;
        }

 
        //Der Kombobox DropDown schliesst sich, wenn ein Objekt im Dropdown angewählt wird
        private void selectionFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionFrom.DroppedDown = false;     
        }


        //Der Kombobox DropDown schliesst sich, wenn ein Objekt im Dropdown angewählt wird
        private void selectionTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionTo.DroppedDown = false;                 
        }


        //Autocomplete und Stationsauswahl
        private void selectionTo_TextUpdate(object sender, EventArgs e)
        {
            //die Stationssuche startet erst ab 4 Zeichen, da sonst für jeden Buchstaben eine Query an den Sever geschickt wird
            if (selectionTo.Text.Length > 4)
            {
                
                selectionTo.Items.Clear();

                //setzt den Cursor an die letzte Stelle, weil nach einem Clear der Cursor an forderster Stelle steht
                selectionTo.Select(selectionTo.Text.Length, selectionTo.Text.Length);

                //Stationen werden Abgerufen, mit dem Parameter der Kombobox
                Stations To = new Stations();
                Transport transporter = new Transport();

                To = transporter.GetStations(selectionTo.Text);

                //Für jede Station in der Liste wird ein Eintrag in der Kombobox erstellt
                foreach (Station Hold in To.StationList)
                    selectionTo.Items.Add(Hold.Name);
            }

        }


        //Autocomplete und Stationsauswahl
        private void selectionFrom_TextUpdate(object sender, EventArgs e)
        {
            //die Stationssuche startet erst ab 4 Zeichen, da sonst für jeden Buchstaben eine Query an den Sever geschickt wird
            if (selectionFrom.Text.Length > 4)
            {
                
                selectionFrom.Items.Clear();

                //setzt den Cursor an die letzte Stelle, weil nach einem Clear der Cursor an forderster Stelle steht
                selectionFrom.Select(selectionFrom.Text.Length, selectionFrom.Text.Length);

                //Stationen werden Abgerufen, mit dem Parameter der Kombobox
                Stations From = new Stations();
                Transport transport = new Transport();

                From = transport.GetStations(selectionFrom.Text);

                //Für jede Station in der Liste wird ein Eintrag in der Kombobox erstellt
                foreach (Station Hold in From.StationList)
                    selectionFrom.Items.Add(Hold.Name);
            }

        }


        private void btnStationBoardFrom_Click(object sender, EventArgs e)
        {
            Stationboard Stationboards = new Stationboard(selectionFrom.Text);

            Stationboards.Show();
             
        }

        private void btnStationBoardTo_Click(object sender, EventArgs e)
        {
            Stationboard Stationboards = new Stationboard(selectionTo.Text);

            Stationboards.Show();
        }
    }
}
