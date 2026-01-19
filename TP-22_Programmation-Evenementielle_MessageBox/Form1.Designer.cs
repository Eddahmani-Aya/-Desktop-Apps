namespace Correction_TP22_EDI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBx_Texte = new System.Windows.Forms.TextBox();
            this.cmbBx_StyleIcones = new System.Windows.Forms.ComboBox();
            this.cmbBx_StyleButtons = new System.Windows.Forms.ComboBox();
            this.txtBx_Titre = new System.Windows.Forms.TextBox();
            this.btn_Creer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(63, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(183, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Style(Icone)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(353, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Style(Buttons)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(546, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Titre";
            // 
            // txtBx_Texte
            // 
            this.txtBx_Texte.Location = new System.Drawing.Point(48, 153);
            this.txtBx_Texte.Name = "txtBx_Texte";
            this.txtBx_Texte.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Texte.TabIndex = 4;
            // 
            // cmbBx_StyleIcones
            // 
            this.cmbBx_StyleIcones.FormattingEnabled = true;
            this.cmbBx_StyleIcones.Items.AddRange(new object[] {
            "Information",
            "Warning",
            "Error",
            "Question"});
            this.cmbBx_StyleIcones.Location = new System.Drawing.Point(188, 152);
            this.cmbBx_StyleIcones.Name = "cmbBx_StyleIcones";
            this.cmbBx_StyleIcones.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_StyleIcones.TabIndex = 5;
            // 
            // cmbBx_StyleButtons
            // 
            this.cmbBx_StyleButtons.FormattingEnabled = true;
            this.cmbBx_StyleButtons.Items.AddRange(new object[] {
            "Ok",
            "OkCancel",
            "YesNo",
            "YesNoCancel",
            "AbortRetryIgnore",
            "RetryCancel"});
            this.cmbBx_StyleButtons.Location = new System.Drawing.Point(361, 153);
            this.cmbBx_StyleButtons.Name = "cmbBx_StyleButtons";
            this.cmbBx_StyleButtons.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_StyleButtons.TabIndex = 6;
            // 
            // txtBx_Titre
            // 
            this.txtBx_Titre.Location = new System.Drawing.Point(527, 154);
            this.txtBx_Titre.Name = "txtBx_Titre";
            this.txtBx_Titre.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Titre.TabIndex = 7;
            // 
            // btn_Creer
            // 
            this.btn_Creer.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Creer.Location = new System.Drawing.Point(257, 222);
            this.btn_Creer.Name = "btn_Creer";
            this.btn_Creer.Size = new System.Drawing.Size(146, 55);
            this.btn_Creer.TabIndex = 8;
            this.btn_Creer.Text = "Create";
            this.btn_Creer.UseVisualStyleBackColor = true;
           // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(225, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Create MessageBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 314);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Creer);
            this.Controls.Add(this.txtBx_Titre);
            this.Controls.Add(this.cmbBx_StyleButtons);
            this.Controls.Add(this.cmbBx_StyleIcones);
            this.Controls.Add(this.txtBx_Texte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBx_Texte;
        private System.Windows.Forms.ComboBox cmbBx_StyleIcones;
        private System.Windows.Forms.ComboBox cmbBx_StyleButtons;
        private System.Windows.Forms.TextBox txtBx_Titre;
        private System.Windows.Forms.Button btn_Creer;
        private System.Windows.Forms.Label label5;
    }
}

