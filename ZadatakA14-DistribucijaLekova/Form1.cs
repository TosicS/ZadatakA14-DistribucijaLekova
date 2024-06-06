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

namespace ZadatakA14_DistribucijaLekova
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Skola\MATURA\Programiranje\ZadatakA14-DistribucijaLekova\ZadatakA14-DistribucijaLekova\A14.mdf;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        public void PrikaziGV()
        {
            //dataGridView1.ReadOnly = true;
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sqlUpit = "Select Lek.LekID as 'Sifra leka', Lek.ProizvodjacID as 'Sifra proizvodjaca', " +
                "Lek.NazivLeka as 'Naziv Leka', Lek.NezasticenoIme as 'Nezasticeno Ime', Proizvodjac.Naziv as 'Proizvodjac' " +
                "from Lek " +
                "inner join Proizvodjac on Proizvodjac.ProizvodjacID = Lek.ProizvodjacID " +
                "order by Lek.NazivLeka asc";

            SqlCommand komanda = new SqlCommand(sqlUpit, konekcija);
            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrikaziGV();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBoxNazivLeka.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBoxProizvodjac.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void toolStripButtonBrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nema selekcije!");
                return;
            }

            if (MessageBox.Show("Da li ste sigurni da zelite da obrisete lek iz evidencije?",
                "Brisanje leka iz evidencije", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlUpit = "Delete from Lek where LekID = @parSifra";
                SqlCommand komanda = new SqlCommand(sqlUpit, konekcija);
                int sifra = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                komanda.Parameters.AddWithValue("@parSifra", sifra);

                try
                {
                    konekcija.Open();
                    komanda.ExecuteNonQuery();
                    PrikaziGV();
                    textBoxNazivLeka.Text = "";
                    textBoxProizvodjac.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }
        }

        private void toolStripButtonAnaliza_Click(object sender, EventArgs e)
        {
            Analiza forma = new Analiza();
            forma.ShowDialog();
        }

        private void toolStripButtonOAplikaciji_Click(object sender, EventArgs e)
        {
            OAplikaciji forma = new OAplikaciji();
            forma.ShowDialog();
        }

        private void toolStripButtonIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
