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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        CategoryDal cdal = new CategoryDal();
        ProductDal pdal = new ProductDal();
        private void UrunEkle_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = cdal.GetAll();
            comboBox2.DisplayMember = "CategoryName";
            comboBox2.ValueMember = "CategoryId";
        }
        private void GetAllProductsByCategory(int categoryId)
        {
            using (StokTakipContext context = new StokTakipContext())
            {
                comboBox1.DataSource = context.Brands.Where(p => p.CategoryId == categoryId).ToList();
                comboBox1.DisplayMember ="BrandName";
            }
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Text = "";
                GetAllProductsByCategory(Convert.ToInt32(comboBox2.SelectedValue));
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pdal.Add(new Product
            {
                 //BarkodNo=Convert.ToInt32(textBox1.Text),
                 CategoryName=comboBox2.Text,
                 BrandNmae=comboBox1.Text,
                 ProductName=textBox2.Text,
                 Unit=Convert.ToInt32(textBox3.Text),
                 TakePrice=Convert.ToDecimal(textBox4.Text),
                 SellPrice=Convert.ToDecimal(textBox5.Text)
            });
            MessageBox.Show("Ürün Eklendi");
        }
        private void SearchProductsByBarkodNo(int key)
        {
            var result = pdal.GetAll().Where(p => p.BarkodNo==key).ToList();
            foreach (var item in result)
            {
                textBox7.Text = item.CategoryName;
                textBox8.Text = item.BrandNmae;
                textBox9.Text = item.ProductName;
                textBox10.Text =Convert.ToString(item.Unit);
                textBox11.Text =Convert.ToString(item.TakePrice);
                textBox12.Text =Convert.ToString(item.SellPrice);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text=="")
            {
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
            }
            try
            {
                SearchProductsByBarkodNo(Convert.ToInt32(textBox6.Text));
            }
            catch
            {
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pdal.Update(new Product
            {
                CategoryName = textBox7.Text,
                BrandNmae = textBox8.Text,
                ProductName = textBox9.Text,
                Unit = Convert.ToInt32(textBox10.Text),
                TakePrice = Convert.ToDecimal(textBox11.Text),
                SellPrice = Convert.ToDecimal(textBox12.Text)
            });
            MessageBox.Show("Ürün Güncellendi");
        }
    }
}
