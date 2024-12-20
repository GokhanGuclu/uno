namespace WindowsFormsApp1
{
    partial class UnoOyun
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
            this.components = new System.ComponentModel.Container();
            this.eskiortadakikart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.kartcekbutoneski = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kartcekbuton = new System.Windows.Forms.PictureBox();
            this.ortadakikart = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kartcekbuton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ortadakikart)).BeginInit();
            this.SuspendLayout();
            // 
            // eskiortadakikart
            // 
            this.eskiortadakikart.Location = new System.Drawing.Point(461, 13);
            this.eskiortadakikart.Margin = new System.Windows.Forms.Padding(2);
            this.eskiortadakikart.Name = "eskiortadakikart";
            this.eskiortadakikart.Size = new System.Drawing.Size(109, 158);
            this.eskiortadakikart.TabIndex = 3;
            this.eskiortadakikart.UseVisualStyleBackColor = true;
            this.eskiortadakikart.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(673, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1250, 41);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(662, 325);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(1250, 372);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(662, 383);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Location = new System.Drawing.Point(1250, 753);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(662, 252);
            this.flowLayoutPanel5.TabIndex = 8;
            // 
            // kartcekbutoneski
            // 
            this.kartcekbutoneski.Image = global::WindowsFormsApp1.Properties.Resources.uno;
            this.kartcekbutoneski.Location = new System.Drawing.Point(23, 36);
            this.kartcekbutoneski.Margin = new System.Windows.Forms.Padding(2);
            this.kartcekbutoneski.Name = "kartcekbutoneski";
            this.kartcekbutoneski.Size = new System.Drawing.Size(110, 155);
            this.kartcekbutoneski.TabIndex = 1;
            this.kartcekbutoneski.UseVisualStyleBackColor = true;
            this.kartcekbutoneski.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(680, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 326);
            this.panel1.TabIndex = 0;
            // 
            // kartcekbuton
            // 
            this.kartcekbuton.Image = global::WindowsFormsApp1.Properties.Resources.uno;
            this.kartcekbuton.Location = new System.Drawing.Point(33, 41);
            this.kartcekbuton.Name = "kartcekbuton";
            this.kartcekbuton.Size = new System.Drawing.Size(100, 150);
            this.kartcekbuton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kartcekbuton.TabIndex = 9;
            this.kartcekbuton.TabStop = false;
            this.kartcekbuton.Click += new System.EventHandler(this.kartcekbuton_Click_1);
            // 
            // ortadakikart
            // 
            this.ortadakikart.Location = new System.Drawing.Point(461, 21);
            this.ortadakikart.Name = "ortadakikart";
            this.ortadakikart.Size = new System.Drawing.Size(100, 150);
            this.ortadakikart.TabIndex = 11;
            this.ortadakikart.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(23, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 288);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(698, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 391);
            this.panel3.TabIndex = 13;
            // 
            // UnoOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ortadakikart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.eskiortadakikart);
            this.Controls.Add(this.kartcekbuton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kartcekbutoneski);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UnoOyun";
            this.Text = "UnoOyun";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UnoOyun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kartcekbuton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ortadakikart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kartcekbutoneski;
        private System.Windows.Forms.Button eskiortadakikart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox kartcekbuton;
        private System.Windows.Forms.PictureBox ortadakikart;
        private System.Windows.Forms.FlowLayoutPanel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}