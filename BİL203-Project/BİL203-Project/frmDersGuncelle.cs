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
    public partial class frmDersGuncelle : Form
    {
        
        public frmDersGuncelle()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localhost ; port=5432; Database=bil203; user ID=postgres; password=Yakamoz.21");
        public void DataGridviewSetting(DataGridView datagridview)
        {
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btnGuncelDersGoruntule_Click(object sender, EventArgs e)
        {

            string sorgu = "select * from ders";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgwMevcut.DataSource = ds.Tables[0];
        }

        private void frmDersGuncelle_Load(object sender, EventArgs e)
        {
            DataGridviewSetting(dtgwMevcut);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDersiGuncelle_Click(object sender, EventArgs e)
        {
           // NpgsqlCommand = "UPDATE ders SET derskodu=@DERS_KODU, dersadı=@DERS_ADI, kredi=@KREDİ, öğretimüyesi=@ÖĞRETİM_ÜYESİ,dönem=@DONEM,harfnotu=@HARF_NOTU";
        }
    }
}
