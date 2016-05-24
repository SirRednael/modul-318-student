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


        }

        private void txtOrt_TextChanged(object sender, EventArgs e)
        {


        }

        private void selectionFrom_TextChanged(object sender, EventArgs e)
        {
            
            selectionFrom.Items.Clear();

           selectionFrom.Select(selectionFrom.Text.Length, selectionFrom.Text.Length);

            Stations From = new Stations();
            Transport transport = new Transport();

            From = transport.GetStations(selectionFrom.Text);

            foreach (Station Hold in From.StationList)
                selectionFrom.Items.Add(Hold.Name);
        }

        private void selectionFrom_MouseClick(object sender, MouseEventArgs e)
        {
            selectionFrom.DroppedDown = true;
        }

        private void selectionTo_MouseClick(object sender, MouseEventArgs e)
        {
            selectionTo.DroppedDown = true;
        }

        private void selectionTo_TextChanged(object sender, EventArgs e)
        {
            selectionTo.Items.Clear();

            selectionTo.Select(selectionTo.Text.Length, selectionTo.Text.Length);

            Stations To = new Stations();
            Transport transport = new Transport();

            To = transport.GetStations(selectionFrom.Text);

            foreach (Station Hold in To.StationList)
                selectionTo.Items.Add(Hold.Name);
        }
    }
}
