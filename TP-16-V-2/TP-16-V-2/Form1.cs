using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_16_V_2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            CmbBx_Color.Items.AddRange(new string[] {
            "Bleu", "Jaune", "Rouge", "Vert",
            "Noir", "Blanc", "Rose", "Marron"});
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CmbBx_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = CmbBx_Color.SelectedItem.ToString();
            switch (selectedColor.ToLower())
            {
                case "bleu":
                    Pnl_Color.BackColor = Color.DarkBlue;
                    break;
                case "Jaune":
                    Pnl_Color.BackColor = Color.Yellow;
                    break;
                case "rouge":
                    Pnl_Color.BackColor = Color.DarkRed;
                    break;
                case "vert":
                    Pnl_Color.BackColor = Color.DarkGreen;
                    break;
                case "noir":
                    Pnl_Color.BackColor = Color.Black;
                    break;
                case "blanc":
                    Pnl_Color.BackColor = Color.White;
                    break;
                case "rose":
                    Pnl_Color.BackColor = Color.Pink;
                    break;
                case "marron":
                    Pnl_Color.BackColor = Color.Brown;
                    break;
                default:
                    Pnl_Color.BackColor = Color.Transparent;
                    break;
            }
        }
    }
}
