namespace WindowsFormsApp5
{
    partial class paneBlue
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMyDetect = new System.Windows.Forms.Button();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOryginalDetect = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAllDetect = new System.Windows.Forms.Button();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMyDetect
            // 
            this.btnMyDetect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMyDetect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMyDetect.Location = new System.Drawing.Point(594, 11);
            this.btnMyDetect.Name = "btnMyDetect";
            this.btnMyDetect.Size = new System.Drawing.Size(132, 23);
            this.btnMyDetect.TabIndex = 0;
            this.btnMyDetect.Text = "Mój Rozpoznaj";
            this.btnMyDetect.UseVisualStyleBackColor = false;
            this.btnMyDetect.Click += new System.EventHandler(this.btnMyDetect_Click);
            // 
            // cboDevice
            // 
            this.cboDevice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(98, 27);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(406, 21);
            this.cboDevice.TabIndex = 1;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 70);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(961, 650);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Urządzenie";
            // 
            // btnOryginalDetect
            // 
            this.btnOryginalDetect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOryginalDetect.Location = new System.Drawing.Point(594, 40);
            this.btnOryginalDetect.Name = "btnOryginalDetect";
            this.btnOryginalDetect.Size = new System.Drawing.Size(132, 23);
            this.btnOryginalDetect.TabIndex = 6;
            this.btnOryginalDetect.Text = "Oryginalny Rozpoznaj";
            this.btnOryginalDetect.UseVisualStyleBackColor = false;
            this.btnOryginalDetect.Click += new System.EventHandler(this.btnOryginalDetect_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(513, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 52);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAllDetect
            // 
            this.btnAllDetect.Location = new System.Drawing.Point(732, 11);
            this.btnAllDetect.Name = "btnAllDetect";
            this.btnAllDetect.Size = new System.Drawing.Size(75, 51);
            this.btnAllDetect.TabIndex = 8;
            this.btnAllDetect.Text = "Porównanie";
            this.btnAllDetect.UseVisualStyleBackColor = true;
            this.btnAllDetect.Click += new System.EventHandler(this.btnAllDetect_Click);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(833, 14);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(23, 20);
            this.panelRed.TabIndex = 9;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(833, 40);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(23, 22);
            this.panelBlue.TabIndex = 10;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(862, 16);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(80, 13);
            this.lab1.TabIndex = 11;
            this.lab1.Text = "Mój klasyfikator";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(862, 45);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(112, 13);
            this.lab2.TabIndex = 12;
            this.lab2.Text = "Oryginalny klasyfikator";
            // 
            // paneBlue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(985, 732);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.panelRed);
            this.Controls.Add(this.btnAllDetect);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOryginalDetect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.btnMyDetect);
            this.Name = "paneBlue";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMyDetect;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOryginalDetect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAllDetect;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
    }
}

