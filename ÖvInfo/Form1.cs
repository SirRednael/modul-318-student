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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string From = selectionFrom.Text;
            string To = selectionTo.Text;

            Verbindungen Verbindung = new Verbindungen(From, To);
            Verbindung.Show();
            
            
            
        }

        private void txtOrt_TextChanged(object sender, EventArgs e)
        {


        }



        private void selectionFrom_MouseClick(object sender, MouseEventArgs e)
        {
            selectionFrom.DroppedDown = true;
        }

        private void selectionTo_MouseClick(object sender, MouseEventArgs e)
        {
            selectionTo.DroppedDown = true;
        }

 

        private void selectionFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionFrom.DroppedDown = false;
            
        }

        private void selectionTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionTo.DroppedDown = false;
           
            
        }

        private void selectionTo_TextUpdate(object sender, EventArgs e)
        {
            if (selectionTo.Text.Length > 4)
            {
                selectionTo.Items.Clear();

                selectionTo.Select(selectionTo.Text.Length, selectionTo.Text.Length);

                Stations To = new Stations();
                Transport transporter = new Transport();

                To = transporter.GetStations(selectionTo.Text);

                foreach (Station Hold in To.StationList)
                    selectionTo.Items.Add(Hold.Name);
            }

        }

        private void selectionFrom_TextUpdate(object sender, EventArgs e)
        {
            if (selectionFrom.Text.Length > 4)
            {

                selectionFrom.Items.Clear();

                selectionFrom.Select(selectionFrom.Text.Length, selectionFrom.Text.Length);

                Stations From = new Stations();
                Transport transport = new Transport();

                From = transport.GetStations(selectionFrom.Text);

                foreach (Station Hold in From.StationList)
                    selectionFrom.Items.Add(Hold.Name);
            }

        }
    }
}
