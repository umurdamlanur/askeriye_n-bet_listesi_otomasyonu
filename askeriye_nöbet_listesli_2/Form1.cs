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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace askeriye_nöbet_listesli_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlDataReader dr;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-4VOD4RV\SQLEXPRESS01;Initial Catalog=askeriye;Integrated Security=True");
       
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'askeriyeDataSet1.nobet_listesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.nobet_listesiTableAdapter.Fill(this.askeriyeDataSet1.nobet_listesi);

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into nobet_listesi (ad,soyad) values (@p1,@p2)", baglanti); 
            komut.Parameters.AddWithValue("@p1", txtad.Text); 
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text); 
            komut.ExecuteNonQuery(); 
            baglanti.Close(); 
        }

        private void btnrdn_Click(object sender, EventArgs e)
        {
            int sayi;
            Random rd = new Random();
            //int sayi = rd.Next(0, 3);
            sayi = rd.Next(0, listBox1.Items.Count);
            listBox2.Items.Add(listBox1.Text); listBox1.SelectedIndex = sayi ;
            listBox2.Text = listBox1.Items[sayi].ToString();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open(); 
            SqlCommand komut = new SqlCommand("update nobet_listesi set ad = @p1", baglanti); 
            komut.Parameters.AddWithValue("@p1", txtad.Text); 
            komut.ExecuteNonQuery(); 
            baglanti.Close(); 
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from nobet_listesi where ad=@p1", baglanti); 
            komut.Parameters.AddWithValue("@p1", txtad.Text); 
            komut.ExecuteNonQuery(); 
            baglanti.Close(); 
        }

        private void btnrandom_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from nobet_listesi", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listBox1.Items.Add(tablo.Rows[i][0] + "  " + tablo.Rows[i][1]);
            }
            baglanti.Close();


            /* ÇALIŞIYOR
            listBox1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from nobet_listesi", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                listBox1.Items.Add(read[0]+"  " + read[1]);
            }
            baglanti.Close();
            */
        }
    }
}
