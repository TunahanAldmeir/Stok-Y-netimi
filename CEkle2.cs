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
    public partial class CEkle2 : Form
    {
        public CEkle2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CategoryDal cdal = new CategoryDal();
            cdal.Add(new Category
            {
                CategoryName=textBox1.Text
            });
            MessageBox.Show("Kategori Eklendi");
        }
    }
}
