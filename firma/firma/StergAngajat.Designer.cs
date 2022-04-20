namespace firma
{
    partial class StergAngajat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaDataSet = new firma.firmaDataSet();
            this.angajatiTableAdapter = new firma.firmaDataSetTableAdapters.angajatiTableAdapter();
            this.TBNume = new System.Windows.Forms.TextBox();
            this.angajatiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TBDataA = new System.Windows.Forms.TextBox();
            this.TBSalariu = new System.Windows.Forms.TextBox();
            this.TBFunctia = new System.Windows.Forms.TextBox();
            this.TBDep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBDataN = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.angajatiBindingSource, "idang", true));
            this.comboBox1.DataSource = this.angajatiBindingSource;
            this.comboBox1.DisplayMember = "nume";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "idang";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "angajati";
            this.angajatiBindingSource.DataSource = this.firmaDataSet;
            // 
            // firmaDataSet
            // 
            this.firmaDataSet.DataSetName = "firmaDataSet";
            this.firmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // TBNume
            // 
            this.TBNume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource1, "datan", true));
            this.TBNume.Location = new System.Drawing.Point(99, 131);
            this.TBNume.Name = "TBNume";
            this.TBNume.ReadOnly = true;
            this.TBNume.Size = new System.Drawing.Size(121, 20);
            this.TBNume.TabIndex = 2;
            // 
            // angajatiBindingSource1
            // 
            this.angajatiBindingSource1.DataMember = "angajati";
            this.angajatiBindingSource1.DataSource = this.firmaDataSet;
            // 
            // TBDataA
            // 
            this.TBDataA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "dataa", true));
            this.TBDataA.Location = new System.Drawing.Point(99, 157);
            this.TBDataA.Name = "TBDataA";
            this.TBDataA.ReadOnly = true;
            this.TBDataA.Size = new System.Drawing.Size(121, 20);
            this.TBDataA.TabIndex = 3;
            // 
            // TBSalariu
            // 
            this.TBSalariu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource1, "salariu", true));
            this.TBSalariu.Location = new System.Drawing.Point(99, 183);
            this.TBSalariu.Name = "TBSalariu";
            this.TBSalariu.ReadOnly = true;
            this.TBSalariu.Size = new System.Drawing.Size(121, 20);
            this.TBSalariu.TabIndex = 4;
            // 
            // TBFunctia
            // 
            this.TBFunctia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "functia", true));
            this.TBFunctia.Location = new System.Drawing.Point(99, 209);
            this.TBFunctia.Name = "TBFunctia";
            this.TBFunctia.ReadOnly = true;
            this.TBFunctia.Size = new System.Drawing.Size(121, 20);
            this.TBFunctia.TabIndex = 5;
            // 
            // TBDep
            // 
            this.TBDep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "iddep", true));
            this.TBDep.Location = new System.Drawing.Point(99, 235);
            this.TBDep.Name = "TBDep";
            this.TBDep.ReadOnly = true;
            this.TBDep.Size = new System.Drawing.Size(121, 20);
            this.TBDep.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nume Angajat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id Departament";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Functia";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Salariu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data angajarii";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data nasterii";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Id_Angajat";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TBDataN
            // 
            this.TBDataN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "idang", true));
            this.TBDataN.Location = new System.Drawing.Point(99, 108);
            this.TBDataN.Name = "TBDataN";
            this.TBDataN.ReadOnly = true;
            this.TBDataN.Size = new System.Drawing.Size(121, 20);
            this.TBDataN.TabIndex = 14;
            this.TBDataN.TextChanged += new System.EventHandler(this.TBDataN_TextChanged);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(251, 62);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(101, 23);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "Sterge Angajat";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // StergAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 433);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.TBDataN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBDep);
            this.Controls.Add(this.TBFunctia);
            this.Controls.Add(this.TBSalariu);
            this.Controls.Add(this.TBDataA);
            this.Controls.Add(this.TBNume);
            this.Controls.Add(this.comboBox1);
            this.Name = "StergAngajat";
            this.Text = "te";
            this.Load += new System.EventHandler(this.StergAngajat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private firmaDataSet firmaDataSet;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private firmaDataSetTableAdapters.angajatiTableAdapter angajatiTableAdapter;
        private System.Windows.Forms.TextBox TBNume;
        private System.Windows.Forms.BindingSource angajatiBindingSource1;
        private System.Windows.Forms.TextBox TBDataA;
        private System.Windows.Forms.TextBox TBSalariu;
        private System.Windows.Forms.TextBox TBFunctia;
        private System.Windows.Forms.TextBox TBDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBDataN;
        private System.Windows.Forms.Button buttonDel;
    }
}