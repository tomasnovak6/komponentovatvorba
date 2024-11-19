
namespace Pujcovna;

partial class Pujcovna
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dvgZakaznici = new DataGridView();
        dvgSklad = new DataGridView();
        dvgVypujcene = new DataGridView();
        btnVypujcit = new Button();
        btnVratit = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        ((System.ComponentModel.ISupportInitialize)dvgZakaznici).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dvgSklad).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dvgVypujcene).BeginInit();
        SuspendLayout();
        // 
        // dvgZakaznici
        // 
        dvgZakaznici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dvgZakaznici.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dvgZakaznici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dvgZakaznici.EditMode = DataGridViewEditMode.EditProgrammatically;
        dvgZakaznici.Location = new Point(33, 54);
        dvgZakaznici.MultiSelect = false;
        dvgZakaznici.Name = "dvgZakaznici";
        dvgZakaznici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dvgZakaznici.Size = new Size(363, 150);
        dvgZakaznici.TabIndex = 0;
        dvgZakaznici.SelectionChanged += dvgZakaznici_SelectionChanged;
        // 
        // dvgSklad
        // 
        dvgSklad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dvgSklad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dvgSklad.EditMode = DataGridViewEditMode.EditProgrammatically;
        dvgSklad.Location = new Point(550, 54);
        dvgSklad.MultiSelect = false;
        dvgSklad.Name = "dvgSklad";
        dvgSklad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dvgSklad.Size = new Size(330, 150);
        dvgSklad.TabIndex = 1;
        // 
        // dvgVypujcene
        // 
        dvgVypujcene.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dvgVypujcene.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dvgVypujcene.EditMode = DataGridViewEditMode.EditProgrammatically;
        dvgVypujcene.Location = new Point(33, 265);
        dvgVypujcene.MultiSelect = false;
        dvgVypujcene.Name = "dvgVypujcene";
        dvgVypujcene.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dvgVypujcene.Size = new Size(847, 150);
        dvgVypujcene.TabIndex = 2;
        // 
        // btnVypujcit
        // 
        btnVypujcit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnVypujcit.Location = new Point(402, 70);
        btnVypujcit.Name = "btnVypujcit";
        btnVypujcit.Size = new Size(142, 48);
        btnVypujcit.TabIndex = 3;
        btnVypujcit.Text = "Vypujcit";
        btnVypujcit.UseVisualStyleBackColor = true;
        btnVypujcit.Click += btnVypujcit_Click;
        // 
        // btnVratit
        // 
        btnVratit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnVratit.Location = new Point(402, 124);
        btnVratit.Name = "btnVratit";
        btnVratit.Size = new Size(142, 44);
        btnVratit.TabIndex = 4;
        btnVratit.Text = "Vratit";
        btnVratit.UseVisualStyleBackColor = true;
        btnVratit.Click += btnVratit_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(33, 27);
        label1.Name = "label1";
        label1.Size = new Size(56, 15);
        label1.TabIndex = 5;
        label1.Text = "Zakaznici";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(550, 27);
        label2.Name = "label2";
        label2.Size = new Size(35, 15);
        label2.TabIndex = 6;
        label2.Text = "Sklad";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(33, 237);
        label3.Name = "label3";
        label3.Size = new Size(106, 15);
        label3.TabIndex = 7;
        label3.Text = "Vypujcene polozky";
        // 
        // Pujcovna
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(913, 449);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnVratit);
        Controls.Add(btnVypujcit);
        Controls.Add(dvgVypujcene);
        Controls.Add(dvgSklad);
        Controls.Add(dvgZakaznici);
        Name = "Pujcovna";
        Text = "Pujcovna                                    ";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dvgZakaznici).EndInit();
        ((System.ComponentModel.ISupportInitialize)dvgSklad).EndInit();
        ((System.ComponentModel.ISupportInitialize)dvgVypujcene).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    #endregion

    private DataGridView dvgZakaznici;
    private DataGridView dvgSklad;
    private DataGridView dvgVypujcene;
    private Button btnVypujcit;
    private Button btnVratit;
    private Label label1;
    private Label label2;
    private Label label3;
}