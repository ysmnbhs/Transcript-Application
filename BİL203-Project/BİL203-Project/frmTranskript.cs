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
    public partial class frmTranskript : Form
    {
        public frmTranskript()
        {
            InitializeComponent();
        }

        //İPTAL OLAN BU SADECE TRANSKRİPT YAZAN BAĞLANTILI FORMDUR . FORMU SİLME İŞLEMİNİ HATA VERDİĞİNDEN DOLAYI YAPAMADIM.




        NpgsqlConnection conn = new NpgsqlConnection("server=localhost ; port=5432; Database=bil203; user ID=postgres; password=Yakamoz.21");
        public void DataGridviewSetting(DataGridView datagridview)
        {
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void dtgwMevcut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string sorgu = "select * from ders";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgwMevcut.DataSource = ds.Tables[0];
        }

        private void btnTranskript_Click(object sender, EventArgs e)
        {

        }
        public decimal toplananKrediHesapla(string harfNotu, decimal dersinKredisi)
        {

            decimal toplananKredi = 0;

            switch (harfNotu)
            {
                case "AA":

                    toplananKredi = 4 * dersinKredisi;
                    break;

                case "BA":

                    toplananKredi = 3.5M * dersinKredisi;
                    break;

                case "BB":

                    toplananKredi = 3 * dersinKredisi;
                    break;

                case "CB":

                    toplananKredi = 2.5M * dersinKredisi;
                    break;

                case "CC":

                    toplananKredi = 2 * dersinKredisi;
                    break;

                case "DC":

                    toplananKredi = 1.5M * dersinKredisi;
                    break;

                case "DD":

                    toplananKredi = 1 * dersinKredisi;
                    break;

                case "FD":

                    toplananKredi = 0.5M * dersinKredisi;
                    break;

                case "FF":

                    toplananKredi = 0 * dersinKredisi;
                    break;
            }

            return toplananKredi;
        }


        private void frmTranskript_Load(object sender, EventArgs e)
        {
            DataGridviewSetting(dtgwMevcut);
            dtgwMevcut.AllowUserToAddRows = false;
            NpgsqlConnection conn = new NpgsqlConnection("server=localhost; port=5432; Database=bil203; user Id=postgres; password=Yakamoz.21");
            conn.Open();

            string sorgu = "SELECT * FROM ders WHERE (harfnotu!= '' )ORDER BY dönem;";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sorgu, conn);
            NpgsqlCommand command = npgsqlCommand;
            NpgsqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();

            dataTable.Load(reader);

            dtgwMevcut.DataSource = dataTable;

            decimal alinanToplamKredi = 0;
            decimal toplananKredi = 0;

            for (int i = 0; i < dtgwMevcut.RowCount; i++)
            {
                alinanToplamKredi += Convert.ToDecimal(dtgwMevcut.Rows[i].Cells["KREDİ"].Value);
                toplananKredi += toplananKrediHesapla(dtgwMevcut.Rows[i].Cells["HARF_NOTU"].Value.ToString(), Convert.ToDecimal(dtgwMevcut.Rows[i].Cells["KREDİ"].Value));
            }

            float GANO;

            try
            {
                GANO = (float)(toplananKredi / alinanToplamKredi);
            }
            catch (System.DivideByZeroException)
            {
                return;

            }

            GANO = (float)(toplananKredi / alinanToplamKredi);
            roGano.Text = System.Math.Round(GANO, 2).ToString();
        }

    }




}

