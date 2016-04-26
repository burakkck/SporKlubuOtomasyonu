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
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=sporkulup;Uid=root;Pwd=burak145+");

        private void btnYnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd1 = new MySqlCommand("insert into yonetici(yonetici_no, ad, soyad, gorev, telefon, adres, dog_tar) values (@yonetici_no, @ad, @soyad, @gorev, @telefon, @adres, @dogtar) ", con);
                cmd1.Parameters.AddWithValue("@ad", textBox2Ekle.Text);
                cmd1.Parameters.AddWithValue("@soyad", textBox3Ekle.Text);
                cmd1.Parameters.AddWithValue("@gorev", textBox5Ekle.Text);
                cmd1.Parameters.AddWithValue("@telefon", Convert.ToInt64(textBox4Ekle.Text));
                cmd1.Parameters.AddWithValue("@adres", textBox6Ekle.Text);
                cmd1.Parameters.AddWithValue("@dogtar", dateTimePicker1Ekle.Text);
                cmd1.Parameters.AddWithValue("yonetici_no", Convert.ToInt32(textBox1Ekle.Text));


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

        private void btnYoneticiSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dugme = new DialogResult();

                dugme = MessageBox.Show("'" + textBox2.Text + " " + textBox3.Text + "'" + " silmek istediğinizden emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dugme == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand("delete FROM yonetici where ad = @AD and soyad = @SOYAD ", con);
                    cmd.Parameters.AddWithValue("@AD", textBox2.Text);
                    cmd.Parameters.AddWithValue("@SOYAD", textBox3.Text);
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
                MessageBox.Show("Lütfen ad ve soyad kısmını kontrol ediniz");
            }

        }

        private void yonetici_Load(object sender, EventArgs e)
        {
            
            con.Open();
            MySqlCommand cmdid = new MySqlCommand("select yonetici_no FROM yonetici order by yonetici_no DESC", con);
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

            
            MySqlCommand cmd = new MySqlCommand("SELECT yonetici_no as 'yonetici no', ad, soyad, gorev as görev, telefon, adres, dog_tar as 'doğum tarihi'  FROM yonetici", con);
            DataTable tablo = new DataTable();
            con.Open();
            MySqlDataReader oku = cmd.ExecuteReader();
            tablo.Load(oku);
            con.Close();

            dataGridView1.DataSource = tablo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnYntcGnclle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdup = new MySqlCommand("UPDATE yonetici SET yonetici_no = @yon_no, ad = @ad, soyad = @soyad, gorev = @gorev, telefon = @telefon, adres = @adres, dog_tar = @dog_tar where ad = @ad and soyad = @soyad", con);
                cmdup.Parameters.AddWithValue("@ad", textBox2.Text);
                cmdup.Parameters.AddWithValue("soyad", textBox3.Text);
                cmdup.Parameters.AddWithValue("@telefon", textBox4.Text);
                cmdup.Parameters.AddWithValue("@gorev", textBox5.Text);
                cmdup.Parameters.AddWithValue("@adres", textBox6.Text);
                cmdup.Parameters.AddWithValue("@dog_tar", dateTimePicker1.Text);
                cmdup.Parameters.AddWithValue("@yon_no", textBox1.Text);
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

        private void btnBul_Click(object sender, EventArgs e)
        {
            
        }

        private void btnnnBul_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdbl1 = new MySqlCommand("select yonetici_no FROM yonetici where ad = @ad and soyad = @soyad", con);
                cmdbl1.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl1.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl2 = new MySqlCommand("select gorev FROM yonetici where ad = @ad and soyad = @soyad", con);
                cmdbl2.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl2.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl3 = new MySqlCommand("select telefon FROM yonetici where ad = @ad and soyad = @soyad", con);
                cmdbl3.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl3.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl4 = new MySqlCommand("select adres FROM yonetici where ad = @ad and soyad = @soyad", con);
                cmdbl4.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl4.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl5 = new MySqlCommand("select dog_tar FROM yonetici where ad = @ad and soyad = @soyad", con);
                cmdbl5.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl5.Parameters.AddWithValue("@soyad", textBox3.Text);

                con.Open();

                Int32 no = Convert.ToInt32(cmdbl1.ExecuteScalar());
                textBox1.Text = no.ToString();

                textBox5.Text = (cmdbl2.ExecuteScalar()).ToString();

                Int64 tel = Convert.ToInt64(cmdbl3.ExecuteScalar());
                textBox4.Text = tel.ToString();

                textBox6.Text = (cmdbl4.ExecuteScalar()).ToString();

                dateTimePicker1.Text = (cmdbl5.ExecuteScalar()).ToString();

                con.Close();
            }
            catch
            {
                MessageBox.Show("Lütfen ad ve soyad kısmını kontrol ediniz");
            }
        }
        
    }
}
