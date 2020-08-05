using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliSoft
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PanelVertical.Width == 70)
            {
                PanelVertical.Width = 260;
            }
            else
                PanelVertical.Width = 70;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            Savebtn.ForeColor = Color.Aqua;
            Savebtn.BackColor = Color.Gray ;
            
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            Searchbtn .ForeColor = Color.Aqua;
            Searchbtn.BackColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
