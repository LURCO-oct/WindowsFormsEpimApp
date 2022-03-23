using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnAcr_Click(object sender, EventArgs e)
        {
            /*panel4.Height = BtnAcr.Height;
            panel4.Top = BtnAcr.Top;*/
            acceuilCC1.BringToFront();
        }

        private void BtnAcc_Click(object sender, EventArgs e)
        {
            panel4.Height = BtnAcc.Height;
            panel4.Top = BtnAcc.Top;
            secteurCC1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
