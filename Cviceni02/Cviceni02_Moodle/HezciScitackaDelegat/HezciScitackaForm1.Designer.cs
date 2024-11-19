namespace HezciScitackaDelegat
{
    partial class HezciScitackaForm1
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
            this.hodnota2 = new System.Windows.Forms.NumericUpDown();
            this.hodnota1 = new System.Windows.Forms.NumericUpDown();
            this.deleni = new System.Windows.Forms.Button();
            this.nasobeni = new System.Windows.Forms.Button();
            this.odcitani = new System.Windows.Forms.Button();
            this.scitani = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vysledek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hodnota2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hodnota1)).BeginInit();
            this.SuspendLayout();
            // 
            // hodnota2
            // 
            this.hodnota2.Location = new System.Drawing.Point(121, 47);
            this.hodnota2.Name = "hodnota2";
            this.hodnota2.Size = new System.Drawing.Size(87, 20);
            this.hodnota2.TabIndex = 21;
            // 
            // hodnota1
            // 
            this.hodnota1.Location = new System.Drawing.Point(121, 21);
            this.hodnota1.Name = "hodnota1";
            this.hodnota1.Size = new System.Drawing.Size(87, 20);
            this.hodnota1.TabIndex = 20;
            // 
            // deleni
            // 
            this.deleni.Location = new System.Drawing.Point(165, 119);
            this.deleni.Name = "deleni";
            this.deleni.Size = new System.Drawing.Size(25, 25);
            this.deleni.TabIndex = 29;
            this.deleni.Text = "/";
            this.deleni.UseVisualStyleBackColor = true;
            this.deleni.Click += new System.EventHandler(this.deleni_Click);
            // 
            // nasobeni
            // 
            this.nasobeni.Location = new System.Drawing.Point(134, 119);
            this.nasobeni.Name = "nasobeni";
            this.nasobeni.Size = new System.Drawing.Size(25, 25);
            this.nasobeni.TabIndex = 28;
            this.nasobeni.Text = "*";
            this.nasobeni.UseVisualStyleBackColor = true;
            this.nasobeni.Click += new System.EventHandler(this.nasobeni_Click);
            // 
            // odcitani
            // 
            this.odcitani.Location = new System.Drawing.Point(103, 119);
            this.odcitani.Name = "odcitani";
            this.odcitani.Size = new System.Drawing.Size(25, 25);
            this.odcitani.TabIndex = 27;
            this.odcitani.Text = "-";
            this.odcitani.UseVisualStyleBackColor = true;
            this.odcitani.Click += new System.EventHandler(this.odcitani_Click);
            // 
            // scitani
            // 
            this.scitani.Location = new System.Drawing.Point(72, 119);
            this.scitani.Name = "scitani";
            this.scitani.Size = new System.Drawing.Size(25, 25);
            this.scitani.TabIndex = 26;
            this.scitani.Text = "+";
            this.scitani.UseVisualStyleBackColor = true;
            this.scitani.Click += new System.EventHandler(this.scitani_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Výsledek:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Hodnota 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hodnota 1:";
            // 
            // vysledek
            // 
            this.vysledek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.vysledek.Enabled = false;
            this.vysledek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vysledek.Location = new System.Drawing.Point(121, 87);
            this.vysledek.Name = "vysledek";
            this.vysledek.Size = new System.Drawing.Size(87, 20);
            this.vysledek.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 30;
            // 
            // HezciScitackaForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 164);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hodnota2);
            this.Controls.Add(this.hodnota1);
            this.Controls.Add(this.deleni);
            this.Controls.Add(this.nasobeni);
            this.Controls.Add(this.odcitani);
            this.Controls.Add(this.scitani);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vysledek);
            this.Name = "HezciScitackaForm1";
            this.Text = "Hezčí sčítačka s delegátem";
            ((System.ComponentModel.ISupportInitialize)(this.hodnota2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hodnota1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown hodnota2;
        private System.Windows.Forms.NumericUpDown hodnota1;
        private System.Windows.Forms.Button deleni;
        private System.Windows.Forms.Button nasobeni;
        private System.Windows.Forms.Button odcitani;
        private System.Windows.Forms.Button scitani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vysledek;
        private System.Windows.Forms.Label label4;
    }
}

