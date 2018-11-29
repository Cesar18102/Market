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
    public partial class SupplyForm : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private List<int> IDS = new List<int>();
        private List<int> Provider_IDS = new List<int>();
        private List<int> Product_IDS = new List<int>();

        public SupplyForm()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT * FROM provider_product");
            Update();
        }

        private void AddSupply_Click(object sender, EventArgs e)
        {
            MySqlCommand C = new MySqlCommand("INSERT INTO provider_product VALUES(@provider_id, @product_id, @amount, @date, @price)", MSC);

            C.Parameters.Add("@product_id", Product_IDS[Product.SelectedIndex]);
            C.Parameters.Add("@provider_id", Provider_IDS[Provider.SelectedIndex]);
            C.Parameters.Add("@date", Constants.FormatDateTime(Date.Value));
            C.Parameters.Add("@amount", Convert.ToInt32(Amount.Value));
            C.Parameters.Add("@price", Convert.ToDouble(Price.Value));

            C.ExecuteNonQuery();


            C = new MySqlCommand("UPDATE storage_product SET amount = amount + @add WHERE product_id=@product_id", MSC);

            C.Parameters.Add("@add", Convert.ToInt32(Amount.Value));
            C.Parameters.Add("@product_id", Product_IDS[Product.SelectedIndex]);

            C.ExecuteNonQuery();

            Update();
        }

        private void Update()
        {
            DT = new DataTable();
            MDA.Fill(DT);
            SupplyList.DataSource = DT;


            MySqlDataAdapter Provider_DA = new MySqlDataAdapter();
            Provider_DA.SelectCommand = new MySqlCommand("SELECT * FROM provider", MSC);

            DataTable Provider_DT = new DataTable();
            Provider_DA.Fill(Provider_DT);

            for (int i = 0; i < Provider_DT.Rows.Count; i++) {

                Provider_IDS.Add(Convert.ToInt32(Provider_DT.Rows[i]["id"]));
                Provider.Items.Add(Provider_DT.Rows[i]["name"].ToString());
            }


            MySqlDataAdapter Product_DA = new MySqlDataAdapter();
            Product_DA.SelectCommand = new MySqlCommand("SELECT * FROM product", MSC);

            DataTable Product_DT = new DataTable();
            Product_DA.Fill(Product_DT);

            for (int i = 0; i < Product_DT.Rows.Count; i++) {

                Product_IDS.Add(Convert.ToInt32(Product_DT.Rows[i]["id"]));
                Product.Items.Add(Product_DT.Rows[i]["name"].ToString());
            }

            if (Product_IDS.Count == 0 || Provider_IDS.Count == 0)
                AddSupply.Enabled = false;
            else
            {
                AddSupply.Enabled = true;
                Product.SelectedIndex = 0;
                Provider.SelectedIndex = 0;
            }
        }
    }
}
