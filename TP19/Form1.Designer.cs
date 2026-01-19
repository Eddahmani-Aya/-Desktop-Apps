namespace Correction_TP19_EDI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rdBtn_Woman = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rdBtn_Man = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_Adresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBx_Telephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_Prenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_Nom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rTxtBx_Skills = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rTxtBx_Diplomes = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBx_Poste = new System.Windows.Forms.TextBox();
            this.cmbBx_Langue = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Creer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNaissance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rdBtn_Woman);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdBtn_Man);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBx_Adresse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBx_Telephone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBx_Prenom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBx_Nom);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(560, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations Personnelles";
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNaissance.Location = new System.Drawing.Point(300, 357);
            this.dtpNaissance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(230, 35);
            this.dtpNaissance.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 305);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Année de Naissance";
            // 
            // rdBtn_Woman
            // 
            this.rdBtn_Woman.AutoSize = true;
            this.rdBtn_Woman.Location = new System.Drawing.Point(140, 357);
            this.rdBtn_Woman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtn_Woman.Name = "rdBtn_Woman";
            this.rdBtn_Woman.Size = new System.Drawing.Size(120, 33);
            this.rdBtn_Woman.TabIndex = 10;
            this.rdBtn_Woman.TabStop = true;
            this.rdBtn_Woman.Text = "Woman";
            this.rdBtn_Woman.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Genre";
            // 
            // rdBtn_Man
            // 
            this.rdBtn_Man.AutoSize = true;
            this.rdBtn_Man.Location = new System.Drawing.Point(30, 357);
            this.rdBtn_Man.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBtn_Man.Name = "rdBtn_Man";
            this.rdBtn_Man.Size = new System.Drawing.Size(84, 33);
            this.rdBtn_Man.TabIndex = 8;
            this.rdBtn_Man.TabStop = true;
            this.rdBtn_Man.Text = "Man";
            this.rdBtn_Man.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adresse";
            // 
            // txtBx_Adresse
            // 
            this.txtBx_Adresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_Adresse.Location = new System.Drawing.Point(300, 228);
            this.txtBx_Adresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_Adresse.Name = "txtBx_Adresse";
            this.txtBx_Adresse.Size = new System.Drawing.Size(232, 35);
            this.txtBx_Adresse.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telephone";
            // 
            // txtBx_Telephone
            // 
            this.txtBx_Telephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_Telephone.Location = new System.Drawing.Point(30, 228);
            this.txtBx_Telephone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_Telephone.Name = "txtBx_Telephone";
            this.txtBx_Telephone.Size = new System.Drawing.Size(232, 35);
            this.txtBx_Telephone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom";
            // 
            // txtBx_Prenom
            // 
            this.txtBx_Prenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_Prenom.Location = new System.Drawing.Point(300, 125);
            this.txtBx_Prenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_Prenom.Name = "txtBx_Prenom";
            this.txtBx_Prenom.Size = new System.Drawing.Size(232, 35);
            this.txtBx_Prenom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // txtBx_Nom
            // 
            this.txtBx_Nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_Nom.Location = new System.Drawing.Point(30, 125);
            this.txtBx_Nom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_Nom.Name = "txtBx_Nom";
            this.txtBx_Nom.Size = new System.Drawing.Size(232, 35);
            this.txtBx_Nom.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Location = new System.Drawing.Point(590, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(3, 418);
            this.label7.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.rTxtBx_Skills);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.rTxtBx_Diplomes);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBx_Poste);
            this.groupBox2.Controls.Add(this.cmbBx_Langue);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(609, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(560, 442);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations Personnelles";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "Skills";
            // 
            // rTxtBx_Skills
            // 
            this.rTxtBx_Skills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTxtBx_Skills.Location = new System.Drawing.Point(298, 231);
            this.rTxtBx_Skills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rTxtBx_Skills.Name = "rTxtBx_Skills";
            this.rTxtBx_Skills.Size = new System.Drawing.Size(230, 189);
            this.rTxtBx_Skills.TabIndex = 8;
            this.rTxtBx_Skills.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 189);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "Diplomes";
            // 
            // rTxtBx_Diplomes
            // 
            this.rTxtBx_Diplomes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTxtBx_Diplomes.Location = new System.Drawing.Point(30, 228);
            this.rTxtBx_Diplomes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rTxtBx_Diplomes.Name = "rTxtBx_Diplomes";
            this.rTxtBx_Diplomes.Size = new System.Drawing.Size(206, 189);
            this.rTxtBx_Diplomes.TabIndex = 6;
            this.rTxtBx_Diplomes.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Poste";
            // 
            // txtBx_Poste
            // 
            this.txtBx_Poste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_Poste.Location = new System.Drawing.Point(298, 129);
            this.txtBx_Poste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_Poste.Name = "txtBx_Poste";
            this.txtBx_Poste.Size = new System.Drawing.Size(232, 35);
            this.txtBx_Poste.TabIndex = 4;
            // 
            // cmbBx_Langue
            // 
            this.cmbBx_Langue.FormattingEnabled = true;
            this.cmbBx_Langue.Location = new System.Drawing.Point(30, 123);
            this.cmbBx_Langue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBx_Langue.Name = "cmbBx_Langue";
            this.cmbBx_Langue.Size = new System.Drawing.Size(206, 37);
            this.cmbBx_Langue.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 86);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 29);
            this.label13.TabIndex = 1;
            this.label13.Text = "Langue etrangere";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label11.Location = new System.Drawing.Point(458, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 44);
            this.label11.TabIndex = 15;
            this.label11.Text = "Créer votre CV";
            // 
            // btn_Creer
            // 
            this.btn_Creer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Creer.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Creer.Location = new System.Drawing.Point(465, 611);
            this.btn_Creer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Creer.Name = "btn_Creer";
            this.btn_Creer.Size = new System.Drawing.Size(267, 69);
            this.btn_Creer.TabIndex = 16;
            this.btn_Creer.Text = "Créer";
            this.btn_Creer.UseVisualStyleBackColor = true;
            this.btn_Creer.Click += new System.EventHandler(this.btn_Creer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 710);
            this.Controls.Add(this.btn_Creer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdBtn_Woman;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdBtn_Man;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBx_Adresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBx_Telephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_Prenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_Nom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rTxtBx_Skills;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rTxtBx_Diplomes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBx_Poste;
        private System.Windows.Forms.ComboBox cmbBx_Langue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Creer;
    }
}

