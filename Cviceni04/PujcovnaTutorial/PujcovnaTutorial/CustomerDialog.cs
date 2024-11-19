﻿using System;
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
    public enum ActionType { New, Edit };

    public partial class CustomerDialog : Form
    {
        public ActionType Action { get; set; } = ActionType.New;
        public Zakaznik CustomerInstance { get; set; }

        public CustomerDialog()
        {
            InitializeComponent();
        }

        private void CustomerDialog_VisibleChanged(object sender, EventArgs e)
        {
            if (Action == ActionType.Edit)
            {
                txtJmeno.Text = CustomerInstance.Jmeno;
                txtPrijmeni.Text = CustomerInstance.Prijmeni;
                txtAdresa.Text = CustomerInstance.Adresa;
                numRok.Value = CustomerInstance.RokNarozeni;
            }
            else
            {
                txtJmeno.Text = "";
                txtPrijmeni.Text = "";
                txtAdresa.Text = "";
                numRok.Value = 1900;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Action)
            {
                case ActionType.New:
                    CustomerInstance = new Zakaznik(txtJmeno.Text, txtPrijmeni.Text, txtAdresa.Text, (int)numRok.Value);
                    break;
                case ActionType.Edit:
                    CustomerInstance.Jmeno = txtJmeno.Text;
                    CustomerInstance.Prijmeni = txtPrijmeni.Text;
                    CustomerInstance.Adresa = txtAdresa.Text;
                    CustomerInstance.RokNarozeni = (int)numRok.Value;
                    break;
            }
        }
    }
}
