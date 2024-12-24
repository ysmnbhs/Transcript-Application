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
    public partial class frmDersSil : Form
    {
       
        public frmDersSil()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localhost ; port=5432; Database=bil203; user ID=postgres; password=Yakamoz.21");
        public void DataGridviewSetting(DataGridView datagridview)
        {
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btnRemoveDersGoruntule_Click(object sender, EventArgs e)
        {

            string sorgu = "select * from ders";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgwMevcut.DataSource = ds.Tables[0];
        }
    //    private static string SilinecekDersinKodu;

        private void frmDersSil_Load(object sender, EventArgs e)
        {
            DataGridviewSetting(dtgwMevcut);
         
            
        }

        private void btnDersiSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM ders WHERE derskodu = @DERS_KODU";

            NpgsqlConnection conn = new NpgsqlConnection("server=localhost; port=5432; Database=bil203; user Id=postgres; password=Yakamoz.21");
          
            NpgsqlCommand command = new NpgsqlCommand(sorgu, conn);

            command.Parameters.AddWithValue("@DERS_KODU", txtSilinecekDers.Text);
            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
