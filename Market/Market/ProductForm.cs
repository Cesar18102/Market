using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Market
{
    public partial class ProductForm : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private List<int> IDS = new List<int>();
        private List<int> Section_IDS = new List<int>();
        
        public ProductForm()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT * FROM product");
            Update();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            int MPID = Constants.GetMaxID(ref MSC, "SELECT MAX(id) AS id FROM product") + 1;

            MySqlCommand C = new MySqlCommand("INSERT INTO product VALUES(@id, @section_id, @name, @descr, @price)", MSC);

            C.Parameters.Add("@id", MPID);
            C.Parameters.Add("@section_id", Section_IDS[ProductSection.SelectedIndex]);
            C.Parameters.Add("@name", ProductName.Text);
            C.Parameters.Add("@descr", ProductDescription.Text);
            C.Parameters.Add("@price", Convert.ToDouble(ProductPrice.Value));

            C.ExecuteNonQuery();


            C = new MySqlCommand("INSERT INTO storage_product VALUES(@product_id, @amount)", MSC);

            C.Parameters.Add("@product_id", MPID);
            C.Parameters.Add("@amount", 0.000000001);

            C.ExecuteNonQuery();

            Update();

            MessageBox.Show("Продукт успешно добавлен!");
        }

        private void RemoveProduct_Click(object sender, EventArgs e)
        {
            if (!IDS.Contains(Convert.ToInt32(DelId.Value)))
            {
                MessageBox.Show("Продукта с указанным ID не существует!");
                return;
            }

            MySqlCommand C = new MySqlCommand("DELETE FROM product WHERE id=@id", MSC);

            C.Parameters.Add("@id", Convert.ToInt32(DelId.Value));

            C.ExecuteNonQuery();

            Update();

            MessageBox.Show("Продукт успешно удален!");
        }

        private void Update()
        {
            DT = new DataTable();
            MDA.Fill(DT);
            ProductList.DataSource = DT;

            for (int i = 0; i < ProductList.RowCount; i++)
                IDS.Add(Convert.ToInt32(ProductList.Rows[i].Cells["id"].Value));

            if (IDS.Count == 0)
                RemoveProduct.Enabled = false;
            else
            {
                RemoveProduct.Enabled = true;
                DelId.Minimum = IDS.Min();
                DelId.Maximum = IDS.Max();
            }

            MySqlDataAdapter Section_DA = new MySqlDataAdapter();
            Section_DA.SelectCommand = new MySqlCommand("SELECT * FROM section", MSC);

            DataTable Section_DT = new DataTable();
            Section_DA.Fill(Section_DT);

            for (int i = 0; i < Section_DT.Rows.Count; i++) {

                Section_IDS.Add(Convert.ToInt32(Section_DT.Rows[i]["id"]));
                ProductSection.Items.Add(Section_DT.Rows[i]["name"].ToString());
            }

            if (Section_IDS.Count == 0)
                AddProduct.Enabled = false;
            else
            {
                AddProduct.Enabled = true;
                ProductSection.SelectedIndex = 0;
            }
        }
    }
}