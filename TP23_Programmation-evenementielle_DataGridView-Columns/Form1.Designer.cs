namespace Correction_TP23_EDI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.txtBx_TexteAjouter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_NomAjouter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.txtBx_NouveauTexte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_IndiceModifier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.txtBx_IndiceSupprimer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Operation_Click = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Ajouter);
            this.groupBox1.Controls.Add(this.txtBx_TexteAjouter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBx_NomAjouter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(592, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter Colonne";
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ajouter.Location = new System.Drawing.Point(438, 117);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(150, 48);
            this.btn_Ajouter.TabIndex = 4;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = false;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // txtBx_TexteAjouter
            // 
            this.txtBx_TexteAjouter.Location = new System.Drawing.Point(438, 45);
            this.txtBx_TexteAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_TexteAjouter.Name = "txtBx_TexteAjouter";
            this.txtBx_TexteAjouter.Size = new System.Drawing.Size(148, 35);
            this.txtBx_TexteAjouter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texte";
            // 
            // txtBx_NomAjouter
            // 
            this.txtBx_NomAjouter.Location = new System.Drawing.Point(96, 45);
            this.txtBx_NomAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_NomAjouter.Name = "txtBx_NomAjouter";
            this.txtBx_NomAjouter.Size = new System.Drawing.Size(148, 35);
            this.txtBx_NomAjouter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Modifier);
            this.groupBox2.Controls.Add(this.txtBx_NouveauTexte);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBx_IndiceModifier);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(44, 268);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(592, 198);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifier Colonne";
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modifier.Location = new System.Drawing.Point(438, 115);
            this.btn_Modifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(150, 48);
            this.btn_Modifier.TabIndex = 4;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = false;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // txtBx_NouveauTexte
            // 
            this.txtBx_NouveauTexte.Location = new System.Drawing.Point(438, 45);
            this.txtBx_NouveauTexte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_NouveauTexte.Name = "txtBx_NouveauTexte";
            this.txtBx_NouveauTexte.Size = new System.Drawing.Size(148, 35);
            this.txtBx_NouveauTexte.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nouveau Texte";
            // 
            // txtBx_IndiceModifier
            // 
            this.txtBx_IndiceModifier.Location = new System.Drawing.Point(96, 45);
            this.txtBx_IndiceModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_IndiceModifier.Name = "txtBx_IndiceModifier";
            this.txtBx_IndiceModifier.Size = new System.Drawing.Size(148, 35);
            this.txtBx_IndiceModifier.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Indice";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Supprimer);
            this.groupBox3.Controls.Add(this.txtBx_IndiceSupprimer);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(44, 491);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(592, 198);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supprimer Colonne";
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Supprimer.Location = new System.Drawing.Point(438, 114);
            this.btn_Supprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(150, 48);
            this.btn_Supprimer.TabIndex = 4;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = false;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // txtBx_IndiceSupprimer
            // 
            this.txtBx_IndiceSupprimer.Location = new System.Drawing.Point(96, 45);
            this.txtBx_IndiceSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_IndiceSupprimer.Name = "txtBx_IndiceSupprimer";
            this.txtBx_IndiceSupprimer.Size = new System.Drawing.Size(148, 35);
            this.txtBx_IndiceSupprimer.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Indice";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(656, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(3, 629);
            this.label7.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(44, 483);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(597, 3);
            this.label8.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(44, 252);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(597, 3);
            this.label9.TabIndex = 9;
            // 
            // DGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.GridColor = System.Drawing.Color.SteelBlue;
            this.DGV.Location = new System.Drawing.Point(692, 254);
            this.DGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.Size = new System.Drawing.Size(519, 231);
            this.DGV.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(766, 191);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(364, 40);
            this.label10.TabIndex = 5;
            this.label10.Text = "DataGridView Columns";
            // 
            // btn_Operation_Click
            // 
            this.btn_Operation_Click.BackColor = System.Drawing.Color.Aqua;
            this.btn_Operation_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Operation_Click.Location = new System.Drawing.Point(692, 635);
            this.btn_Operation_Click.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Operation_Click.Name = "btn_Operation_Click";
            this.btn_Operation_Click.Size = new System.Drawing.Size(150, 48);
            this.btn_Operation_Click.TabIndex = 11;
            this.btn_Operation_Click.Text = "Operation";
            this.btn_Operation_Click.UseVisualStyleBackColor = false;
            this.btn_Operation_Click.Click += new System.EventHandler(this.btn_Operation_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 715);
            this.Controls.Add(this.btn_Operation_Click);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.TextBox txtBx_TexteAjouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_NomAjouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.TextBox txtBx_NouveauTexte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBx_IndiceModifier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.TextBox txtBx_IndiceSupprimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Operation_Click;
    }
}

