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
    public partial class StergAngajat : Form
    {
        public StergAngajat()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StergAngajat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmaDataSet.angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.firmaDataSet.angajati);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TBDataN_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Sunteti sigur ca stergeti angajatul?", "Sterge angajat", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Form1.ok = 1;
                Form1.Id_Ang = Convert.ToInt32(comboBox1.SelectedValue);
            }
            else
                Form1.ok = 0;
            this.Close();
        }
    }
}
