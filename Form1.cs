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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MEkle ekle = new MEkle();
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MListele liste = new MListele();
            liste.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CEkle2 c = new CEkle2();
            c.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MEkel mekle = new MEkel();
            mekle.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.ShowDialog();
        }
    }
}
