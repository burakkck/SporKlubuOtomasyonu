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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=sporkulup;Uid=root;Pwd=burak145+");

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void personel_Load(object sender, EventArgs e)
        {

            // id yi otomatik alma

            con.Open();
            MySqlCommand cmdid = new MySqlCommand("select id FROM personel order by id DESC", con);
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

            MySqlCommand cmd = new MySqlCommand("SELECT id, ad, soyad, gorev as 'görev', dog_tar as 'doğum tarihi', adres, telefon, maas FROM personel", con);
            DataTable tablo = new DataTable();

            con.Open();
            MySqlDataReader oku = cmd.ExecuteReader();
            tablo.Load(oku);
            con.Close();

            dataGridView1.DataSource = tablo;
        }

        private void btnPrsnelSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dugme = new DialogResult();

                dugme = MessageBox.Show("'" + textBox2.Text + " " + textBox3.Text + "'" + " silmek istediğinizden emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dugme == DialogResult.Yes)
                {
                    
                    MySqlCommand cmddlt = new MySqlCommand("delete FROM personel where ad = @AD and soyad = @SOYAD ", con);
                    cmddlt.Parameters.AddWithValue("@AD", textBox2.Text);
                    cmddlt.Parameters.AddWithValue("@SOYAD", textBox3.Text);
                    int onay1 = 0;
                    con.Open();
                    onay1 = cmddlt.ExecuteNonQuery();
                    con.Close();
                    if (onay1 > 0)
                    {
                        MessageBox.Show("silme basarili");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen ad ve soyad kısmını kontrol ediniz", "Hata");
                
            }
        }

        private void btnPrsnelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                MySqlCommand cmd1 = new MySqlCommand("insert into personel(id, ad, soyad, telefon, adres, dog_tar, gorev, maas) values (@id, @ad, @soyad, @telefon, @adres, @dogtar, @gorev, @maas) ", con);
                cmd1.Parameters.AddWithValue("@ad", textBox2Ekle.Text);
                cmd1.Parameters.AddWithValue("@soyad", textBox3Ekle.Text);
                cmd1.Parameters.AddWithValue("@adres", textBox5Ekle.Text);
                cmd1.Parameters.AddWithValue("@telefon", Convert.ToInt64(textBox4Ekle.Text));
                cmd1.Parameters.AddWithValue("@gorev", textBox6Ekle.Text);
                cmd1.Parameters.AddWithValue("@maas", textBox7ekle.Text);
                cmd1.Parameters.AddWithValue("@dogtar", dateTimePicker1Ekle.Text);
                cmd1.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1Ekle.Text));

                int onay2 = 0;
                con.Open();
                onay2 = cmd1.ExecuteNonQuery();
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
                MySqlCommand cmdbl1 = new MySqlCommand("select id FROM personel where ad = @ad and soyad = @soyad", con);
                cmdbl1.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl1.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl2 = new MySqlCommand("select gorev FROM personel where ad = @ad and soyad = @soyad", con);
                cmdbl2.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl2.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl3 = new MySqlCommand("select telefon FROM personel where ad = @ad and soyad = @soyad", con);
                cmdbl3.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl3.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl4 = new MySqlCommand("select adres FROM personel where ad = @ad and soyad = @soyad", con);
                cmdbl4.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl4.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl5 = new MySqlCommand("select dog_tar FROM personel where ad = @ad and soyad = @soyad", con);
                cmdbl5.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl5.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl6 = new MySqlCommand("select maas FROM personel where ad = @ad and soyad = @soyad", con);
                cmdbl6.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl6.Parameters.AddWithValue("@soyad", textBox3.Text);

                con.Open();

                Int32 no = Convert.ToInt32(cmdbl1.ExecuteScalar());
                textBox1.Text = no.ToString();

                Int64 tel = Convert.ToInt64(cmdbl3.ExecuteScalar());
                textBox4.Text = tel.ToString();
                textBox5.Text = (cmdbl4.ExecuteScalar()).ToString();
                textBox6.Text = (cmdbl2.ExecuteScalar()).ToString();
                textBox7.Text = (cmdbl6.ExecuteScalar()).ToString();

                dateTimePicker1.Text = (cmdbl5.ExecuteScalar()).ToString();

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen ad ve soyad kısmını kontrol ediniz");
            }
        }

        private void btnPrsnelGnclle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdup = new MySqlCommand("UPDATE personel SET id = @id, ad = @ad, soyad = @soyad, adres = @adres, dog_tar = @dogtar, telefon = @telefon, gorev = @gorev, maas = @maas where ad = @ad and soyad = @soyad", con);
                cmdup.Parameters.AddWithValue("@id", textBox1.Text);
                cmdup.Parameters.AddWithValue("@ad", textBox2.Text);
                cmdup.Parameters.AddWithValue("@soyad", textBox3.Text);
                cmdup.Parameters.AddWithValue("@telefon", textBox4.Text);
                cmdup.Parameters.AddWithValue("@dogtar", dateTimePicker1.Text);
                cmdup.Parameters.AddWithValue("@adres", textBox5.Text);
                cmdup.Parameters.AddWithValue("@gorev", textBox6.Text);
                cmdup.Parameters.AddWithValue("@maas", textBox7.Text);

                con.Open();
                int onay3 = cmdup.ExecuteNonQuery();
                con.Close();
                if (onay3 > 0)
                {
                    MessageBox.Show("guncelleme başarılı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen değerleri kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
