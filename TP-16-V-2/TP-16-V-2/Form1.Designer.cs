namespace TP_16_V_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_Color = new System.Windows.Forms.Panel();
            this.CmbBx_Color = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "color";
            // 
            // Pnl_Color
            // 
            this.Pnl_Color.Location = new System.Drawing.Point(361, 181);
            this.Pnl_Color.Name = "Pnl_Color";
            this.Pnl_Color.Size = new System.Drawing.Size(200, 100);
            this.Pnl_Color.TabIndex = 2;
            this.Pnl_Color.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CmbBx_Color
            // 
            this.CmbBx_Color.FormattingEnabled = true;
            this.CmbBx_Color.Items.AddRange(new object[] {
            "Bleu",
            "Jaune",
            "Rouge",
            "Vert",
            "Noir",
            "Blanc",
            "Rose",
            "Marron"});
            this.CmbBx_Color.Location = new System.Drawing.Point(64, 181);
            this.CmbBx_Color.Name = "CmbBx_Color";
            this.CmbBx_Color.Size = new System.Drawing.Size(121, 28);
            this.CmbBx_Color.TabIndex = 0;
            this.CmbBx_Color.SelectedIndexChanged += new System.EventHandler(this.CmbBx_Color_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 418);
            this.Controls.Add(this.CmbBx_Color);
            this.Controls.Add(this.Pnl_Color);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Pnl_Color;
        private System.Windows.Forms.ComboBox CmbBx_Color;
    }
}

