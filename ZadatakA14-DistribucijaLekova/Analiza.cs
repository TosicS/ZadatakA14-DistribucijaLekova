using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadatakA14_DistribucijaLekova
{
    public partial class Analiza : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Skola\MATURA\Programiranje\ZadatakA14-DistribucijaLekova\ZadatakA14-DistribucijaLekova\A14.mdf;Integrated Security=True;");

        public Analiza()
        {
            InitializeComponent();
        }

        public void PopuniListCheckedBox()
        {
            string sqlUpit = "Select Naziv, ProizvodjacID from Proizvodjac";
            SqlCommand komanda = new SqlCommand(sqlUpit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);

                checkedListBox1.DataSource = dt;
                checkedListBox1.DisplayMember = "Naziv";
                checkedListBox1.ValueMember = "ProizvodjacID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Analiza_Load(object sender, EventArgs e)
        {
            PopuniListCheckedBox();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            foreach (DataRowView item in checkedListBox1.CheckedItems)
            {
                string sqlUpit = "Select Proizvodjac.Naziv, COUNT(Lek.LekID) as 'Broj lekova' " +
                    "from Lek inner join Proizvodjac on Proizvodjac.ProizvodjacID = Lek.ProizvodjacID " +
                    "where Proizvodjac.ProizvodjacID = @parSifra " +
                    "group by Proizvodjac.Naziv";

                SqlCommand komanda = new SqlCommand(sqlUpit, konekcija);
                komanda.Parameters.AddWithValue("@parSifra", item["ProizvodjacID"]);
                SqlDataAdapter adapter = new SqlDataAdapter(komanda);

                try
                {
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            chart1.DataSource = dt;
            chart1.Series[0].XValueMember = "Naziv";
            chart1.Series[0].YValueMembers = "Broj lekova";
            chart1.Series[0].IsValueShownAsLabel = true;
        }

        private void buttonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
