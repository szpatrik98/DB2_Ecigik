namespace EcigikApp
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
            this.dgwEcigik = new System.Windows.Forms.DataGridView();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbWatt = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtp_MegjelenesEv = new System.Windows.Forms.DateTimePicker();
            this.cbSzin = new System.Windows.Forms.ComboBox();
            this.tbSorszam = new System.Windows.Forms.TextBox();
            this.tbGyarto = new System.Windows.Forms.TextBox();
            this.tbTipus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEcigik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwEcigik
            // 
            this.dgwEcigik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEcigik.Location = new System.Drawing.Point(12, 12);
            this.dgwEcigik.Name = "dgwEcigik";
            this.dgwEcigik.RowHeadersWidth = 51;
            this.dgwEcigik.RowTemplate.Height = 24;
            this.dgwEcigik.Size = new System.Drawing.Size(1247, 390);
            this.dgwEcigik.TabIndex = 0;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(338, 410);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(320, 22);
            this.tbNev.TabIndex = 1;
            this.tbNev.Text = "Nev";
            this.tbNev.Leave += new System.EventHandler(this.tb_Nev_Leave);
            // 
            // tbWatt
            // 
            this.tbWatt.Location = new System.Drawing.Point(12, 438);
            this.tbWatt.Name = "tbWatt";
            this.tbWatt.Size = new System.Drawing.Size(320, 22);
            this.tbWatt.TabIndex = 3;
            this.tbWatt.Text = "Watt";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1051, 418);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(148, 63);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1051, 515);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 63);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtp_MegjelenesEv
            // 
            this.dtp_MegjelenesEv.Location = new System.Drawing.Point(6, 475);
            this.dtp_MegjelenesEv.Name = "dtp_MegjelenesEv";
            this.dtp_MegjelenesEv.Size = new System.Drawing.Size(326, 22);
            this.dtp_MegjelenesEv.TabIndex = 8;
            // 
            // cbSzin
            // 
            this.cbSzin.FormattingEnabled = true;
            this.cbSzin.Location = new System.Drawing.Point(701, 440);
            this.cbSzin.Name = "cbSzin";
            this.cbSzin.Size = new System.Drawing.Size(305, 24);
            this.cbSzin.TabIndex = 9;
            this.cbSzin.Text = "Szín";
            // 
            // tbSorszam
            // 
            this.tbSorszam.Location = new System.Drawing.Point(12, 408);
            this.tbSorszam.Name = "tbSorszam";
            this.tbSorszam.Size = new System.Drawing.Size(320, 22);
            this.tbSorszam.TabIndex = 11;
            this.tbSorszam.Text = "Sorszam";
            this.tbSorszam.Leave += new System.EventHandler(this.tb_Sorszam_Leave);
            // 
            // tbGyarto
            // 
            this.tbGyarto.Location = new System.Drawing.Point(701, 410);
            this.tbGyarto.Name = "tbGyarto";
            this.tbGyarto.Size = new System.Drawing.Size(320, 22);
            this.tbGyarto.TabIndex = 12;
            this.tbGyarto.Text = "Gyarto";
            // 
            // tbTipus
            // 
            this.tbTipus.Location = new System.Drawing.Point(338, 440);
            this.tbTipus.Name = "tbTipus";
            this.tbTipus.Size = new System.Drawing.Size(320, 22);
            this.tbTipus.TabIndex = 13;
            this.tbTipus.Text = "Tipus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 603);
            this.Controls.Add(this.tbTipus);
            this.Controls.Add(this.tbGyarto);
            this.Controls.Add(this.tbSorszam);
            this.Controls.Add(this.cbSzin);
            this.Controls.Add(this.dtp_MegjelenesEv);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbWatt);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.dgwEcigik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEcigik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEcigik;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbWatt;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtp_MegjelenesEv;
        private System.Windows.Forms.ComboBox cbSzin;
        private System.Windows.Forms.TextBox tbSorszam;
        private System.Windows.Forms.TextBox tbGyarto;
        private System.Windows.Forms.TextBox tbTipus;
    }
}

