namespace Haromszogek
{
    partial class frmFo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAoldal = new System.Windows.Forms.TextBox();
            this.tbBoldal = new System.Windows.Forms.TextBox();
            this.tbColdal = new System.Windows.Forms.TextBox();
            this.btn_kilepes = new System.Windows.Forms.Button();
            this.btn_szamol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHarmszogLista = new System.Windows.Forms.ListBox();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnFajlbol = new System.Windows.Forms.Button();
            this.ofdMegnyitas = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A háromszög oldalai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "C:";
            // 
            // tbAoldal
            // 
            this.tbAoldal.Location = new System.Drawing.Point(39, 40);
            this.tbAoldal.Name = "tbAoldal";
            this.tbAoldal.Size = new System.Drawing.Size(100, 29);
            this.tbAoldal.TabIndex = 4;
            // 
            // tbBoldal
            // 
            this.tbBoldal.Location = new System.Drawing.Point(40, 75);
            this.tbBoldal.Name = "tbBoldal";
            this.tbBoldal.Size = new System.Drawing.Size(100, 29);
            this.tbBoldal.TabIndex = 5;
            // 
            // tbColdal
            // 
            this.tbColdal.Location = new System.Drawing.Point(41, 111);
            this.tbColdal.Name = "tbColdal";
            this.tbColdal.Size = new System.Drawing.Size(100, 29);
            this.tbColdal.TabIndex = 6;
            // 
            // btn_kilepes
            // 
            this.btn_kilepes.Location = new System.Drawing.Point(23, 270);
            this.btn_kilepes.Name = "btn_kilepes";
            this.btn_kilepes.Size = new System.Drawing.Size(75, 30);
            this.btn_kilepes.TabIndex = 7;
            this.btn_kilepes.Text = "Kilépés";
            this.btn_kilepes.UseVisualStyleBackColor = true;
            this.btn_kilepes.Click += new System.EventHandler(this.btn_kilepes_Click);
            // 
            // btn_szamol
            // 
            this.btn_szamol.Location = new System.Drawing.Point(224, 74);
            this.btn_szamol.Name = "btn_szamol";
            this.btn_szamol.Size = new System.Drawing.Size(95, 30);
            this.btn_szamol.TabIndex = 8;
            this.btn_szamol.Text = "Számolás";
            this.btn_szamol.UseVisualStyleBackColor = true;
            this.btn_szamol.Click += new System.EventHandler(this.btn_szamol_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_szamol);
            this.panel1.Controls.Add(this.tbColdal);
            this.panel1.Controls.Add(this.tbBoldal);
            this.panel1.Controls.Add(this.tbAoldal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 167);
            this.panel1.TabIndex = 9;
            // 
            // lbHarmszogLista
            // 
            this.lbHarmszogLista.FormattingEnabled = true;
            this.lbHarmszogLista.ItemHeight = 20;
            this.lbHarmszogLista.Location = new System.Drawing.Point(363, 106);
            this.lbHarmszogLista.Name = "lbHarmszogLista";
            this.lbHarmszogLista.Size = new System.Drawing.Size(233, 224);
            this.lbHarmszogLista.TabIndex = 10;
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(433, 40);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 35);
            this.btnTorol.TabIndex = 11;
            this.btnTorol.Text = "Törlés";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnFajlbol
            // 
            this.btnFajlbol.Location = new System.Drawing.Point(22, 209);
            this.btnFajlbol.Name = "btnFajlbol";
            this.btnFajlbol.Size = new System.Drawing.Size(75, 30);
            this.btnFajlbol.TabIndex = 12;
            this.btnFajlbol.Text = "Fájlból";
            this.btnFajlbol.UseVisualStyleBackColor = true;
            this.btnFajlbol.Click += new System.EventHandler(this.btnFajlbol_Click);
            // 
            // ofdMegnyitas
            // 
            this.ofdMegnyitas.FileName = "openFileDialog1";
            this.ofdMegnyitas.Filter = "TextFiles|*.txt";
            this.ofdMegnyitas.InitialDirectory = "C:\\Users\\c16MAKKAIP\\source\\repos\\Haromszogek\\Haromszogek\\bin\\Debug";
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(608, 361);
            this.Controls.Add(this.btnFajlbol);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.lbHarmszogLista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_kilepes);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haromszog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAoldal;
        private System.Windows.Forms.TextBox tbBoldal;
        private System.Windows.Forms.TextBox tbColdal;
        private System.Windows.Forms.Button btn_kilepes;
        private System.Windows.Forms.Button btn_szamol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbHarmszogLista;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnFajlbol;
        private System.Windows.Forms.OpenFileDialog ofdMegnyitas;
    }
}

