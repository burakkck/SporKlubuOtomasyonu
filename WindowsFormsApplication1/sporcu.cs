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
    public partial class sporcu : Form
    {
        public sporcu()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=sporkulup;Uid=root;Pwd=burak145+");

        private void sporcu_Load(object sender, EventArgs e)
        {
            // id yi otomatik alma

            con.Open();
            MySqlCommand cmdid = new MySqlCommand("select id FROM sporcu order by id DESC", con);
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


            // bilgileri ekrana yazdırma

            MySqlCommand cmd = new MySqlCommand("SELECT sporcu.id, sporcu.ad, sporcu.soyad, sporcu.adres, sporcu.dog_tar as 'doğum tarihi', sporcu.telefon, sporcu.sozlesme_bas_tar as 'sözleşme başlangıç tarihi', sporcu.sozlesme_bit_tar as 'sözleşme bitiş tarihi', sporbrans.ad as 'spor branşı' FROM sporcu inner join sporbrans on sporcu.sporBrans_id = sporbrans.id", con);
            DataTable tablo = new DataTable();

            con.Open();
            MySqlDataReader oku = cmd.ExecuteReader();
            tablo.Load(oku);
            con.Close();

            dataGridView1.DataSource = tablo;

            MySqlCommand cmd1 = new MySqlCommand("select ad FROM sporbrans ", con);
            con.Open();
            MySqlDataReader oku1 = cmd1.ExecuteReader();
            while (oku1.Read() == true)
            {
                comboBox1.Items.Add(oku1["ad"]);
                comboBox2.Items.Add(oku1["ad"]);
            }
            con.Close();
        }

        private void btnSprcuSil_Click(object sender, EventArgs e)
        {
            DialogResult dugme = new DialogResult();

            dugme = MessageBox.Show("'" + textBox2.Text + " " + textBox3.Text + "'" + " silmek istediğinizden emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dugme == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand("delete FROM sporcu where ad = @AD and soyad = @SOYAD ", con);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
            
        }

        private void btnYnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // sporbrans isminden id cekme

                con.Open();
                MySqlCommand cmdbrs = new MySqlCommand("select id from sporbrans where ad = @adbrs", con);
                cmdbrs.Parameters.AddWithValue("@adbrs", comboBox2.Text);
                Int16 idbrs = Convert.ToInt16(cmdbrs.ExecuteScalar());


                // veri ekleme

                MySqlCommand cmd1 = new MySqlCommand("insert into sporcu(id, ad, soyad, telefon, adres, dog_tar, sozlesme_bas_tar, sozlesme_bit_tar, sporbrans_id) values (@id, @ad, @soyad, @telefon, @adres, @dogtar, @sozbastar, @sozbittar, @sporbransid) ", con);
                cmd1.Parameters.AddWithValue("@ad", textBox2Ekle.Text);
                cmd1.Parameters.AddWithValue("@soyad", textBox3Ekle.Text);
                cmd1.Parameters.AddWithValue("@adres", textBox5Ekle.Text);
                cmd1.Parameters.AddWithValue("@telefon", Convert.ToInt64(textBox4Ekle.Text));
                cmd1.Parameters.AddWithValue("@sozbastar", textBox6Ekle.Text);
                cmd1.Parameters.AddWithValue("@sozbittar", textBox7ekle.Text);
                cmd1.Parameters.AddWithValue("@dogtar", dateTimePicker1Ekle.Text);
                cmd1.Parameters.AddWithValue("@sporbransid", idbrs);
                cmd1.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1Ekle.Text));

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

        private void btnSprcuGnclle_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                MySqlCommand cmdbrs = new MySqlCommand("select id from sporbrans where ad = @adbrs", con);
                cmdbrs.Parameters.AddWithValue("@adbrs", comboBox1.Text);
                Int16 idbrsgnc = Convert.ToInt16(cmdbrs.ExecuteScalar());

                MySqlCommand cmdup = new MySqlCommand("UPDATE sporcu SET id = @id, ad = @ad, soyad = @soyad, sozlesme_bas_tar = @sozbastar, sozlesme_bit_tar = @sozbittar, telefon = @telefon, adres = @adres, dog_tar = @dog_tar, sporBrans_id = @bransid where ad = @ad and soyad = @soyad", con);
                cmdup.Parameters.AddWithValue("@ad", textBox2.Text);
                cmdup.Parameters.AddWithValue("soyad", textBox3.Text);
                cmdup.Parameters.AddWithValue("@telefon", textBox4.Text);
                cmdup.Parameters.AddWithValue("@adres", textBox5.Text);
                cmdup.Parameters.AddWithValue("@sozbastar", textBox6.Text);
                cmdup.Parameters.AddWithValue("@sozbittar", textBox7.Text);
                cmdup.Parameters.AddWithValue("@dog_tar", dateTimePicker1.Text);
                cmdup.Parameters.AddWithValue("@id", textBox1.Text);
                cmdup.Parameters.AddWithValue("@bransid", idbrsgnc);

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
            try
            {
                con.Open();

                MySqlCommand cmdbl1 = new MySqlCommand("select id FROM sporcu where ad = @ad and soyad = @soyad", con);
                cmdbl1.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl1.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl2 = new MySqlCommand("select sozlesme_bas_tar FROM sporcu where ad = @ad and soyad = @soyad", con);
                cmdbl2.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl2.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl3 = new MySqlCommand("select telefon FROM sporcu where ad = @ad and soyad = @soyad", con);
                cmdbl3.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl3.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl4 = new MySqlCommand("select adres FROM sporcu where ad = @ad and soyad = @soyad", con);
                cmdbl4.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl4.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl5 = new MySqlCommand("select dog_tar FROM sporcu where ad = @ad and soyad = @soyad", con);
                cmdbl5.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl5.Parameters.AddWithValue("@soyad", textBox3.Text);
                MySqlCommand cmdbl6 = new MySqlCommand("select sozlesme_bit_tar FROM sporcu where ad = @ad and soyad = @soyad", con);
                cmdbl6.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl6.Parameters.AddWithValue("@soyad", textBox3.Text);


                MySqlCommand cmdbl7 = new MySqlCommand("select sporBrans_id FROM sporcu where ad = @ad and soyad = @soyad", con);
                cmdbl7.Parameters.AddWithValue("@ad", textBox2.Text); cmdbl7.Parameters.AddWithValue("@soyad", textBox3.Text);

                Int32 idbrns = Convert.ToInt32(cmdbl7.ExecuteScalar());

                MySqlCommand cmdbrs = new MySqlCommand("select ad from sporbrans where id = @idbrs", con);
                cmdbrs.Parameters.AddWithValue("@idbrs", idbrns);


                comboBox1.Text = cmdbrs.ToString();


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
            catch
            {
                MessageBox.Show("Lütfen ad ve soyad kısmını kontrol ediniz");
            }
        }
    }
}
