using System;

namespace Correction_TP20_EDI
{
    partial class coordonnes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coordonnes));
            this.txtBx_Societe = new System.Windows.Forms.TextBox();
            this.txtBx_Titre = new System.Windows.Forms.TextBox();
            this.txtBx_Description = new System.Windows.Forms.TextBox();
            this.txtBx_Telephone = new System.Windows.Forms.TextBox();
            this.txtbx_Adresse = new System.Windows.Forms.TextBox();
            this.txtBx_Website = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBx_Societe
            // 
            this.txtBx_Societe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_Societe.Location = new System.Drawing.Point(114, 272);
            this.txtBx_Societe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_Societe.Name = "txtBx_Societe";
            this.txtBx_Societe.Size = new System.Drawing.Size(114, 19);
            this.txtBx_Societe.TabIndex = 0;
            this.txtBx_Societe.TextChanged += new System.EventHandler(this.txtBx_Societe_TextChanged);
            // 
            // txtBx_Titre
            // 
            this.txtBx_Titre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_Titre.Location = new System.Drawing.Point(284, 272);
            this.txtBx_Titre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_Titre.Name = "txtBx_Titre";
            this.txtBx_Titre.Size = new System.Drawing.Size(114, 19);
            this.txtBx_Titre.TabIndex = 1;
            this.txtBx_Titre.TextChanged += new System.EventHandler(this.txtBx_Titre_TextChanged);
            // 
            // txtBx_Description
            // 
            this.txtBx_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_Description.Location = new System.Drawing.Point(462, 272);
            this.txtBx_Description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_Description.Name = "txtBx_Description";
            this.txtBx_Description.Size = new System.Drawing.Size(114, 19);
            this.txtBx_Description.TabIndex = 2;
            // 
            // txtBx_Telephone
            // 
            this.txtBx_Telephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_Telephone.Location = new System.Drawing.Point(114, 454);
            this.txtBx_Telephone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_Telephone.Name = "txtBx_Telephone";
            this.txtBx_Telephone.Size = new System.Drawing.Size(114, 19);
            this.txtBx_Telephone.TabIndex = 3;
            // 
            // txtbx_Adresse
            // 
            this.txtbx_Adresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_Adresse.Location = new System.Drawing.Point(284, 454);
            this.txtbx_Adresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_Adresse.Name = "txtbx_Adresse";
            this.txtbx_Adresse.Size = new System.Drawing.Size(114, 19);
            this.txtbx_Adresse.TabIndex = 4;
            // 
            // txtBx_Website
            // 
            this.txtBx_Website.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_Website.Location = new System.Drawing.Point(462, 454);
            this.txtBx_Website.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_Website.Name = "txtBx_Website";
            this.txtBx_Website.Size = new System.Drawing.Size(114, 19);
            this.txtBx_Website.TabIndex = 5;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Location = new System.Drawing.Point(639, 274);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(146, 152);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.UseVisualStyleBackColor = false;
            // 
            // coordonnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 582);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtBx_Website);
            this.Controls.Add(this.txtbx_Adresse);
            this.Controls.Add(this.txtBx_Telephone);
            this.Controls.Add(this.txtBx_Description);
            this.Controls.Add(this.txtBx_Titre);
            this.Controls.Add(this.txtBx_Societe);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "coordonnes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.coordonnes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_Societe;
        private System.Windows.Forms.TextBox txtBx_Titre;
        private System.Windows.Forms.TextBox txtBx_Description;
        private System.Windows.Forms.TextBox txtBx_Telephone;
        private System.Windows.Forms.TextBox txtbx_Adresse;
        private System.Windows.Forms.TextBox txtBx_Website;
        private System.Windows.Forms.Button btn_Login;
        
    }
}

