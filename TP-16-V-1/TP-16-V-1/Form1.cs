using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_16_V_1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
        private void Btn_vert_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
        private void Btn_rose_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }
        private void Btn_rouge_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
        private void Btn_jaune_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
        private void Btn_blanc_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void Btn_bleu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
        }

        private void Btn_marron_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Maroon;
        }
    }
}
