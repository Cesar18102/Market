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
    public partial class ProviderForm : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private List<int> IDS = new List<int>();

        public ProviderForm()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT * FROM provider");
            Update();
        }

        private void AddProvider_Click(object sender, EventArgs e)
        {
            int MPID = Constants.GetMaxID(ref MSC, "SELECT MAX(id) AS id FROM provider") + 1;

            MySqlCommand C = new MySqlCommand("INSERT INTO provider VALUES(@id, @name, @address, @phone)", MSC);

            C.Parameters.Add("@id", MPID);
            C.Parameters.Add("@name", ProviderName.Text);
            C.Parameters.Add("@address", ProviderAddress.Text);
            C.Parameters.Add("@phone", ProviderPhone.Text);

            C.ExecuteNonQuery();

            Update();

            MessageBox.Show("Поставщик успешно добавлен!");
        }

        private void RemoveProvider_Click(object sender, EventArgs e)
        {
            if(!IDS.Contains(Convert.ToInt32(DelID.Value)))
            {
                MessageBox.Show("Поставщика с указанным ID не существует!");
                return;
            }

            MySqlCommand C = new MySqlCommand("DELETE FROM provider WHERE id=@id");
            C.Parameters.Add("@id", Convert.ToInt32(DelID.Value));
            C.ExecuteNonQuery();

            Update();

            MessageBox.Show("Поставщик успешно удален!");
        }

        private void Update()
        {
            DT = new DataTable();
            MDA.Fill(DT);
            ProviderList.DataSource = DT;

            for (int i = 0; i < ProviderList.RowCount; i++)
                IDS.Add(Convert.ToInt32(ProviderList.Rows[i].Cells["id"].Value));

            if (IDS.Count == 0)
                RemoveProvider.Enabled = false;
            else
            {
                RemoveProvider.Enabled = true;
                DelID.Minimum = IDS.Min();
                DelID.Maximum = IDS.Max();
            }
        }
    }
}
