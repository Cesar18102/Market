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
    public partial class DealForm : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private List<int> IDS = new List<int>();
        private List<int> Product_IDS = new List<int>();
        private List<int> Product_Counts = new List<int>();

        public DealForm()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT * FROM deals");
            Update();
        }

        private void AddDeal_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter Price_DA = new MySqlDataAdapter();
            Price_DA.SelectCommand = new MySqlCommand("SELECT price FROM product WHERE id=" + Product_IDS[Product.SelectedIndex], MSC);

            DataTable Price_DT = new DataTable();
            Price_DA.Fill(Price_DT);

            int price = Convert.ToInt32(Price_DT.Rows[0]["price"]) * Convert.ToInt32(Amount.Value);


            MySqlCommand C = new MySqlCommand("INSERT INTO deals VALUES(@product_id, @date, @amount, @price)", MSC);

            C.Parameters.Add("@product_id", Product_IDS[Product.SelectedIndex]);
            C.Parameters.Add("@date", Constants.FormatDateTime(Date.Value));
            C.Parameters.Add("@amount", Convert.ToInt32(Amount.Value));
            C.Parameters.Add("@price", price);

            C.ExecuteNonQuery();


            C = new MySqlCommand("UPDATE storage_product SET amount = amount - @spent WHERE product_id=@product_id", MSC);

            C.Parameters.Add("@spent", Convert.ToInt32(Amount.Value));
            C.Parameters.Add("@product_id", Product_IDS[Product.SelectedIndex]);

            C.ExecuteNonQuery();

            Update();
        }

        private void Update()
        {
            Product.Items.Clear();
            ProductVAL.Items.Clear();

            DT = new DataTable();
            MDA.Fill(DT);
            DealList.DataSource = DT;

            MySqlDataAdapter Product_DA = new MySqlDataAdapter();
            Product_DA.SelectCommand = new MySqlCommand("SELECT P.id, P.name, S.amount FROM product P, storage_product S WHERE S.product_id = P.id AND S.amount != 0", MSC);

            DataTable Product_DT = new DataTable();
            Product_DA.Fill(Product_DT);

            for (int i = 0; i < Product_DT.Rows.Count; i++)
            {

                Product_IDS.Add(Convert.ToInt32(Product_DT.Rows[i]["id"]));
                Product_Counts.Add(Convert.ToInt32(Product_DT.Rows[i]["amount"]));
                Product.Items.Add(Product_DT.Rows[i]["name"].ToString());
                ProductVAL.Items.Add(Product_DT.Rows[i]["name"].ToString());
            }

            if (Product_IDS.Count == 0)
            {
                AddDeal.Enabled = false;
                ProductCB.Checked = false;
                ProductCB.Enabled = false;
            }
            else
            {
                AddDeal.Enabled = true;
                Product.SelectedIndex = 0;
                Amount.Maximum = Product_Counts[Product.SelectedIndex];
                ProductCB.Enabled = true;
            }
        }

        private void Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            Amount.Maximum = Product_Counts[Product.SelectedIndex];
        }

        private void Filter_Changed(object sender, EventArgs e)
        {

            string Condition = "";

            if (ProductCB.Checked && ProductVAL.SelectedIndex != -1)
                Condition += "product_id=" + Product_IDS[ProductVAL.SelectedIndex];

            if (PeriodCB.Checked && StartVAL.Value <= EndVAL.Value)
                Condition += " AND date BETWEEN '" + Constants.FormatDateTime(StartVAL.Value) + "' AND '" + 
                                                     Constants.FormatDateTime(EndVAL.Value) + "'";

            MDA.SelectCommand = new MySqlCommand("SELECT * FROM deals" + (Condition == ""? "" : " WHERE " + Condition), MSC);

            Update();
        }
    }
}
