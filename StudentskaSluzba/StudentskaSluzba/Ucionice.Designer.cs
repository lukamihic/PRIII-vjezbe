namespace StudentskaSluzba
{
    partial class Ucionice
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbZauzet = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaziv.Location = new System.Drawing.Point(12, 12);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(213, 24);
            this.txtNaziv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv Učionice";
            // 
            // cbZauzet
            // 
            this.cbZauzet.AutoSize = true;
            this.cbZauzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbZauzet.Location = new System.Drawing.Point(148, 40);
            this.cbZauzet.Name = "cbZauzet";
            this.cbZauzet.Size = new System.Drawing.Size(82, 20);
            this.cbZauzet.TabIndex = 2;
            this.cbZauzet.Text = "Zauzeto?";
            this.cbZauzet.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(67, 83);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(116, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj učionicu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Ucionice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 164);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbZauzet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Name = "Ucionice";
            this.Text = "Ucionice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbZauzet;
        private System.Windows.Forms.Button btnDodaj;
    }
}