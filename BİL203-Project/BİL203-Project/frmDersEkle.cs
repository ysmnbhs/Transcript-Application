using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BİL203_Project
{
    // private NpgsqlConnection conn = new("server=localhost ; port=5432; Database=bil203; user ID=postgres; password=Yakamoz.21");
    public partial class frmDersEkle : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localhost ; port=5432; Database=bil203; user ID=postgres; password=Yakamoz.21");
        public void DataGridviewSetting(DataGridView datagridview)
        {
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public frmDersEkle()
        {
            InitializeComponent();
        }
        public void kayıtlarıgetir(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtgwMevcut.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();

        }
        public void txtDersEkle_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost ; port=5432; Database=bil203; user ID=postgres; password=Yakamoz.21");

            conn.Open();

            //NpgsqlCommand komutEkle = new NpgsqlCommand("insert into bil203 (derskodu,dersadı,kredi,öğretimüyesi,dönem,harfnotu) values (@DERS_KODU,@DERS_ADI,@KREDİ,@ÖĞRETİM_ÜYESİ,@DÖNEM,@HARF_NOTU)", conn);
            NpgsqlCommand komutEkle = new NpgsqlCommand("insert into bil203(derskodu, dersadı, kredi, öğretimüyesi, dönem, harfnotu) values(@DERS_KODU, @DERS_ADI, @KREDİ, @ÖĞRETİM_ÜYESİ, @DÖNEM, @HARF_NOTU");
            komutEkle.Connection = conn;
            NpgsqlCommand sorgu = new NpgsqlCommand();
            //sorgu.CommandText = "INSERT INTO  DERS  VALUES (@DERS_KODU,@DERS_ADI,@KREDİ,@ÖĞRETİM_ÜYESİ,@DÖNEM,@HARF_NOTU);";
            komutEkle.Parameters.AddWithValue("@DERS_KODU", txtNewDersKodu.Text);
            komutEkle.Parameters.AddWithValue("@DERS_ADI", txtNewDersAdi.Text);
            komutEkle.Parameters.AddWithValue("@KREDİ", Convert.ToDouble(txtNewKredi.Text));
            komutEkle.Parameters.AddWithValue("@ÖĞRETİM_ÜYESİ", txtNewOgrUyesi.Text);
            komutEkle.Parameters.AddWithValue("@DÖNEM", cmbNewDonem.Text);
            komutEkle.Parameters.AddWithValue("@HARF_NOTU", txtNewHarfNotu.Text);
            komutEkle.ExecuteNonQuery();
            komutEkle.CommandType = CommandType.Text;
           // komutEkle.CommandText= "insert into bil203 (derskodu,dersadı,kredi,öğretimüyesi,dönem,harfnotu) values (@DERS_KODU,@DERS_ADI,@KREDİ,@ÖĞRETİM_ÜYESİ,@DÖNEM,@HARF_NOTU)";

      
            conn.Close();

            kayıtlarıgetir("select * from ders");
                 
 
            MessageBox.Show("Ders Ekleme İşlemi Basarili Şekilde Tamamlandı");
            conn.Close();

        }


        private void btnNewDersGoruntule_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost ; port=5432; Database=bil203; user ID=postgres; password=Yakamoz.21");
            string sorgu = "select * from ders";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgwMevcut.DataSource = ds.Tables[0];
        }

        private void frmDersEkle_Load(object sender, EventArgs e)
        {
            DataGridviewSetting(dtgwMevcut);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
