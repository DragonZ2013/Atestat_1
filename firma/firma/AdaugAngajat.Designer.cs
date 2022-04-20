namespace firma
{
    partial class AdaugAngajat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumeTB = new System.Windows.Forms.TextBox();
            this.DataNTB = new System.Windows.Forms.TextBox();
            this.DataATB = new System.Windows.Forms.TextBox();
            this.SalariuTB = new System.Windows.Forms.TextBox();
            this.FunctiaTB = new System.Windows.Forms.TextBox();
            this.IDDepCB = new System.Windows.Forms.ComboBox();
            this.departamenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaDataSet = new firma.firmaDataSet();
            this.departamenteTableAdapter = new firma.firmaDataSetTableAdapters.departamenteTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data nasterii";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data angajarii";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salariu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Functia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id Departament";
            // 
            // NumeTB
            // 
            this.NumeTB.Location = new System.Drawing.Point(177, 62);
            this.NumeTB.Name = "NumeTB";
            this.NumeTB.Size = new System.Drawing.Size(100, 20);
            this.NumeTB.TabIndex = 6;
            this.NumeTB.TextChanged += new System.EventHandler(this.NumeTB_TextChanged);
            // 
            // DataNTB
            // 
            this.DataNTB.Location = new System.Drawing.Point(177, 91);
            this.DataNTB.Name = "DataNTB";
            this.DataNTB.Size = new System.Drawing.Size(100, 20);
            this.DataNTB.TabIndex = 7;
            // 
            // DataATB
            // 
            this.DataATB.Location = new System.Drawing.Point(177, 117);
            this.DataATB.Name = "DataATB";
            this.DataATB.Size = new System.Drawing.Size(100, 20);
            this.DataATB.TabIndex = 8;
            // 
            // SalariuTB
            // 
            this.SalariuTB.Location = new System.Drawing.Point(177, 157);
            this.SalariuTB.Name = "SalariuTB";
            this.SalariuTB.Size = new System.Drawing.Size(100, 20);
            this.SalariuTB.TabIndex = 9;
            // 
            // FunctiaTB
            // 
            this.FunctiaTB.Location = new System.Drawing.Point(177, 195);
            this.FunctiaTB.Name = "FunctiaTB";
            this.FunctiaTB.Size = new System.Drawing.Size(100, 20);
            this.FunctiaTB.TabIndex = 10;
            // 
            // IDDepCB
            // 
            this.IDDepCB.DataSource = this.departamenteBindingSource;
            this.IDDepCB.DisplayMember = "numedep";
            this.IDDepCB.FormattingEnabled = true;
            this.IDDepCB.Location = new System.Drawing.Point(177, 228);
            this.IDDepCB.Name = "IDDepCB";
            this.IDDepCB.Size = new System.Drawing.Size(121, 21);
            this.IDDepCB.TabIndex = 11;
            this.IDDepCB.ValueMember = "iddep";
            // 
            // departamenteBindingSource
            // 
            this.departamenteBindingSource.DataMember = "departamente";
            this.departamenteBindingSource.DataSource = this.firmaDataSet;
            // 
            // firmaDataSet
            // 
            this.firmaDataSet.DataSetName = "firmaDataSet";
            this.firmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamenteTableAdapter
            // 
            this.departamenteTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 66);
            this.button1.TabIndex = 12;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdaugAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDDepCB);
            this.Controls.Add(this.FunctiaTB);
            this.Controls.Add(this.SalariuTB);
            this.Controls.Add(this.DataATB);
            this.Controls.Add(this.DataNTB);
            this.Controls.Add(this.NumeTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugAngajat";
            this.Text = "AdaugAngajat";
            this.Load += new System.EventHandler(this.AdaugAngajat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departamenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumeTB;
        private System.Windows.Forms.TextBox DataNTB;
        private System.Windows.Forms.TextBox DataATB;
        private System.Windows.Forms.TextBox SalariuTB;
        private System.Windows.Forms.TextBox FunctiaTB;
        private System.Windows.Forms.ComboBox IDDepCB;
        private firmaDataSet firmaDataSet;
        private System.Windows.Forms.BindingSource departamenteBindingSource;
        private firmaDataSetTableAdapters.departamenteTableAdapter departamenteTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}