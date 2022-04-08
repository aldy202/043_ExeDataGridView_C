using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_grid_view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            dataGridView1.Columns[0].HeaderText = "No. Mahasiswa";
            dataGridView1.Columns[1].HeaderText = "Nama Mahasiswa";
            dataGridView1.Columns[2].HeaderText = "Alamat Mahasiwa";
            dataGridView1.Columns[3].HeaderText = "Jenis Kelamin";
            dataGridView1.Columns[4].HeaderText = "No. Telepon";

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);

            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.FromArgb(77,208,225);
            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.FromArgb(129,199,132);
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.FromArgb(191,54,12);
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 98, 146);
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 87, 34);
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 125, 50);
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.FromArgb(25, 118, 210);
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.FromArgb(183, 28, 28);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
