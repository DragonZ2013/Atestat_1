namespace firma
{
    partial class ModifAngajat
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
            this.TBNume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBFunctia = new System.Windows.Forms.TextBox();
            this.TBSalariu = new System.Windows.Forms.TextBox();
            this.TBDataA = new System.Windows.Forms.TextBox();
            this.TBDataN = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.firmaDataSet = new firma.firmaDataSet();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angajatiTableAdapter = new firma.firmaDataSetTableAdapters.angajatiTableAdapter();
            this.buttonModif = new System.Windows.Forms.Button();
            this.CBIDDep = new System.Windows.Forms.ComboBox();
            this.departamenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamenteTableAdapter = new firma.firmaDataSetTableAdapters.departamenteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TBNume
            // 
            this.TBNume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "nume", true));
            this.TBNume.Location = new System.Drawing.Point(98, 88);
            this.TBNume.Name = "TBNume";
            this.TBNume.Size = new System.Drawing.Size(121, 20);
            this.TBNume.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Departament";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Functia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Salariu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Data angajarii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Data nasterii";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID Angajat";
            // 
            // TBFunctia
            // 
            this.TBFunctia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "functia", true));
            this.TBFunctia.Location = new System.Drawing.Point(98, 189);
            this.TBFunctia.Name = "TBFunctia";
            this.TBFunctia.Size = new System.Drawing.Size(121, 20);
            this.TBFunctia.TabIndex = 19;
            // 
            // TBSalariu
            // 
            this.TBSalariu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "salariu", true));
            this.TBSalariu.Location = new System.Drawing.Point(98, 163);
            this.TBSalariu.Name = "TBSalariu";
            this.TBSalariu.Size = new System.Drawing.Size(121, 20);
            this.TBSalariu.TabIndex = 18;
            // 
            // TBDataA
            // 
            this.TBDataA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "dataa", true));
            this.TBDataA.Location = new System.Drawing.Point(98, 137);
            this.TBDataA.Name = "TBDataA";
            this.TBDataA.Size = new System.Drawing.Size(121, 20);
            this.TBDataA.TabIndex = 17;
            // 
            // TBDataN
            // 
            this.TBDataN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.angajatiBindingSource, "datan", true));
            this.TBDataN.Location = new System.Drawing.Point(98, 111);
            this.TBDataN.Name = "TBDataN";
            this.TBDataN.Size = new System.Drawing.Size(121, 20);
            this.TBDataN.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.angajatiBindingSource, "idang", true));
            this.comboBox1.DataSource = this.angajatiBindingSource;
            this.comboBox1.DisplayMember = "idang";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "idang";
            // 
            // firmaDataSet
            // 
            this.firmaDataSet.DataSetName = "firmaDataSet";
            this.firmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "angajati";
            this.angajatiBindingSource.DataSource = this.firmaDataSet;
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // buttonModif
            // 
            this.buttonModif.Location = new System.Drawing.Point(252, 42);
            this.buttonModif.Name = "buttonModif";
            this.buttonModif.Size = new System.Drawing.Size(111, 23);
            this.buttonModif.TabIndex = 29;
            this.buttonModif.Text = "Modifica Angajat";
            this.buttonModif.UseVisualStyleBackColor = true;
            this.buttonModif.Click += new System.EventHandler(this.buttonModif_Click);
            // 
            // CBIDDep
            // 
            this.CBIDDep.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.angajatiBindingSource, "iddep", true));
            this.CBIDDep.DataSource = this.departamenteBindingSource;
            this.CBIDDep.DisplayMember = "numedep";
            this.CBIDDep.FormattingEnabled = true;
            this.CBIDDep.Location = new System.Drawing.Point(98, 218);
            this.CBIDDep.Name = "CBIDDep";
            this.CBIDDep.Size = new System.Drawing.Size(121, 21);
            this.CBIDDep.TabIndex = 30;
            this.CBIDDep.ValueMember = "iddep";
            // 
            // departamenteBindingSource
            // 
            this.departamenteBindingSource.DataMember = "departamente";
            this.departamenteBindingSource.DataSource = this.firmaDataSet;
            // 
            // departamenteTableAdapter
            // 
            this.departamenteTableAdapter.ClearBeforeFill = true;
            // 
            // ModifAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 391);
            this.Controls.Add(this.CBIDDep);
            this.Controls.Add(this.buttonModif);
            this.Controls.Add(this.TBNume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBFunctia);
            this.Controls.Add(this.TBSalariu);
            this.Controls.Add(this.TBDataA);
            this.Controls.Add(this.TBDataN);
            this.Controls.Add(this.comboBox1);
            this.Name = "ModifAngajat";
            this.Text = "ModifAngajat";
            this.Load += new System.EventHandler(this.ModifAngajat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBFunctia;
        private System.Windows.Forms.TextBox TBSalariu;
        private System.Windows.Forms.TextBox TBDataA;
        private System.Windows.Forms.TextBox TBDataN;
        private System.Windows.Forms.ComboBox comboBox1;
        private firmaDataSet firmaDataSet;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private firmaDataSetTableAdapters.angajatiTableAdapter angajatiTableAdapter;
        private System.Windows.Forms.Button buttonModif;
        private System.Windows.Forms.ComboBox CBIDDep;
        private System.Windows.Forms.BindingSource departamenteBindingSource;
        private firmaDataSetTableAdapters.departamenteTableAdapter departamenteTableAdapter;
    }
}