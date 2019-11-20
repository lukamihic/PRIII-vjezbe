namespace WindowsFormsApp1
{
    partial class Temp
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cbBHTelecom = new System.Windows.Forms.CheckBox();
            this.cbHTEronet = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(609, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "12:55:34";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Notifikacije";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBHTelecom
            // 
            this.cbBHTelecom.AutoSize = true;
            this.cbBHTelecom.Location = new System.Drawing.Point(12, 9);
            this.cbBHTelecom.Name = "cbBHTelecom";
            this.cbBHTelecom.Size = new System.Drawing.Size(85, 17);
            this.cbBHTelecom.TabIndex = 2;
            this.cbBHTelecom.Text = "BH Telecom";
            this.cbBHTelecom.UseVisualStyleBackColor = true;
            this.cbBHTelecom.CheckedChanged += new System.EventHandler(this.cbBHTelecom_CheckedChanged);
            // 
            // cbHTEronet
            // 
            this.cbHTEronet.AutoSize = true;
            this.cbHTEronet.Location = new System.Drawing.Point(12, 32);
            this.cbHTEronet.Name = "cbHTEronet";
            this.cbHTEronet.Size = new System.Drawing.Size(75, 17);
            this.cbHTEronet.TabIndex = 3;
            this.cbHTEronet.Text = "HT Eronet";
            this.cbHTEronet.UseVisualStyleBackColor = true;
            this.cbHTEronet.CheckedChanged += new System.EventHandler(this.cbHTEronet_CheckedChanged);
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 156);
            this.Controls.Add(this.cbHTEronet);
            this.Controls.Add(this.cbBHTelecom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Temp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbBHTelecom;
        private System.Windows.Forms.CheckBox cbHTEronet;
    }
}