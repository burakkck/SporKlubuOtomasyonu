using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class SporBrans : Form
    {
        public SporBrans()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=sporkulup;Uid=root;Pwd=burak145+");

        private void btnSbEkle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd1 = new MySqlCommand("insert into sporbrans(id, ad) values (@id, @ad)", con);
                cmd1.Parameters.AddWithValue("@ad", textBox2Ekle.Text);
                cmd1.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1Ekle.Text));

                con.Open();
                int onay2 = cmd1.ExecuteNonQuery();
                con.Close();

                if (onay2 > 0)
                {
                    MessageBox.Show("ekleme basarılı");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen değerleri kontrol ediniz");
            }
        }

        private void SporBrans_Load(object sender, EventArgs e)
        {
            // otomatik id atama
            
            con.Open();
            MySqlCommand cmdid = new MySqlCommand("select id FROM sporbrans order by id DESC", con);
            MySqlDataReader oku1 = cmdid.ExecuteReader();
            if (oku1.Read())
            {
                textBox1Ekle.Text = (Convert.ToInt32(oku1[0]) + 1).ToString();
            }
            else
            {
                textBox1Ekle.Text = 1.ToString();
            }
            con.Close();


            //verileri ekrana yazdırma

            MySqlCommand cmd = new MySqlCommand("select * FROM sporbrans", con);
            DataTable tablo = new DataTable();
            
            con.Open();
            MySqlDataReader oku = cmd.ExecuteReader();
            tablo.Load(oku);
            con.Close();
            
            dataGridView1.DataSource = tablo;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSbSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dugme = new DialogResult();

                dugme = MessageBox.Show("DİKKAT!!! " + "'" + textBox2.Text + "'" + " branşını silerseniz bu branşa bağlı sporcu ve antrenörler de silinecektir\n " + "yine de silmek istediğinizden emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dugme == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand("delete FROM sporbrans where ad = @AD", con);
                    cmd.Parameters.AddWithValue("@AD", textBox2.Text);

                    con.Open();
                    int onay1 = cmd.ExecuteNonQuery();
                    con.Close();
                    if (onay1 > 0)
                    {
                        MessageBox.Show("silme basarili");
                    }
                }
            }
            catch
            {
                MessageBox.Show("lütfen ad kısmını kontrol ediniz");
            }
        }

        private void btnSbGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdup = new MySqlCommand("UPDATE sporbrans SET id = @id, ad = @ad  where ad = @ad", con);
                cmdup.Parameters.AddWithValue("@ad", textBox2.Text);
                cmdup.Parameters.AddWithValue("@id", textBox1.Text);

                con.Open();
                int onay3 = cmdup.ExecuteNonQuery();
                con.Close();
                if (onay3 > 0)
                {
                    MessageBox.Show("guncelleme başarılı");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen degerleri kontrol ediniz");
            }
        }
    }
}
