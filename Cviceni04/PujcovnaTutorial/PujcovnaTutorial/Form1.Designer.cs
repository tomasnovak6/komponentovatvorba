namespace PujcovnaTutorial
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
            this.dgvZakaznici = new System.Windows.Forms.DataGridView();
            this.dgvSklad = new System.Windows.Forms.DataGridView();
            this.dgvVypujcene = new System.Windows.Forms.DataGridView();
            this.btnVypujcit = new System.Windows.Forms.Button();
            this.btnVratit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaznici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSklad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVypujcene)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZakaznici
            // 
            this.dgvZakaznici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakaznici.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvZakaznici.Location = new System.Drawing.Point(12, 33);
            this.dgvZakaznici.MultiSelect = false;
            this.dgvZakaznici.Name = "dgvZakaznici";
            this.dgvZakaznici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZakaznici.Size = new System.Drawing.Size(411, 150);
            this.dgvZakaznici.TabIndex = 0;
            this.dgvZakaznici.SelectionChanged += new System.EventHandler(this.dgvZakaznici_SelectionChanged);
            // 
            // dgvSklad
            // 
            this.dgvSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSklad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSklad.Location = new System.Drawing.Point(551, 33);
            this.dgvSklad.MultiSelect = false;
            this.dgvSklad.Name = "dgvSklad";
            this.dgvSklad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSklad.Size = new System.Drawing.Size(425, 150);
            this.dgvSklad.TabIndex = 1;
            // 
            // dgvVypujcene
            // 
            this.dgvVypujcene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVypujcene.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVypujcene.Location = new System.Drawing.Point(12, 227);
            this.dgvVypujcene.MultiSelect = false;
            this.dgvVypujcene.Name = "dgvVypujcene";
            this.dgvVypujcene.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVypujcene.Size = new System.Drawing.Size(772, 150);
            this.dgvVypujcene.TabIndex = 2;
            // 
            // btnVypujcit
            // 
            this.btnVypujcit.Location = new System.Drawing.Point(429, 33);
            this.btnVypujcit.Name = "btnVypujcit";
            this.btnVypujcit.Size = new System.Drawing.Size(116, 48);
            this.btnVypujcit.TabIndex = 3;
            this.btnVypujcit.Text = "Vypůjčit";
            this.btnVypujcit.UseVisualStyleBackColor = true;
            this.btnVypujcit.Click += new System.EventHandler(this.btnVypujcit_Click);
            // 
            // btnVratit
            // 
            this.btnVratit.Location = new System.Drawing.Point(429, 87);
            this.btnVratit.Name = "btnVratit";
            this.btnVratit.Size = new System.Drawing.Size(116, 48);
            this.btnVratit.TabIndex = 4;
            this.btnVratit.Text = "Vrátit";
            this.btnVratit.UseVisualStyleBackColor = true;
            this.btnVratit.Click += new System.EventHandler(this.btnVratit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zákazníci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sklad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vypůjčené položky vybraného zákazníka:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Přidat zákazníka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(800, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Editovat zákazníka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVratit);
            this.Controls.Add(this.btnVypujcit);
            this.Controls.Add(this.dgvVypujcene);
            this.Controls.Add(this.dgvSklad);
            this.Controls.Add(this.dgvZakaznici);
            this.Name = "Form1";
            this.Text = "Půjčovna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaznici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSklad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVypujcene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZakaznici;
        private System.Windows.Forms.DataGridView dgvSklad;
        private System.Windows.Forms.DataGridView dgvVypujcene;
        private System.Windows.Forms.Button btnVypujcit;
        private System.Windows.Forms.Button btnVratit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

