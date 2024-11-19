namespace PocitactkaDelegat;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Vypocty.Vystup += ShowResult;
    }

    private void btnSoucet_Click(object sender, EventArgs e)
    {
        Vypocty.Soucet(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text));
    }

    private void btnRozdil_Click(object sender, EventArgs e)
    {
        Vypocty.Rozdil(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text));
    }

    private void btnSoucin_Click(object sender, EventArgs e)
    {
        Vypocty.Soucin(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text));
    }

    private void btnPodil_Click(object sender, EventArgs e)
    {
        Vypocty.Podil(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text));
    }

    private void ShowResult(string s) => txtVysledek.Text = s;
}