using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FinalSemesterProjectOOP_APMS_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("login.txt");
            sr.ReadLine();
            string pass = sr.ReadLine();
            if (txtPass.Text.Equals(pass))
            {
                MainForm mf = new MainForm();
                mf.Show();
            }
            else
            {
                txtPass.Text = "Pls Try again...";
            }

        }

        private void Close()
        {
            Application.Exit();
        }
       
      
    }
}
