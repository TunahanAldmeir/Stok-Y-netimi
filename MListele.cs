using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaSatış
{
    public partial class MListele : Form
    {
        public MListele()
        {
            InitializeComponent();
        }
        CostumerDal cstmr = new CostumerDal();
        private void MListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cstmr.GetAll();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["tel"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cstmr.Update(new Costumer
            {
                tc=textBox1.Text,
                adsoyad=textBox2.Text,
                tel=textBox3.Text,
                adres=textBox4.Text,
                email=textBox5.Text
            });
            MessageBox.Show("Müşteri Bilgileri Güncellendi");
            dataGridView1.DataSource = cstmr.GetAll();
        }
        private void SearchClients(string key)
        {
            var result = cstmr.GetAll().Where(p => p.adsoyad.ToLower().Contains(key)).ToList();
            dataGridView1.DataSource = result;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            SearchClients(textBox6.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cstmr.Delete(new Costumer
            { 
                tc=dataGridView1.CurrentRow.Cells["tc"].Value.ToString()
            });
            dataGridView1.DataSource = cstmr.GetAll();
            MessageBox.Show("Müşteri Silindi");
        }
    }
}
