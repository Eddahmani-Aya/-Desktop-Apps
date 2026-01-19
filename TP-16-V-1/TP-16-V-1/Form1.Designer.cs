namespace TP_16_V_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_noir = new System.Windows.Forms.Button();
            this.Btn_blanc = new System.Windows.Forms.Button();
            this.Btn_rouge = new System.Windows.Forms.Button();
            this.Btn_bleu = new System.Windows.Forms.Button();
            this.Btn_rose = new System.Windows.Forms.Button();
            this.Btn_jaune = new System.Windows.Forms.Button();
            this.Btn_marron = new System.Windows.Forms.Button();
            this.Btn_vert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_noir
            // 
            this.Btn_noir.Location = new System.Drawing.Point(97, 70);
            this.Btn_noir.Name = "Btn_noir";
            this.Btn_noir.Size = new System.Drawing.Size(102, 35);
            this.Btn_noir.TabIndex = 0;
            this.Btn_noir.Text = "Noir";
            this.Btn_noir.UseVisualStyleBackColor = true;
            this.Btn_noir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_blanc
            // 
            this.Btn_blanc.Location = new System.Drawing.Point(97, 296);
            this.Btn_blanc.Name = "Btn_blanc";
            this.Btn_blanc.Size = new System.Drawing.Size(102, 35);
            this.Btn_blanc.TabIndex = 1;
            this.Btn_blanc.Text = "Blanc";
            this.Btn_blanc.UseVisualStyleBackColor = true;
            this.Btn_blanc.Click += new System.EventHandler(this.Btn_blanc_Click);
            // 
            // Btn_rouge
            // 
            this.Btn_rouge.Location = new System.Drawing.Point(97, 221);
            this.Btn_rouge.Name = "Btn_rouge";
            this.Btn_rouge.Size = new System.Drawing.Size(102, 35);
            this.Btn_rouge.TabIndex = 2;
            this.Btn_rouge.Text = "Rouge";
            this.Btn_rouge.UseVisualStyleBackColor = true;
            this.Btn_rouge.Click += new System.EventHandler(this.Btn_rouge_Click);
            // 
            // Btn_bleu
            // 
            this.Btn_bleu.Location = new System.Drawing.Point(97, 144);
            this.Btn_bleu.Name = "Btn_bleu";
            this.Btn_bleu.Size = new System.Drawing.Size(102, 35);
            this.Btn_bleu.TabIndex = 3;
            this.Btn_bleu.Text = "Bleu";
            this.Btn_bleu.UseVisualStyleBackColor = true;
            this.Btn_bleu.Click += new System.EventHandler(this.Btn_bleu_Click);
            // 
            // Btn_rose
            // 
            this.Btn_rose.Location = new System.Drawing.Point(337, 144);
            this.Btn_rose.Name = "Btn_rose";
            this.Btn_rose.Size = new System.Drawing.Size(102, 35);
            this.Btn_rose.TabIndex = 7;
            this.Btn_rose.Text = "Rose";
            this.Btn_rose.UseVisualStyleBackColor = true;
            this.Btn_rose.Click += new System.EventHandler(this.Btn_rose_Click);
            // 
            // Btn_jaune
            // 
            this.Btn_jaune.Location = new System.Drawing.Point(337, 221);
            this.Btn_jaune.Name = "Btn_jaune";
            this.Btn_jaune.Size = new System.Drawing.Size(102, 35);
            this.Btn_jaune.TabIndex = 6;
            this.Btn_jaune.Text = "Jaune ";
            this.Btn_jaune.UseVisualStyleBackColor = true;
            this.Btn_jaune.Click += new System.EventHandler(this.Btn_jaune_Click);
            // 
            // Btn_marron
            // 
            this.Btn_marron.Location = new System.Drawing.Point(337, 296);
            this.Btn_marron.Name = "Btn_marron";
            this.Btn_marron.Size = new System.Drawing.Size(102, 35);
            this.Btn_marron.TabIndex = 5;
            this.Btn_marron.Text = "Marron";
            this.Btn_marron.UseVisualStyleBackColor = true;
            this.Btn_marron.Click += new System.EventHandler(this.Btn_marron_Click);
            // 
            // Btn_vert
            // 
            this.Btn_vert.Location = new System.Drawing.Point(337, 70);
            this.Btn_vert.Name = "Btn_vert";
            this.Btn_vert.Size = new System.Drawing.Size(102, 35);
            this.Btn_vert.TabIndex = 4;
            this.Btn_vert.Text = "Vert ";
            this.Btn_vert.UseVisualStyleBackColor = true;
            this.Btn_vert.Click += new System.EventHandler(this.Btn_vert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 441);
            this.Controls.Add(this.Btn_rose);
            this.Controls.Add(this.Btn_jaune);
            this.Controls.Add(this.Btn_marron);
            this.Controls.Add(this.Btn_vert);
            this.Controls.Add(this.Btn_bleu);
            this.Controls.Add(this.Btn_rouge);
            this.Controls.Add(this.Btn_blanc);
            this.Controls.Add(this.Btn_noir);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_noir;
        private System.Windows.Forms.Button Btn_blanc;
        private System.Windows.Forms.Button Btn_rouge;
        private System.Windows.Forms.Button Btn_bleu;
        private System.Windows.Forms.Button Btn_rose;
        private System.Windows.Forms.Button Btn_jaune;
        private System.Windows.Forms.Button Btn_marron;
        private System.Windows.Forms.Button Btn_vert;
    }
}

