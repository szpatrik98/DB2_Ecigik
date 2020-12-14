using EcigikApp.Models.Manager;
using EcigikApp.Models.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EcigikApp
{
    public partial class Form1 : Form
    {
        EcigiTable TableManager;
        List<Ecigik> recordsEcigikList;
        BackgroundWorker bgWorker;


        public Form1()
        {
            InitializeComponent();
            TableManager = new EcigiTable();
            recordsEcigikList = new List<Ecigik>();
            bgWorker = new BackgroundWorker();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int toroltSorok = 0;
            foreach (DataGridViewRow selectedRows in dgwEcigik.SelectedRows)
            {
                Ecigik TorlendoRecord = new Ecigik();
                TorlendoRecord.Sorszam = selectedRows.Cells["sorszam"].Value.ToString();

                toroltSorok += TableManager.Delete(TorlendoRecord);
            }

            MessageBox.Show(string.Format("{0} Sor lett törölve.", toroltSorok));

            if (toroltSorok != 0)
            {
                bgWorker.RunWorkerAsync();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Ecigik ecigi = new Ecigik()
            {
                Sorszam = tbSorszam.Text,
                Nev = tbNev.Text,
                Szin = cbSzin.SelectedItem.ToString(),
                Gyarto = tbGyarto.Text,
                Watt = int.Parse(tbWatt.Text),
                Megjelenesev = dtp_MegjelenesEv.Value,
                Tipus = tbTipus.Text
            };
            TableManager.Insert(ecigi);
            bgWorker.RunWorkerAsync();

            MessageBox.Show("Sikeres feltöltés.");
            tbSorszam.Clear();
            tbNev.Clear();
            tbGyarto.Clear();
            tbWatt.Clear();
            tbTipus.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;

            dtp_MegjelenesEv.CustomFormat = "YYYY";
            dtp_MegjelenesEv.ShowUpDown = true;

            cbSzin.DataSource = Enum.GetValues(typeof(Szin));

            InitDataGridView();
        }

        private void InitDataGridView()
        {
            dgwEcigik.Rows.Clear();
            dgwEcigik.Columns.Clear();

            DataGridViewColumn sorszamColumn = new DataGridViewColumn()
            {
                Name = "sorszam",
                HeaderText = "Sorszam",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };

            dgwEcigik.Columns.Add(sorszamColumn);

            DataGridViewColumn nevColumn = new DataGridViewColumn()
            {
                Name = "nev",
                HeaderText = "nev",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };

            dgwEcigik.Columns.Add(nevColumn);

            DataGridViewColumn szinColumn = new DataGridViewColumn()
            {
                Name = "szin",
                HeaderText = "szin",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };

            dgwEcigik.Columns.Add(szinColumn);

            DataGridViewColumn gyartoColumn = new DataGridViewColumn()
            {
                Name = "gyarto",
                HeaderText = "gyarto",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };

            dgwEcigik.Columns.Add(gyartoColumn);

            DataGridViewColumn wattColumn = new DataGridViewColumn()
            {
                Name = "watt",
                HeaderText = "watt",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };

            dgwEcigik.Columns.Add(wattColumn);

            DataGridViewColumn megjelenesevColumn = new DataGridViewColumn()
            {
                Name = "megjelenesev",
                HeaderText = "megjelenesev",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };

            dgwEcigik.Columns.Add(megjelenesevColumn);

            DataGridViewColumn tipusColumn = new DataGridViewColumn()
            {
                Name = "tipus",
                HeaderText = "tipus",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            };

            dgwEcigik.Columns.Add(tipusColumn);


        }

        private void bgWroker_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            FillDataGridView();
        }

        private void bgWroker_DoWork(object sender, DoWorkEventArgs e)
        {
            recordsEcigikList = TableManager.Select();
        }

        private void FillDataGridView()
        {
            DataGridViewRow[] dataGridViewRows = new DataGridViewRow[recordsEcigikList.Count];

            for (int i = 0; i < recordsEcigikList.Count; i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();

                DataGridViewCell sorszamCell = new DataGridViewTextBoxCell();
                sorszamCell.Value = recordsEcigikList[i].Sorszam;
                dataGridViewRow.Cells.Add(sorszamCell);

                DataGridViewCell nevCell = new DataGridViewTextBoxCell();
                sorszamCell.Value = recordsEcigikList[i].Nev;
                dataGridViewRow.Cells.Add(nevCell);

                DataGridViewCell szinCell = new DataGridViewTextBoxCell();
                sorszamCell.Value = recordsEcigikList[i].Szin;
                dataGridViewRow.Cells.Add(szinCell);

                DataGridViewCell gyartoCell = new DataGridViewTextBoxCell();
                sorszamCell.Value = recordsEcigikList[i].Gyarto;
                dataGridViewRow.Cells.Add(gyartoCell);

                DataGridViewCell wattCell = new DataGridViewTextBoxCell();
                sorszamCell.Value = recordsEcigikList[i].Watt;
                dataGridViewRow.Cells.Add(wattCell);

                DataGridViewCell megjelenesevCell = new DataGridViewTextBoxCell();
                sorszamCell.Value = recordsEcigikList[i].Megjelenesev;
                dataGridViewRow.Cells.Add(megjelenesevCell);

                DataGridViewCell tipusCell = new DataGridViewTextBoxCell();
                sorszamCell.Value = recordsEcigikList[i].Tipus;
                dataGridViewRow.Cells.Add(tipusCell);
            }
        }


    }
}
