using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace firma
{
    public partial class ModifAngajat : Form
    {
        public ModifAngajat()
        {
            InitializeComponent();
        }

        private void ModifAngajat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmaDataSet.departamente' table. You can move, or remove it, as needed.
            this.departamenteTableAdapter.Fill(this.firmaDataSet.departamente);
            // TODO: This line of code loads data into the 'firmaDataSet.angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.firmaDataSet.angajati);

        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            Form1.A = new Angajat();
            if (TBDataN.Text != "" && TBDataA.Text != "" && TBNume.Text != "" && TBSalariu.Text != "" && TBFunctia.Text != "")
            {
                Form1.Id_Ang = Convert.ToInt32(comboBox1.SelectedValue);
                Form1.A = new Angajat(TBNume.Text, Convert.ToDateTime(TBDataN.Text), Convert.ToDateTime(TBDataA.Text), Convert.ToInt32(TBSalariu.Text), TBFunctia.Text, Convert.ToInt32(CBIDDep.SelectedValue));
                DialogResult dr = MessageBox.Show("Datele sunt corecte!", "Modifica angajat?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    Form1.ok = 1;
                else
                    Form1.ok = 0;
                this.Close();
            }
            else
                MessageBox.Show("Date necompletate!");
        }
    }
}
