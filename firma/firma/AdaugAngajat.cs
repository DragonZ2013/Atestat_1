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
    public partial class AdaugAngajat : Form
    {
        public AdaugAngajat()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AdaugAngajat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmaDataSet.departamente' table. You can move, or remove it, as needed.
            this.departamenteTableAdapter.Fill(this.firmaDataSet.departamente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.A = new Angajat();
            if (NumeTB.Text != "" && DataATB.Text != "" && DataNTB.Text != "" && SalariuTB.Text != "" && FunctiaTB.Text != "")
            {
                Form1.A = new Angajat(NumeTB.Text, Convert.ToDateTime(DataNTB.Text), Convert.ToDateTime(DataATB.Text), Convert.ToInt32(SalariuTB.Text), FunctiaTB.Text, Convert.ToInt32(IDDepCB.SelectedValue));
                DialogResult dr = MessageBox.Show("Datele sunt corecte!","Adauga angajat?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    Form1.ok = 1;
                else
                    Form1.ok = 0;
                this.Close();
            }
            else
                MessageBox.Show("Date necompletate!");
        }

        private void NumeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }  
    }
}
