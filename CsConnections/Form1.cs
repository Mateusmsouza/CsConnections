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

        private void btn_copy_Click(object sender, EventArgs e)
        {
            try{
                if (lstTime.SelectedItem.ToString().Contains("Acessada:"))
                {
                    Clipboard.SetText(lblTime.Text);
                }
            }catch(Exception except)
            {
                MessageBox.Show("SELECIONE UMA LINHA \n\n\nExceção gerada:\n"+except.ToString());
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstTime_SelectedValueChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (lstTime.SelectedItem.ToString().Contains("Acessada:"))
                {
                    if (cbk_acumula.Checked)
                    {
                        string[] index = new string[lstTime.SelectedItems.Count];
                        lstTime.SelectedItems.CopyTo(index, 0);
                                             
                        lblTime.Text = FormatLineAll.entry(index);
                    }
                    else
                    {
                       lblTime.Text = lstTime.SelectedItem.ToString().Split(' ')[3];
                    }

                }
                else
                {
                    lblTime.Text = "WHAT?";
                }
            }
            catch (Exception except)
            {
                //MessageBox.Show("Exceção gerada:\n" + except.ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (lstTime.SelectionMode.ToString() == "One")
            {
                lstTime.SelectionMode = SelectionMode.MultiSimple;
            }
            else
            {
                lstTime.SelectionMode = SelectionMode.One;
                lblTime.Text = lstTime.SelectedItem.ToString().Split(' ')[3];
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void limparConnectionstxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Time.LoadFile.FileLoaded.Initial(true);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
        private void exibirEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Path Credits = new Path();
            Credits.ShowDialog();
        }
    }
}
