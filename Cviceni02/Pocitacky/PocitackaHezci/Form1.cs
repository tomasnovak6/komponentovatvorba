namespace PocitackaHezci;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnSoucet_Click(object sender, EventArgs e)
    {
        txtVysledek.Text = Vypocty.Soucet(txtA.Text, txtB.Text);
    }

    private void btnRozdil_Click(object sender, EventArgs e)
    {
        txtVysledek.Text = Vypocty.Rozdil(txtA.Text, txtB.Text);
    }

    private void btnSoucin_Click(object sender, EventArgs e)
    {
        txtVysledek.Text = Vypocty.Soucin(txtA.Text, txtB.Text);
    }

    private void btnPodil_Click(object sender, EventArgs e)
    {
        txtVysledek.Text = Vypocty.Podil(txtA.Text, txtB.Text);
    }
}