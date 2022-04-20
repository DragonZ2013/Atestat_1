namespace firma
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.angajatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareAngajatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareDepartamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.angajatiToolStripMenuItem,
            this.departamenteToolStripMenuItem,
            this.vizualizariToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // angajatiToolStripMenuItem
            // 
            this.angajatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.stergereToolStripMenuItem,
            this.modificareToolStripMenuItem});
            this.angajatiToolStripMenuItem.Name = "angajatiToolStripMenuItem";
            this.angajatiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.angajatiToolStripMenuItem.Text = "Angajati";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem_Click);
            // 
            // departamenteToolStripMenuItem
            // 
            this.departamenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem1,
            this.stergereToolStripMenuItem1});
            this.departamenteToolStripMenuItem.Name = "departamenteToolStripMenuItem";
            this.departamenteToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.departamenteToolStripMenuItem.Text = "Departamente";
            // 
            // adaugareToolStripMenuItem1
            // 
            this.adaugareToolStripMenuItem1.Name = "adaugareToolStripMenuItem1";
            this.adaugareToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.adaugareToolStripMenuItem1.Text = "Adaugare";
            this.adaugareToolStripMenuItem1.Click += new System.EventHandler(this.adaugareToolStripMenuItem1_Click);
            // 
            // stergereToolStripMenuItem1
            // 
            this.stergereToolStripMenuItem1.Name = "stergereToolStripMenuItem1";
            this.stergereToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.stergereToolStripMenuItem1.Text = "Stergere";
            // 
            // vizualizariToolStripMenuItem
            // 
            this.vizualizariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareAngajatiToolStripMenuItem,
            this.afisareDepartamenteToolStripMenuItem});
            this.vizualizariToolStripMenuItem.Name = "vizualizariToolStripMenuItem";
            this.vizualizariToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.vizualizariToolStripMenuItem.Text = "Vizualizari";
            // 
            // afisareAngajatiToolStripMenuItem
            // 
            this.afisareAngajatiToolStripMenuItem.Name = "afisareAngajatiToolStripMenuItem";
            this.afisareAngajatiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.afisareAngajatiToolStripMenuItem.Text = "Afisare Angajati";
            this.afisareAngajatiToolStripMenuItem.Click += new System.EventHandler(this.afisareAngajatiToolStripMenuItem_Click);
            // 
            // afisareDepartamenteToolStripMenuItem
            // 
            this.afisareDepartamenteToolStripMenuItem.Name = "afisareDepartamenteToolStripMenuItem";
            this.afisareDepartamenteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.afisareDepartamenteToolStripMenuItem.Text = "Afisare Departamente";
            this.afisareDepartamenteToolStripMenuItem.Click += new System.EventHandler(this.afisareDepartamenteToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 320);
            this.dataGridView1.TabIndex = 1;
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificareToolStripMenuItem.Text = "Modificare";
            this.modificareToolStripMenuItem.Click += new System.EventHandler(this.modificareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 468);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem angajatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vizualizariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareAngajatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareDepartamenteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
    }
}

