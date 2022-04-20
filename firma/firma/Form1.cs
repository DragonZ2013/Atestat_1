using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace firma
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public static Angajat A;
        public static int ok;
        public static Departament D;
        public static int Id_Ang;


        void afisare(String s)
        {
            cmd = new SqlCommand(s, con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        
        }

        public Form1()
        {
            InitializeComponent();

            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\firma.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void afisareAngajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
                afisare("SELECT * FROM angajati");
        }

        private void afisareDepartamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
                afisare("SELECT * FROM departamente");
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugAngajat f = new AdaugAngajat();
            f.ShowDialog();
            if (ok == 1)
            {
                string s = @"INSERT INTO angajati (nume,datan,dataa,salariu,functia,iddep) VALUES('"+A.nume+"','"+A.datan+"','"+A.dataa+"',"+A.salariu+",'"+A.functia+"',"+A.iddep+")";
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datele au fost adaugate!");
            }
        }

        private void adaugareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdaugDepartament f = new AdaugDepartament();
            f.ShowDialog();
            if (ok == 1)
            {
                string s = @"INSERT INTO departamente (numedep) VALUES('" + D.nume + "')";
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datele au fost adaugate!");
            }
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StergAngajat f = new StergAngajat();
            f.ShowDialog();
            if (ok == 1)
            {
                string s = "DELETE FROM angajati WHERE idang=" + Id_Ang;
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                afisare("SELECT * FROM angajati");
            }

        }

        private void modificareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifAngajat f = new ModifAngajat();
            f.ShowDialog();
            if (ok == 1)
            { 
                
                string s = "UPDATE angajati SET nume = '"+A.nume+"', datan = '"+A.datan+"', dataa = '"+A.dataa+"', salariu= " + A.salariu + ", functia='"+A.functia+"', iddep="+A.iddep+"WHERE idang="+ Id_Ang;
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
                afisare("SELECT * FROM angajati");
            }
        }
    }
}
