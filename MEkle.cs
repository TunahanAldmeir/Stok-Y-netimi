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
    public partial class MEkle : Form
    {
        public MEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CostumerDal costumer = new CostumerDal();
            costumer.Add(new Costumer
            {
                tc=textBox1.Text,
                adsoyad=textBox2.Text,
                tel=textBox3.Text,
                adres=textBox4.Text,
                email=textBox5.Text
            });
            MessageBox.Show("Müşteri Eklendi");
        }
    }
}
