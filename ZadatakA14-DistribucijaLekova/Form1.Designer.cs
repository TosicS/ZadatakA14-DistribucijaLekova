namespace ZadatakA14_DistribucijaLekova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBrisi = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnaliza = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOAplikaciji = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIzadji = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNazivLeka = new System.Windows.Forms.TextBox();
            this.textBoxProizvodjac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBrisi,
            this.toolStripButtonAnaliza,
            this.toolStripButtonOAplikaciji,
            this.toolStripButtonIzadji});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBrisi
            // 
            this.toolStripButtonBrisi.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBrisi.Image")));
            this.toolStripButtonBrisi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBrisi.Name = "toolStripButtonBrisi";
            this.toolStripButtonBrisi.Size = new System.Drawing.Size(44, 59);
            this.toolStripButtonBrisi.Text = "Brisi";
            this.toolStripButtonBrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonBrisi.Click += new System.EventHandler(this.toolStripButtonBrisi_Click);
            // 
            // toolStripButtonAnaliza
            // 
            this.toolStripButtonAnaliza.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAnaliza.Image")));
            this.toolStripButtonAnaliza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnaliza.Name = "toolStripButtonAnaliza";
            this.toolStripButtonAnaliza.Size = new System.Drawing.Size(49, 59);
            this.toolStripButtonAnaliza.Text = "Analiza";
            this.toolStripButtonAnaliza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAnaliza.Click += new System.EventHandler(this.toolStripButtonAnaliza_Click);
            // 
            // toolStripButtonOAplikaciji
            // 
            this.toolStripButtonOAplikaciji.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOAplikaciji.Image")));
            this.toolStripButtonOAplikaciji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOAplikaciji.Name = "toolStripButtonOAplikaciji";
            this.toolStripButtonOAplikaciji.Size = new System.Drawing.Size(69, 59);
            this.toolStripButtonOAplikaciji.Text = "O aplikaciji";
            this.toolStripButtonOAplikaciji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonOAplikaciji.Click += new System.EventHandler(this.toolStripButtonOAplikaciji_Click);
            // 
            // toolStripButtonIzadji
            // 
            this.toolStripButtonIzadji.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIzadji.Image")));
            this.toolStripButtonIzadji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIzadji.Name = "toolStripButtonIzadji";
            this.toolStripButtonIzadji.Size = new System.Drawing.Size(44, 59);
            this.toolStripButtonIzadji.Text = "Izadji";
            this.toolStripButtonIzadji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonIzadji.Click += new System.EventHandler(this.toolStripButtonIzadji_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brisanje izabranog leka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv leka";
            // 
            // textBoxNazivLeka
            // 
            this.textBoxNazivLeka.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxNazivLeka.Location = new System.Drawing.Point(181, 159);
            this.textBoxNazivLeka.Name = "textBoxNazivLeka";
            this.textBoxNazivLeka.ReadOnly = true;
            this.textBoxNazivLeka.Size = new System.Drawing.Size(123, 20);
            this.textBoxNazivLeka.TabIndex = 3;
            // 
            // textBoxProizvodjac
            // 
            this.textBoxProizvodjac.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxProizvodjac.Location = new System.Drawing.Point(471, 159);
            this.textBoxProizvodjac.Name = "textBoxProizvodjac";
            this.textBoxProizvodjac.ReadOnly = true;
            this.textBoxProizvodjac.Size = new System.Drawing.Size(123, 20);
            this.textBoxProizvodjac.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Proizvodjac";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(725, 186);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxProizvodjac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNazivLeka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Lek-Proizvodjac";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBrisi;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnaliza;
        private System.Windows.Forms.ToolStripButton toolStripButtonOAplikaciji;
        private System.Windows.Forms.ToolStripButton toolStripButtonIzadji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNazivLeka;
        private System.Windows.Forms.TextBox textBoxProizvodjac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

