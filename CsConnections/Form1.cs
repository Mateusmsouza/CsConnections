using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Time.LoadFile;
using CsConnections;

namespace CsConnections
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            List<String> timeList = new List<string>();
            FileLoaded filetoload = new FileLoaded();
            FormatLine formatLine = new FormatLine();
            timeList = FileLoaded.Initial();
            
            if (timeList.Any())
            {
                foreach(var time in timeList)
                {
                    lstTime.Items.Add( FormatLine.FormatString(time.ToString()));
                }
            }
            else
            {
                Environment.Exit(1);
            }
            
        }
    }
}
