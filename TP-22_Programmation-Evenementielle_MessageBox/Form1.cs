using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correction_TP22_EDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MessageBoxIcon PersonnaliserIcone (String icone)
        {
            if (icone == "Information")
            {
                return MessageBoxIcon.Information;
            }
            else if (icone == "Warning")
            {
                return MessageBoxIcon.Warning;
            }
            else if (icone == "Error")
            {
                return MessageBoxIcon.Error;
            }
            else if (icone == "Question")
            {
                return MessageBoxIcon.Question;
            }
            else
            {
                return MessageBoxIcon.None;
            }
        }
        public MessageBoxButtons PersonnaliserBoutons(string bouton)
        {
            if (bouton == "OK")
            {
                return MessageBoxButtons.OK;
            }
            else if (bouton == "OKCancel")
            {
                return MessageBoxButtons.OKCancel;
            }
            else if (bouton == "YesNo")
            {
                return MessageBoxButtons.YesNo;
            }
            else if (bouton == "YesNoCancel")
            {
                return MessageBoxButtons.YesNoCancel;
            }
            else if (bouton == "RetryCancel")
            {
                return MessageBoxButtons.RetryCancel;
            }
            else if (bouton == "AbortRetryIgnore")
            {
                return MessageBoxButtons.AbortRetryIgnore;
            }
            else
            {
                return MessageBoxButtons.OK;
            }
        }
        public MessageBoxIcon PersonnaliserIcone(string icone)
        {
            if (icone == "Information") return MessageBoxIcon.Information;
            if (icone == "Warning") return MessageBoxIcon.Warning;
            if (icone == "Error") return MessageBoxIcon.Error;
            if (icone == "Question") return MessageBoxIcon.Question;
            return MessageBoxIcon.None;
        }

    }
}
