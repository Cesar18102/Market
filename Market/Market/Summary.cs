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
    public partial class Summary : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        public Summary()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            Constants.Init(ref MSC, ref MDA, "SELECT SUM(D.price) - SUM(P.price) AS profit FROM provider_product P, deals D WHERE P.date >= '" +
                                    Constants.FormatDateTime(Start.Value) + "' AND P.date <= '" + Constants.FormatDateTime(End.Value) + "' AND D.date >= '" +
                                    Constants.FormatDateTime(Start.Value) + "' AND D.date <= '" + Constants.FormatDateTime(End.Value) + "'");

            DT = new DataTable();
            MDA.Fill(DT);

            string profit = DT.Rows[0]["profit"].ToString();

            Profit.Text = profit == "" ? "0" : profit;
        }

    }
}
