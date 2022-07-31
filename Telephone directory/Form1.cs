using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Telephone_directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-D0LP1EG;Initial Catalog=Rehber;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rehberDataSet.TBLKISILER' table. You can move, or remove it, as needed.
            this.tBLKISILERTableAdapter.Fill(this.rehberDataSet.TBLKISILER);

        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kaydet = new SqlCommand("insert into TBLKISILER (AD,SOYAD,TELEFON,MAIL) VALUES (@P1,@P2,@P3,@P4)", baglanti);
            kaydet.Parameters.AddWithValue("@P1", TXTAD.Text);
            kaydet.Parameters.AddWithValue("@P2", TXTSOYAD.Text);
            kaydet.Parameters.AddWithValue("@P3", MSKTEL.Text);
            kaydet.Parameters.AddWithValue("@P4", TXTMAIL.Text);
            kaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KİŞİ EKLENDİ");
            this.tBLKISILERTableAdapter.Fill(this.rehberDataSet.TBLKISILER);
        }

        private void BTNSIL_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From TBLKISILER Where ID=@K1", baglanti);
            sil.Parameters.AddWithValue("@K1", TXTID.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
            this.tBLKISILERTableAdapter.Fill(this.rehberDataSet.TBLKISILER);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TXTID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TXTAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TXTSOYAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MSKTEL.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TXTMAIL.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        

        private void BTNGUNCELLE_Click(object sender, EventArgs e)
        {

        }
    }
}
