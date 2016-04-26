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
    public partial class magaza : Form
    {
        public magaza()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=sporkulup;Uid=root;Pwd=burak145+");

        private void magaza_Load(object sender, EventArgs e)
        {
            // id yi otomatik atama

            con.Open();
            MySqlCommand cmdid = new MySqlCommand("select id FROM magaza order by id DESC", con);
            MySqlDataReader oku2 = cmdid.ExecuteReader();
            if (oku2.Read())
            {
                textBox1Ekle.Text = (Convert.ToInt32(oku2[0]) + 1).ToString();
            }
            else
            {
                textBox1Ekle.Text = 1.ToString();
            }
            con.Close();


            // verileri ekrana yazdırma

            MySqlCommand cmd = new MySqlCommand("SELECT id, ad, adres, telefon, sehir, acilis_tarih as 'açılış tarihi' FROM magaza", con);
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

        private void btnMgzaSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dugme = new DialogResult();

                dugme = MessageBox.Show("'" + textBox2.Text + " " + textBox3.Text + "'" + " silmek istediğinizden emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dugme == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand("delete FROM magaza where ad = @AD and sehir = @SEHIR ", con);
                    cmd.Parameters.AddWithValue("@AD", textBox2.Text);
                    cmd.Parameters.AddWithValue("@SEHIR", textBox3.Text);
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
                MessageBox.Show("Lütfen ad ve şehir kısımlarını kontrol ediniz");
            }
        }

        private void btnMgzaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                MySqlCommand cmd1 = new MySqlCommand("insert into magaza(id, ad, telefon, adres, sehir, acilis_tarih) values (@id, @ad, @telefon, @adres, @sehir, @actar)", con);
                cmd1.Parameters.AddWithValue("@ad", textBox2Ekle.Text);
                cmd1.Parameters.AddWithValue("@adres", textBox4Ekle.Text);
                cmd1.Parameters.AddWithValue("@telefon", Convert.ToInt64(textBox5Ekle.Text));
                cmd1.Parameters.AddWithValue("@sehir", textBox3Ekle.Text);
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
                MessageBox.Show("Lütfen değerleri kontrol edin.");
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdbl1 = new MySqlCommand("select id FROM magaza where ad = @ad and sehir = @sehir", con);
                cmdbl1.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl1.Parameters.AddWithValue("@sehir", textBox3.Text);
                MySqlCommand cmdbl2 = new MySqlCommand("select adres FROM magaza where ad = @ad and sehir = @sehir", con);
                cmdbl2.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl2.Parameters.AddWithValue("@sehir", textBox3.Text);
                MySqlCommand cmdbl3 = new MySqlCommand("select acilis_tarih FROM magaza where ad = @ad and sehir = @sehir", con);
                cmdbl3.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl3.Parameters.AddWithValue("@sehir", textBox3.Text);
                MySqlCommand cmdbl4 = new MySqlCommand("select telefon FROM magaza where ad = @ad and sehir = @sehir", con);
                cmdbl4.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl4.Parameters.AddWithValue("@sehir", textBox3.Text);

                con.Open();

                Int32 no = Convert.ToInt32(cmdbl1.ExecuteScalar());
                textBox1.Text = no.ToString();

                textBox4.Text = (cmdbl2.ExecuteScalar()).ToString();

                dateTimePicker1.Text = (cmdbl3.ExecuteScalar()).ToString();

                textBox5.Text = (cmdbl4.ExecuteScalar()).ToString();

                con.Close();
            }
            catch
            {
                MessageBox.Show("Lütfen ad ve şehir kısmını kontrol edin");
            }
        }

        private void btnMgzaGnclle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdup = new MySqlCommand("UPDATE magaza SET id = @id, ad = @ad, adres = @adres, acilis_tarih = @ac_tar, telefon = @telefon, sehir = @sehir where ad = @ad", con);
                cmdup.Parameters.AddWithValue("@ad", textBox2.Text);
                cmdup.Parameters.AddWithValue("@adres", textBox4.Text);
                cmdup.Parameters.AddWithValue("@ac_tar", dateTimePicker1.Text);
                cmdup.Parameters.AddWithValue("@id", textBox1.Text);
                cmdup.Parameters.AddWithValue("@sehir", textBox3.Text);
                cmdup.Parameters.AddWithValue("@telefon", textBox5.Text);
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
