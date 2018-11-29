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
    public partial class Storage : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        public Storage()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT P.name, S.amount FROM product P, storage_product S WHERE S.product_id = P.id");
            Update();
        }

        private void Update()
        {
            DT = new DataTable();
            MDA.Fill(DT);
            DealList.DataSource = DT;
        }
    }
}
