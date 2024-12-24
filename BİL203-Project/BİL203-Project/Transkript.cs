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
    public partial class Transkript : Form
    {
        public Transkript()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localhost ; port=5432; Database=bil203; user ID=postgres; password=Yakamoz.21");
        private int dersinkredisi;
        private readonly decimal GANO;

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
            string sorgu = "select * from ders";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgwMevcut.DataSource = ds.Tables[0];
            roGano.Text = System.Math.Round(GANO, 2).ToString();

        }
        public decimal toplananKrediHesapla(string harfnotu, decimal dersinkredisi)
        {

            decimal toplanankredi = 0;

            switch (harfnotu)
            {
                case "AA":

                    toplanankredi = 4 * dersinkredisi;
                    break;

                case "BA":

                    toplanankredi = 3.5M * dersinkredisi;
                    break;

                case "BB":

                    toplanankredi = 3 * dersinkredisi;
                    break;

                case "CB":

                    toplanankredi = 2.5M * dersinkredisi;
                    break;

                case "CC":

                    toplanankredi = 2 * dersinkredisi;
                    break;

                case "DC":

                    toplanankredi = 1.5M * dersinkredisi;
                    break;

                case "DD":

                    toplanankredi = 1 * dersinkredisi;
                    break;

                case "FD":

                    toplanankredi = 0.5M * dersinkredisi;
                    break;

                case "FF":

                    toplanankredi = 0 * dersinkredisi;
                    break;
            }

            return toplanankredi;
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
                alinanToplamKredi += Convert.ToDecimal(dtgwMevcut.Rows[i].Cells["kredi"].Value);
                toplananKredi += toplananKrediHesapla(dtgwMevcut.Rows[i].Cells["harfnotu"].Value.ToString(), Convert.ToDecimal(dtgwMevcut.Rows[i].Cells["KREDİ"].Value));
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

