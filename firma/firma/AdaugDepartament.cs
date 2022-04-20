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
    public partial class AdaugDepartament : Form
    {
        public AdaugDepartament()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.D = new Departament();
            if (textBox1.Text != "")
            {
                Form1.D = new Departament(textBox1.Text);
                DialogResult dr = MessageBox.Show("Datele sunt corecte!", "Adauga angajat?", MessageBoxButtons.YesNo);
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
