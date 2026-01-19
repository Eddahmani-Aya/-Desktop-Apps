namespace passage_1dai
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtBx_ID = new System.Windows.Forms.TextBox();
            this.txtBx_Chanteur = new System.Windows.Forms.TextBox();
            this.txtBx_Nom = new System.Windows.Forms.TextBox();
            this.cmbBx_Type = new System.Windows.Forms.ComboBox();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.DGV_Chansons = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lkLbk_Retour = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Chansons)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Gestion des chansons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chanteur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // txtBx_ID
            // 
            this.txtBx_ID.Location = new System.Drawing.Point(156, 148);
            this.txtBx_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_ID.Name = "txtBx_ID";
            this.txtBx_ID.Size = new System.Drawing.Size(148, 26);
            this.txtBx_ID.TabIndex = 5;
            // 
            // txtBx_Chanteur
            // 
            this.txtBx_Chanteur.Location = new System.Drawing.Point(156, 218);
            this.txtBx_Chanteur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_Chanteur.Name = "txtBx_Chanteur";
            this.txtBx_Chanteur.Size = new System.Drawing.Size(148, 26);
            this.txtBx_Chanteur.TabIndex = 6;
            // 
            // txtBx_Nom
            // 
            this.txtBx_Nom.Location = new System.Drawing.Point(572, 143);
            this.txtBx_Nom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_Nom.Name = "txtBx_Nom";
            this.txtBx_Nom.Size = new System.Drawing.Size(180, 26);
            this.txtBx_Nom.TabIndex = 7;
            // 
            // cmbBx_Type
            // 
            this.cmbBx_Type.FormattingEnabled = true;
            this.cmbBx_Type.Items.AddRange(new object[] {
            "rap",
            "rai",
            "rock"});
            this.cmbBx_Type.Location = new System.Drawing.Point(572, 218);
            this.cmbBx_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBx_Type.Name = "cmbBx_Type";
            this.cmbBx_Type.Size = new System.Drawing.Size(180, 28);
            this.cmbBx_Type.TabIndex = 8;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(60, 318);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(112, 35);
            this.btn_Ajouter.TabIndex = 9;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(328, 318);
            this.btn_Modifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(112, 35);
            this.btn_Modifier.TabIndex = 10;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(640, 318);
            this.btn_Supprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(112, 35);
            this.btn_Supprimer.TabIndex = 11;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            // 
            // DGV_Chansons
            // 
            this.DGV_Chansons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Chansons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DGV_Chansons.Location = new System.Drawing.Point(60, 408);
            this.DGV_Chansons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_Chansons.Name = "DGV_Chansons";
            this.DGV_Chansons.RowHeadersWidth = 62;
            this.DGV_Chansons.Size = new System.Drawing.Size(693, 231);
            this.DGV_Chansons.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOM";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CHANTEUR";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TYPE";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // lkLbk_Retour
            // 
            this.lkLbk_Retour.AutoSize = true;
            this.lkLbk_Retour.Location = new System.Drawing.Point(380, 649);
            this.lkLbk_Retour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lkLbk_Retour.Name = "lkLbk_Retour";
            this.lkLbk_Retour.Size = new System.Drawing.Size(58, 20);
            this.lkLbk_Retour.TabIndex = 13;
            this.lkLbk_Retour.TabStop = true;
            this.lkLbk_Retour.Text = "Retour";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 682);
            this.Controls.Add(this.lkLbk_Retour);
            this.Controls.Add(this.DGV_Chansons);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.cmbBx_Type);
            this.Controls.Add(this.txtBx_Nom);
            this.Controls.Add(this.txtBx_Chanteur);
            this.Controls.Add(this.txtBx_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Chansons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBx_ID;
        private System.Windows.Forms.TextBox txtBx_Chanteur;
        private System.Windows.Forms.TextBox txtBx_Nom;
        private System.Windows.Forms.ComboBox cmbBx_Type;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.DataGridView DGV_Chansons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.LinkLabel lkLbk_Retour;
    }
}

