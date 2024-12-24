using Npgsql;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        NpgsqlConnection conn=new NpgsqlConnection("server=localhost ; port=5432; Database=bil203; user ID=postgres; password=Yakamoz.21");

        public void DataGridviewSetting(DataGridView datagridview)
        {
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            DataGridviewSetting(dtgwMevcut);
        }

        private void kayıtEklemeEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDersEkle frmDersEkle=new frmDersEkle();
            frmDersEkle.Show();

        }

        private void kayıtSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDersSil frmDersSil =new frmDersSil();
            frmDersSil.Show();
        }

        private void kayıtGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDersGuncelle frmDersGuncelle =new frmDersGuncelle();
            frmDersGuncelle.Show();
        }

        private void gANOGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Transkript transkript=new Transkript();
            transkript.Show();
        }
       

        private void btnMevcutGoruntule_Click(object sender, EventArgs e)
        {
            
            string sorgu = "select * from ders";
             NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
             DataSet ds = new DataSet();
             da.Fill(ds);
            dtgwMevcut.DataSource = ds.Tables[0];
            
        }
    }
}
