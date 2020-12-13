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
            this.tbSzin = new System.Windows.Forms.TextBox();
            this.tbWatt = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbTipus = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
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
            this.tbNev.Location = new System.Drawing.Point(13, 419);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(320, 22);
            this.tbNev.TabIndex = 1;
            // 
            // tbSzin
            // 
            this.tbSzin.Location = new System.Drawing.Point(12, 457);
            this.tbSzin.Name = "tbSzin";
            this.tbSzin.Size = new System.Drawing.Size(320, 22);
            this.tbSzin.TabIndex = 2;
            // 
            // tbWatt
            // 
            this.tbWatt.Location = new System.Drawing.Point(12, 496);
            this.tbWatt.Name = "tbWatt";
            this.tbWatt.Size = new System.Drawing.Size(320, 22);
            this.tbWatt.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(383, 455);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(148, 63);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(567, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 63);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(873, 428);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(326, 22);
            this.dateTimePicker.TabIndex = 8;
            // 
            // cbTipus
            // 
            this.cbTipus.FormattingEnabled = true;
            this.cbTipus.Location = new System.Drawing.Point(873, 482);
            this.cbTipus.Name = "cbTipus";
            this.cbTipus.Size = new System.Drawing.Size(305, 24);
            this.cbTipus.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(748, 455);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 63);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 549);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbTipus);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbWatt);
            this.Controls.Add(this.tbSzin);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.dgwEcigik);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwEcigik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEcigik;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbSzin;
        private System.Windows.Forms.TextBox tbWatt;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cbTipus;
        private System.Windows.Forms.Button btnRefresh;
    }
}

