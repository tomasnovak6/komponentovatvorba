namespace WpfApp1;

partial class Form1
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
        btnSoucet = new Button();
        btnRozdil = new Button();
        btnPodil = new Button();
        btnSoucin = new Button();
        txtVysledek = new TextBox();
        txtB = new TextBox();
        txtA = new TextBox();
        lblA = new Label();
        lblB = new Label();
        lblVysledek = new Label();
        SuspendLayout();
        // 
        // btnSoucet
        // 
        btnSoucet.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSoucet.Location = new Point(39, 238);
        btnSoucet.Name = "btnSoucet";
        btnSoucet.Size = new Size(184, 78);
        btnSoucet.TabIndex = 0;
        btnSoucet.Text = "+";
        btnSoucet.UseVisualStyleBackColor = true;
        btnSoucet.Click += btnSoucet_Click;
        // 
        // btnRozdil
        // 
        btnRozdil.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnRozdil.Location = new Point(261, 238);
        btnRozdil.Name = "btnRozdil";
        btnRozdil.Size = new Size(184, 78);
        btnRozdil.TabIndex = 1;
        btnRozdil.Text = "-";
        btnRozdil.UseVisualStyleBackColor = true;
        btnRozdil.Click += btnRozdil_Click;
        // 
        // btnPodil
        // 
        btnPodil.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnPodil.Location = new Point(261, 344);
        btnPodil.Name = "btnPodil";
        btnPodil.Size = new Size(184, 78);
        btnPodil.TabIndex = 3;
        btnPodil.Text = "/";
        btnPodil.UseVisualStyleBackColor = true;
        btnPodil.Click += btnPodil_Click;
        // 
        // btnSoucin
        // 
        btnSoucin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSoucin.Location = new Point(39, 344);
        btnSoucin.Name = "btnSoucin";
        btnSoucin.Size = new Size(184, 78);
        btnSoucin.TabIndex = 2;
        btnSoucin.Text = "*";
        btnSoucin.UseVisualStyleBackColor = true;
        btnSoucin.Click += btnSoucin_Click;
        // 
        // txtVysledek
        // 
        txtVysledek.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtVysledek.Location = new Point(220, 172);
        txtVysledek.Name = "txtVysledek";
        txtVysledek.Size = new Size(225, 39);
        txtVysledek.TabIndex = 4;
        // 
        // txtB
        // 
        txtB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtB.Location = new Point(220, 101);
        txtB.Name = "txtB";
        txtB.Size = new Size(225, 39);
        txtB.TabIndex = 5;
        // 
        // txtA
        // 
        txtA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtA.Location = new Point(220, 28);
        txtA.Name = "txtA";
        txtA.Size = new Size(225, 39);
        txtA.TabIndex = 6;
        // 
        // lblA
        // 
        lblA.AutoSize = true;
        lblA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblA.Location = new Point(39, 31);
        lblA.Name = "lblA";
        lblA.Size = new Size(134, 32);
        lblA.TabIndex = 7;
        lblA.Text = "Hodnota A:";
        lblA.Click += label1_Click;
        // 
        // lblB
        // 
        lblB.AutoSize = true;
        lblB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblB.Location = new Point(39, 101);
        lblB.Name = "lblB";
        lblB.Size = new Size(133, 32);
        lblB.TabIndex = 8;
        lblB.Text = "Hodnota B:";
        lblB.Click += label1_Click_1;
        // 
        // lblVysledek
        // 
        lblVysledek.AutoSize = true;
        lblVysledek.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblVysledek.Location = new Point(40, 175);
        lblVysledek.Name = "lblVysledek";
        lblVysledek.Size = new Size(114, 32);
        lblVysledek.TabIndex = 9;
        lblVysledek.Text = "Výsledek:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 450);
        Controls.Add(lblVysledek);
        Controls.Add(lblB);
        Controls.Add(lblA);
        Controls.Add(txtA);
        Controls.Add(txtB);
        Controls.Add(txtVysledek);
        Controls.Add(btnPodil);
        Controls.Add(btnSoucin);
        Controls.Add(btnRozdil);
        Controls.Add(btnSoucet);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnSoucet;
    private Button btnRozdil;
    private Button btnPodil;
    private Button btnSoucin;
    private TextBox txtVysledek;
    private TextBox txtB;
    private TextBox txtA;
    private Label lblA;
    private Label lblB;
    private Label lblVysledek;
}