namespace TCPSerwer
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
            this.Adres = new System.Windows.Forms.TextBox();
            this.main_port = new System.Windows.Forms.NumericUpDown();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.PrzyciskStop = new System.Windows.Forms.Button();
            this.PrzyciskStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_port)).BeginInit();
            this.SuspendLayout();
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(25, 27);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(343, 20);
            this.Adres.TabIndex = 0;
            this.Adres.Text = "Adres";
            // 
            // main_port
            // 
            this.main_port.Location = new System.Drawing.Point(402, 28);
            this.main_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.main_port.Name = "main_port";
            this.main_port.Size = new System.Drawing.Size(337, 20);
            this.main_port.TabIndex = 1;
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(25, 79);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(714, 238);
            this.info_o_polaczeniu.TabIndex = 2;
            // 
            // PrzyciskStop
            // 
            this.PrzyciskStop.Location = new System.Drawing.Point(481, 331);
            this.PrzyciskStop.Name = "PrzyciskStop";
            this.PrzyciskStop.Size = new System.Drawing.Size(165, 50);
            this.PrzyciskStop.TabIndex = 3;
            this.PrzyciskStop.Text = "Stop";
            this.PrzyciskStop.UseVisualStyleBackColor = true;
            // 
            // PrzyciskStart
            // 
            this.PrzyciskStart.Location = new System.Drawing.Point(138, 331);
            this.PrzyciskStart.Name = "PrzyciskStart";
            this.PrzyciskStart.Size = new System.Drawing.Size(181, 50);
            this.PrzyciskStart.TabIndex = 4;
            this.PrzyciskStart.Text = "Start";
            this.PrzyciskStart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 399);
            this.Controls.Add(this.PrzyciskStart);
            this.Controls.Add(this.PrzyciskStop);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.main_port);
            this.Controls.Add(this.Adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.main_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.NumericUpDown main_port;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
        private System.Windows.Forms.Button PrzyciskStop;
        private System.Windows.Forms.Button PrzyciskStart;
    }
}

