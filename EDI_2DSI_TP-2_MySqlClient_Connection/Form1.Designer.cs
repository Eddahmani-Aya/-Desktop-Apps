namespace ED_2DAI_TP_2
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
            this.btn_Connexion = new System.Windows.Forms.Button();
            this.btn_DeConnexion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Etat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "BDD MySql";
            // 
            // btn_Connexion
            // 
            this.btn_Connexion.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connexion.Location = new System.Drawing.Point(135, 202);
            this.btn_Connexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Connexion.Name = "btn_Connexion";
            this.btn_Connexion.Size = new System.Drawing.Size(172, 55);
            this.btn_Connexion.TabIndex = 1;
            this.btn_Connexion.Text = "Connexion";
            this.btn_Connexion.UseVisualStyleBackColor = true;
            this.btn_Connexion.Click += new System.EventHandler(this.btn_Connexion_Click);
            // 
            // btn_DeConnexion
            // 
            this.btn_DeConnexion.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeConnexion.Location = new System.Drawing.Point(394, 202);
            this.btn_DeConnexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DeConnexion.Name = "btn_DeConnexion";
            this.btn_DeConnexion.Size = new System.Drawing.Size(172, 55);
            this.btn_DeConnexion.TabIndex = 2;
            this.btn_DeConnexion.Text = "Deconnexion";
            this.btn_DeConnexion.UseVisualStyleBackColor = true;
            this.btn_DeConnexion.Click += new System.EventHandler(this.btn_DeConnexion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Etat";
            // 
            // lbl_Etat
            // 
            this.lbl_Etat.AutoSize = true;
            this.lbl_Etat.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Etat.Location = new System.Drawing.Point(387, 323);
            this.lbl_Etat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Etat.Name = "lbl_Etat";
            this.lbl_Etat.Size = new System.Drawing.Size(202, 40);
            this.lbl_Etat.TabIndex = 4;
            this.lbl_Etat.Text = "Diconnected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 474);
            this.Controls.Add(this.lbl_Etat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_DeConnexion);
            this.Controls.Add(this.btn_Connexion);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Connexion;
        private System.Windows.Forms.Button btn_DeConnexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Etat;
    }
}

