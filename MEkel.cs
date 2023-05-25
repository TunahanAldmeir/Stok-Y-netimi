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
    public partial class MEkel : Form
    {
        public MEkel()
        {
            InitializeComponent();
        }
        CategoryDal c = new CategoryDal();
        BrandDal b = new BrandDal();
        private void MEkel_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = c.GetAll();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b.Add(new Brand
            {
                CategoryId=Convert.ToInt32(comboBox1.SelectedValue),
                BrandName = textBox2.Text
            });
            MessageBox.Show("Marka Eklendi");
        }
    }
}
