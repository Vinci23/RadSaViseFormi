namespace RadSaViseFormi
{
    partial class Studenti
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisiStud = new System.Windows.Forms.Button();
            this.btnObrisiSve = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(32, 36);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(129, 44);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj novog studenta";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisiStud
            // 
            this.btnObrisiStud.Location = new System.Drawing.Point(583, 166);
            this.btnObrisiStud.Name = "btnObrisiStud";
            this.btnObrisiStud.Size = new System.Drawing.Size(112, 46);
            this.btnObrisiStud.TabIndex = 1;
            this.btnObrisiStud.Text = "Obiši studenta";
            this.btnObrisiStud.UseVisualStyleBackColor = true;
            this.btnObrisiStud.Click += new System.EventHandler(this.btnObrisiStud_Click);
            // 
            // btnObrisiSve
            // 
            this.btnObrisiSve.Location = new System.Drawing.Point(32, 320);
            this.btnObrisiSve.Name = "btnObrisiSve";
            this.btnObrisiSve.Size = new System.Drawing.Size(236, 47);
            this.btnObrisiSve.TabIndex = 2;
            this.btnObrisiSve.Text = "Obriši sve studente";
            this.btnObrisiSve.UseVisualStyleBackColor = true;
            this.btnObrisiSve.Click += new System.EventHandler(this.btnObrisiSve_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(513, 199);
            this.listBox1.TabIndex = 3;
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnObrisiSve);
            this.Controls.Add(this.btnObrisiStud);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisiStud;
        private System.Windows.Forms.Button btnObrisiSve;
        private System.Windows.Forms.ListBox listBox1;
    }
}

