using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CsConnections
{
    public partial class Path : Form
    {
        public Path()
        {
            InitializeComponent();
            
        }

        private void btnEditPath_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Mateusmsouza/CsConnections");
        }
    }
}
