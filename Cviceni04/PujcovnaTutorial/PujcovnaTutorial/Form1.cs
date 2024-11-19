using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PujcovnaTutorial
{
    public partial class Form1 : Form
    {
        CustomerDialog zakaznikDialog = new CustomerDialog();

        public Form1()
        {
            InitializeComponent();
            dgvZakaznici.DataSource = Databaze.Zakaznici;
            dgvSklad.DataSource = Databaze.Sklad;                        
        }

        private void SetButtons()
        {
            btnVypujcit.Enabled = (dgvSklad.Rows.Count > 0);
            btnVratit.Enabled = (dgvVypujcene.Rows.Count > 0);
        }

        private void btnVypujcit_Click(object sender, EventArgs e)
        {
            //Databaze.Vypujcit(dgvZakaznici.CurrentCell.RowIndex, dgvSklad.CurrentCell.RowIndex);
            Databaze.Vypujcit(dgvZakaznici.CurrentRow.DataBoundItem, dgvSklad.CurrentRow.DataBoundItem);
            SetButtons();
        }


        private void btnVratit_Click(object sender, EventArgs e)
        {
            //Databaze.Vratit(dgvZakaznici.CurrentCell.RowIndex, dgvVypujcene.CurrentCell.RowIndex);
            Databaze.Vratit(dgvZakaznici.CurrentRow.DataBoundItem, dgvVypujcene.CurrentRow.DataBoundItem);
            SetButtons();
        }

        private void dgvZakaznici_SelectionChanged(object sender, EventArgs e)
        {
            dgvVypujcene.DataSource = ((Zakaznik)dgvZakaznici.CurrentRow.DataBoundItem).Vypujcene;
            SetButtons();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Databaze.Serializuj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zakaznikDialog.Action = ActionType.New;
            if (zakaznikDialog.ShowDialog() == DialogResult.OK)
                Databaze.Zakaznici.Add(zakaznikDialog.CustomerInstance);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zakaznikDialog.Action = ActionType.Edit;
            zakaznikDialog.CustomerInstance = (Zakaznik)dgvZakaznici.CurrentRow.DataBoundItem;
            zakaznikDialog.ShowDialog();
        }
    }
}
