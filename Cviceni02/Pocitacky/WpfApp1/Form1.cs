namespace WpfApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnSoucet_Click(object sender, EventArgs e)
    {
        txtVysledek.Text = (Convert.ToInt32(txtA.Text) + Convert.ToInt32(txtB.Text)).ToString();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void btnRozdil_Click(object sender, EventArgs e)
    {
        txtVysledek.Text = (Convert.ToInt32(txtA.Text) - Convert.ToInt32(txtB.Text)).ToString();
    }

    private void btnSoucin_Click(object sender, EventArgs e)
    {
        txtVysledek.Text = (Convert.ToInt32(txtA.Text) * Convert.ToInt32(txtB.Text)).ToString();
    }

    private void btnPodil_Click(object sender, EventArgs e)
    {
        txtVysledek.Text = (Convert.ToInt32(txtA.Text) / Convert.ToInt32(txtB.Text)).ToString();
    }
}