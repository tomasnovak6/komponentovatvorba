namespace PocitactkaDelegat;

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
        lblVysledek = new Label();
        lblB = new Label();
        lblA = new Label();
        txtA = new TextBox();
        txtB = new TextBox();
        txtVysledek = new TextBox();
        btnPodil = new Button();
        btnSoucin = new Button();
        btnRozdil = new Button();
        btnSoucet = new Button();
        SuspendLayout();
        // 
        // lblVysledek
        // 
        lblVysledek.AutoSize = true;
        lblVysledek.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        lblVysledek.Location = new Point(42, 187);
        lblVysledek.Name = "lblVysledek";
        lblVysledek.Size = new Size(114, 32);
        lblVysledek.TabIndex = 29;
        lblVysledek.Text = "Výsledek:";
        // 
        // lblB
        // 
        lblB.AutoSize = true;
        lblB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        lblB.Location = new Point(41, 113);
        lblB.Name = "lblB";
        lblB.Size = new Size(133, 32);
        lblB.TabIndex = 28;
        lblB.Text = "Hodnota B:";
        // 
        // lblA
        // 
        lblA.AutoSize = true;
        lblA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        lblA.Location = new Point(41, 43);
        lblA.Name = "lblA";
        lblA.Size = new Size(134, 32);
        lblA.TabIndex = 27;
        lblA.Text = "Hodnota A:";
        // 
        // txtA
        // 
        txtA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        txtA.Location = new Point(222, 40);
        txtA.Name = "txtA";
        txtA.Size = new Size(225, 39);
        txtA.TabIndex = 26;
        // 
        // txtB
        // 
        txtB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        txtB.Location = new Point(222, 113);
        txtB.Name = "txtB";
        txtB.Size = new Size(225, 39);
        txtB.TabIndex = 25;
        // 
        // txtVysledek
        // 
        txtVysledek.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        txtVysledek.Location = new Point(222, 184);
        txtVysledek.Name = "txtVysledek";
        txtVysledek.Size = new Size(225, 39);
        txtVysledek.TabIndex = 24;
        // 
        // btnPodil
        // 
        btnPodil.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        btnPodil.Location = new Point(263, 356);
        btnPodil.Name = "btnPodil";
        btnPodil.Size = new Size(184, 78);
        btnPodil.TabIndex = 23;
        btnPodil.Text = "/";
        btnPodil.UseVisualStyleBackColor = true;
        btnPodil.Click += btnPodil_Click;
        // 
        // btnSoucin
        // 
        btnSoucin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        btnSoucin.Location = new Point(41, 356);
        btnSoucin.Name = "btnSoucin";
        btnSoucin.Size = new Size(184, 78);
        btnSoucin.TabIndex = 22;
        btnSoucin.Text = "*";
        btnSoucin.UseVisualStyleBackColor = true;
        btnSoucin.Click += btnSoucin_Click;
        // 
        // btnRozdil
        // 
        btnRozdil.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        btnRozdil.Location = new Point(263, 250);
        btnRozdil.Name = "btnRozdil";
        btnRozdil.Size = new Size(184, 78);
        btnRozdil.TabIndex = 21;
        btnRozdil.Text = "-";
        btnRozdil.UseVisualStyleBackColor = true;
        btnRozdil.Click += btnRozdil_Click;
        // 
        // btnSoucet
        // 
        btnSoucet.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        btnSoucet.Location = new Point(41, 250);
        btnSoucet.Name = "btnSoucet";
        btnSoucet.Size = new Size(184, 78);
        btnSoucet.TabIndex = 20;
        btnSoucet.Text = "+";
        btnSoucet.UseVisualStyleBackColor = true;
        btnSoucet.Click += btnSoucet_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(489, 481);
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

    private Label lblVysledek;
    private Label lblB;
    private Label lblA;
    private TextBox txtA;
    private TextBox txtB;
    private TextBox txtVysledek;
    private Button btnPodil;
    private Button btnSoucin;
    private Button btnRozdil;
    private Button btnSoucet;
}