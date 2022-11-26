using WndApp.DAL;
using WndApp.Model;

namespace WndApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapDB db = new KitapDB();
            MessageBox.Show(db.ConnectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(2000,12,10);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Kategori> kategoriler = new List<Kategori> { 
             new Kategori{ KategoriID=1, KategoriAdi="Roman" },
             new Kategori{ KategoriID=2, KategoriAdi="Deneme" },
             new Kategori{ KategoriID=3, KategoriAdi="Hikaye" },
             new Kategori{ KategoriID=4, KategoriAdi="Makale" }
            };

            comboBox1.DataSource = kategoriler;
            comboBox1.DisplayMember = "KategoriAdi";
            comboBox1.ValueMember = "KategoriID";
        }
         
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedValue.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}