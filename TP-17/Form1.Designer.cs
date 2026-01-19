namespace Correction_TP_17_EDI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_Nbr1 = new System.Windows.Forms.TextBox();
            this.TxtBx_Nbr2 = new System.Windows.Forms.TextBox();
            this.cmbBx_Operation = new System.Windows.Forms.ComboBox();
            this.btn_Calculer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Resultat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(280, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "TP 17";
            // 
            // txtBx_Nbr1
            // 
            this.txtBx_Nbr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_Nbr1.Location = new System.Drawing.Point(132, 186);
            this.txtBx_Nbr1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_Nbr1.Name = "txtBx_Nbr1";
            this.txtBx_Nbr1.Size = new System.Drawing.Size(149, 26);
            this.txtBx_Nbr1.TabIndex = 1;
            this.txtBx_Nbr1.TextChanged += new System.EventHandler(this.txtBx_Nbr1_TextChanged);
            // 
            // TxtBx_Nbr2
            // 
            this.TxtBx_Nbr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBx_Nbr2.Location = new System.Drawing.Point(388, 186);
            this.TxtBx_Nbr2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBx_Nbr2.Name = "TxtBx_Nbr2";
            this.TxtBx_Nbr2.Size = new System.Drawing.Size(149, 26);
            this.TxtBx_Nbr2.TabIndex = 2;
            this.TxtBx_Nbr2.TextChanged += new System.EventHandler(this.TxtBx_Nbr2_TextChanged);
            // 
            // cmbBx_Operation
            // 
            this.cmbBx_Operation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBx_Operation.FormattingEnabled = true;
            this.cmbBx_Operation.Items.AddRange(new object[] {
            "Addition",
            "Soustraction",
            "Multiplication",
            "Division"});
            this.cmbBx_Operation.Location = new System.Drawing.Point(243, 322);
            this.cmbBx_Operation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBx_Operation.Name = "cmbBx_Operation";
            this.cmbBx_Operation.Size = new System.Drawing.Size(180, 28);
            this.cmbBx_Operation.TabIndex = 3;
            this.cmbBx_Operation.SelectedIndexChanged += new System.EventHandler(this.cmbBx_Operation_SelectedIndexChanged);
            // 
            // btn_Calculer
            // 
            this.btn_Calculer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calculer.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculer.Location = new System.Drawing.Point(243, 394);
            this.btn_Calculer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Calculer.Name = "btn_Calculer";
            this.btn_Calculer.Size = new System.Drawing.Size(182, 55);
            this.btn_Calculer.TabIndex = 4;
            this.btn_Calculer.Text = "Calculer";
            this.btn_Calculer.UseVisualStyleBackColor = true;
            this.btn_Calculer.Click += new System.EventHandler(this.btn_Calculer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(127, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(383, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre  2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(237, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Operation";
            // 
            // lbl_Resultat
            // 
            this.lbl_Resultat.AutoSize = true;
            this.lbl_Resultat.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Resultat.Location = new System.Drawing.Point(352, 515);
            this.lbl_Resultat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Resultat.Name = "lbl_Resultat";
            this.lbl_Resultat.Size = new System.Drawing.Size(104, 44);
            this.lbl_Resultat.TabIndex = 8;
            this.lbl_Resultat.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(196, 520);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Resultat :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 612);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Resultat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Calculer);
            this.Controls.Add(this.cmbBx_Operation);
            this.Controls.Add(this.TxtBx_Nbr2);
            this.Controls.Add(this.txtBx_Nbr1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_Nbr1;
        private System.Windows.Forms.TextBox TxtBx_Nbr2;
        private System.Windows.Forms.ComboBox cmbBx_Operation;
        private System.Windows.Forms.Button btn_Calculer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Resultat;
        private System.Windows.Forms.Label label6;
    }
}

