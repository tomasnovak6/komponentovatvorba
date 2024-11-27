using System.ComponentModel.DataAnnotations.Schema;

namespace Pujcovna;

public partial class Pujcovna : Form
{
    public Pujcovna()
    {
        InitializeComponent();
        dvgZakaznici.DataSource = Databaze.Zakaznici;
        dvgSklad.DataSource = Databaze.Sklad;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void SetButtons()
    {
        btnVypujcit.Enabled = (dvgSklad.Rows.Count > 0);
        btnVratit.Enabled = (dvgVypujcene.Rows.Count > 0);
    }

    private void btnVypujcit_Click(object sender, EventArgs e)
    {
        // int indZ = dvgZakaznici.CurrentCell.RowIndex;
        // int indS = dvgSklad.CurrentCell.RowIndex;

        // Databaze.Zakaznici[indZ].Vypujcene.Add(Databaze.Sklad[indS]);
        // Databaze.Sklad.RemoveAt(indS);

        // Zakaznik z = (Zakaznik)dvgZakaznici.CurrentRow.DataBoundItem;
        // Disk d = (Disk)dvgSklad.CurrentRow.DataBoundItem;

        // z.Vypujcene.Add(d);
        // Databaze.Sklad.Remove(d);

        Databaze.Vypujcit(dvgZakaznici.CurrentRow.DataBoundItem, dvgSklad.CurrentRow.DataBoundItem);

        SetButtons();
    }

    private void btnVratit_Click(object sender, EventArgs e)
    {
        // int indZ = dvgZakaznici.CurrentCell.RowIndex;
        // int indP = dvgVypujcene.CurrentCell.RowIndex;

        // Databaze.Sklad.Add(Databaze.Zakaznici[indZ].Vypujcene[indP]);
        // Databaze.Zakaznici[indP].Vypujcene.RemoveAt(indP);

        // Zakaznik z = (Zakaznik)dvgZakaznici.CurrentRow.DataBoundItem;
        // Disk d = (Disk)dvgVypujcene.CurrentRow.DataBoundItem;

        // Databaze.Sklad.Add(d);
        // z.Vypujcene.Remove(d);

        Databaze.Vratit(dvgZakaznici.CurrentRow.DataBoundItem, dvgVypujcene.CurrentRow.DataBoundItem);

        SetButtons();
    }

    private void dvgZakaznici_SelectionChanged(object sender, EventArgs e)
    {
        int indZ = dvgZakaznici.CurrentCell.RowIndex;
        // dvgVypujcene.DataSource = Databaze.Zakaznici[indZ].Vypujcene;
        dvgVypujcene.DataSource = ((Zakaznik)dvgZakaznici.CurrentRow.DataBoundItem).Vypujcene;

        SetButtons();
    }
}