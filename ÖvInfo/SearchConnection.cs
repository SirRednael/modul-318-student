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
            if (selectionFrom.Text != "" && selectionTo.Text != "")
            {
                if (selectionTo.Text != selectionFrom.Text)
                {
                    error.Text = "";
                    string From = selectionFrom.Text;
                    string To = selectionTo.Text;
                    

                    Transport trans = new Transport();
                    Connections connection = new Connections();


                    //Daten mithilfe von Transport.cs erhalten
                    connection = trans.GetConnections(From, To, timeOfJourney.Value, DateOfJourney.Value);

                    Verbindungen Verbindung = new Verbindungen(From, To, connection);
                    if (connection.ConnectionList.Count() > 0)
                    {
                        Verbindung.Show();
                    }
                    else
                    {
                        error.Text = "This Search gives No Result, Try again!";
                    }
                }
                else
                {
                    error.Text = "From and To Point can't be the same!";
                }
            }
            else
            {
                error.Text = "Both Fields must be filled!";
            }
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

                try
                {
                    To = transporter.GetStations(selectionTo.Text);
                }
                catch
                {
                    error.Text = "The Server Timed out: Please Try again!";
                }
                
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
                try
                {
                    From = transport.GetStations(selectionFrom.Text);
                }
                catch
                 {
                     error.Text = "The Server Timed out: Please Try again!";
                 }
            //Für jede Station in der Liste wird ein Eintrag in der Kombobox erstellt
            foreach (Station Hold in From.StationList)
                    selectionFrom.Items.Add(Hold.Name);
            }

        }


        //Öffnet das Stationboard + validiert die Eingabe (ist etwas vorhanden) + holt Daten für das Station Board
        private void btnStationBoardFrom_Click(object sender, EventArgs e)
        {
            if (selectionFrom.Text != "")
            {
                error.Text = "";


                StationBoardRoot StationRoot = new StationBoardRoot();
                Transport transporter = new Transport();
                try
                {
                    //Daten mithilfe von Transport.cs erhalten
                    StationRoot = transporter.GetStationBoard(selectionFrom.Text, transporter.GetStationBoard(selectionFrom.Text));
                }
                catch
                {
                    error.Text = "This Search gives No Result, Try again!";
                }
                if (StationRoot.Entries != null &&StationRoot.Entries.Count() > 0)
                {
                    
                        Stationboard Stationboards = new Stationboard(selectionFrom.Text, StationRoot);
                        Stationboards.Show();
                   
                    
                }
                else
                {
                    error.Text = "This Search gives No Result, Try again!";
                }
            }
            else
            {
                error.Text = "The From field must be filled!";
            }
        }


        //Öffnet das Stationboard + validiert die Eingabe (ist etwas vorhanden) + Holt Daten für das Station Board
        private void btnStationBoardTo_Click(object sender, EventArgs e)
        {
            if (selectionTo.Text != "")
            {
                error.Text = "";

                StationBoardRoot StationRoot = new StationBoardRoot();
                Transport transporter = new Transport();
                try
                {
                    //Daten mithilfe von Transport.cs erhalten
                    StationRoot = transporter.GetStationBoard(selectionTo.Text, transporter.GetStationBoard(selectionTo.Text));
                }
                catch
                {
                    error.Text = "This Search gives No Result, Try again!";
                }
                if (StationRoot.Entries != null && StationRoot.Entries.Count() > 0)
                {
                    Stationboard Stationboards = new Stationboard(selectionTo.Text, StationRoot);

                    Stationboards.Show();
                }
                else
                {
                    error.Text = "This Search gives No Result, Try again!";
                }
            }
            else
            {
                error.Text = "The To field must be filled!";
            }
        }


        //Der Kombobox DropDown wird geöffnet wenn eine taste gedrückt wird
        private void selectionFrom_KeyDown(object sender, KeyEventArgs e)
        {
            selectionFrom.DroppedDown = true;
        }


        //Der Kombobox DropDown wird geöffnet wenn eine taste gedrückt wird
        private void selectionTo_KeyDown(object sender, KeyEventArgs e)
        {
            selectionTo.DroppedDown = true;
        }
    }
}
