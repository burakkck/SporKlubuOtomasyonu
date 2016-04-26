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
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class DB
        {
            

            public bool baglanti_kontrol()
            {
                try
                {
                    
    MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=sporkulup;Uid=root;Pwd=burak145+");
                    baglanti.Open();
                    return true;
                }

                catch (Exception)
                {
                    return false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB _vt = new DB();

            if (_vt.baglanti_kontrol() == true)
            {
                MessageBox.Show("baglanti kuruldu");
            }

            else
            {
                MessageBox.Show("hata !!!");
            }
            
            
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            btnYonetici.BackColor = Color.Red;
            btnAntrenor.BackColor = Color.Black;
            btnMagaza.BackColor = Color.Black;
            btnPersonel.BackColor = Color.Black;
            btnSporBrans.BackColor = Color.Black;
            btnSporcu.BackColor = Color.Black;
            btnTesis.BackColor = Color.Black;
            btnUye.BackColor = Color.Black;
            panel2.Visible = false;
            yonetici cs = new yonetici();
            cs.MdiParent = this;
            cs.Show();
            cs.Location = new Point(0, 0);
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnYonetici.BackColor = Color.Black;
            btnAntrenor.BackColor = Color.Black;
            btnMagaza.BackColor = Color.Black;
            btnPersonel.BackColor = Color.Black;
            btnSporBrans.BackColor = Color.Black;
            btnSporcu.BackColor = Color.Black;
            btnTesis.BackColor = Color.Black;
            btnYonetici.BackColor = Color.Black;
            btnUye.BackColor = Color.Red;
            panel2.Visible = false;
            uyelerr cs = new uyelerr();
            cs.MdiParent = this;
            cs.Show();
            cs.Location = new Point(0, 0);

            
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSporBrans_Click(object sender, EventArgs e)
        {
            btnYonetici.BackColor = Color.Black;
            btnAntrenor.BackColor = Color.Black;
            btnMagaza.BackColor = Color.Black;
            btnPersonel.BackColor = Color.Black;
            btnSporBrans.BackColor = Color.Red;
            btnSporcu.BackColor = Color.Black;
            btnTesis.BackColor = Color.Black;
            btnUye.BackColor = Color.Black;
            panel2.Visible = false;
            SporBrans cs = new SporBrans();
            cs.MdiParent = this;
            cs.Show();
            cs.Location = new Point(0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnYonetici.BackColor = Color.Black;
            btnAntrenor.BackColor = Color.Black;
            btnMagaza.BackColor = Color.Black;
            btnPersonel.BackColor = Color.Black;
            btnSporBrans.BackColor = Color.Black;
            btnSporcu.BackColor = Color.Red;
            btnTesis.BackColor = Color.Black;
            btnUye.BackColor = Color.Black;
            panel2.Visible = false;
            sporcu cs = new sporcu();
            cs.MdiParent = this;
            cs.Show();
            cs.Location = new Point(0, 0);
        }

        private void btnAntrenor_Click(object sender, EventArgs e)
        {
            btnYonetici.BackColor = Color.Black;
            btnAntrenor.BackColor = Color.Red;
            btnMagaza.BackColor = Color.Black;
            btnPersonel.BackColor = Color.Black;
            btnSporBrans.BackColor = Color.Black;
            btnSporcu.BackColor = Color.Black;
            btnTesis.BackColor = Color.Black;
            btnUye.BackColor = Color.Black;
            panel2.Visible = false;
            antrenor cs = new antrenor();
            cs.MdiParent = this;
            cs.Show();
            cs.Location = new Point(0, 0);
        }

        private void btnTesis_Click(object sender, EventArgs e)
        {
            btnYonetici.BackColor = Color.Black;
            btnAntrenor.BackColor = Color.Black;
            btnMagaza.BackColor = Color.Black;
            btnPersonel.BackColor = Color.Black;
            btnSporBrans.BackColor = Color.Black;
            btnSporcu.BackColor = Color.Black;
            btnTesis.BackColor = Color.Red;
            btnUye.BackColor = Color.Black;
            panel2.Visible = false;
            tesis cs = new tesis();
            cs.MdiParent = this;
            cs.Show();
            cs.Location = new Point(0, 0);
        }

        private void btnMagaza_Click(object sender, EventArgs e)
        {
            btnYonetici.BackColor = Color.Black;
            btnAntrenor.BackColor = Color.Black;
            btnMagaza.BackColor = Color.Red;
            btnPersonel.BackColor = Color.Black;
            btnSporBrans.BackColor = Color.Black;
            btnSporcu.BackColor = Color.Black;
            btnTesis.BackColor = Color.Black;
            btnUye.BackColor = Color.Black;
            panel2.Visible = false;
            magaza cs = new magaza();
            cs.MdiParent = this;
            cs.Show();
            cs.Location = new Point(0, 0);
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            btnYonetici.BackColor = Color.Black;
            btnAntrenor.BackColor = Color.Black;
            btnMagaza.BackColor = Color.Black;
            btnPersonel.BackColor = Color.Red;
            btnSporBrans.BackColor = Color.Black;
            btnSporcu.BackColor = Color.Black;
            btnTesis.BackColor = Color.Black;
            btnUye.BackColor = Color.Black;
            panel2.Visible = false;
            personel cs = new personel();
            cs.MdiParent = this;
            cs.Show();
            cs.Location = new Point(0, 0);
        }
    }
}
