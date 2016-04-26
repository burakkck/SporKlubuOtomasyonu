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
    public partial class tesis : Form
    {
        public tesis()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=sporkulup;Uid=root;Pwd=burak145+");

        private void tesis_Load(object sender, EventArgs e)
        {
            // id yi otomatik alma

            con.Open();
            MySqlCommand cmdid = new MySqlCommand("select id FROM tesis order by id DESC", con);
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

            // verileri çekip ekrana yazdırma

            MySqlCommand cmd = new MySqlCommand("SELECT id, ad, adres, acilis_tarih as 'açılış tarihi' FROM tesis", con);
            DataTable tablo = new DataTable();

            con.Open();
            MySqlDataReader oku = cmd.ExecuteReader();
            tablo.Load(oku);
            con.Close();

            dataGridView1.DataSource = tablo;
        }

        private void btnTesisSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dugme = new DialogResult();

                dugme = MessageBox.Show("'" + textBox2.Text + "'" + " silmek istediğinizden emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dugme == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand("delete FROM tesis where ad = @AD ", con);
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
                MessageBox.Show("Lütfen tesis adını kotrol ediniz");
            }
        }

        private void btnTesisEkle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd1 = new MySqlCommand("insert into tesis(id, ad, adres, acilis_tarih) values (@id, @ad, @adres, @actar) ", con);
                cmd1.Parameters.AddWithValue("@ad", textBox2Ekle.Text);
                cmd1.Parameters.AddWithValue("@adres", textBox3Ekle.Text);
                cmd1.Parameters.AddWithValue("@actar", dateTimePicker1Ekle.Text);
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

        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdbl1 = new MySqlCommand("select id FROM tesis where ad = @ad", con);
                cmdbl1.Parameters.AddWithValue("@ad", textBox2.Text);
                MySqlCommand cmdbl2 = new MySqlCommand("select adres FROM tesis where ad = @ad", con);
                cmdbl2.Parameters.AddWithValue("@ad", textBox2.Text);
                MySqlCommand cmdbl3 = new MySqlCommand("select acilis_tarih FROM tesis where ad = @ad", con);
                cmdbl3.Parameters.AddWithValue("@ad", textBox2.Text);

                con.Open();

                Int32 no = Convert.ToInt32(cmdbl1.ExecuteScalar());
                textBox1.Text = no.ToString();

                textBox3.Text = (cmdbl2.ExecuteScalar()).ToString();

                dateTimePicker1.Text = (cmdbl3.ExecuteScalar()).ToString();

                con.Close();
            }
            catch
            {
                MessageBox.Show("Lütfen tesis adını kontrol ediniz");
            }
        }

        private void btnTesisGnclle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdup = new MySqlCommand("UPDATE tesis SET id = @id, ad = @ad, adres = @adres, acilis_tarih = @ac_tar where ad = @ad", con);
                cmdup.Parameters.AddWithValue("@ad", textBox2.Text);
                cmdup.Parameters.AddWithValue("@adres", textBox3.Text);
                cmdup.Parameters.AddWithValue("@ac_tar", dateTimePicker1.Text);
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
                MessageBox.Show("Lütfen değerleri kontrol ediniz");
            }
        }
    }
}
