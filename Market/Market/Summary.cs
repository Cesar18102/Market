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
            Constants.Init(ref MSC, ref MDA, "SELECT SUM(D.price) AS got FROM deals D WHERE D.date >= '" +
                                              Constants.FormatDateTime(Start.Value) + "' AND D.date <= '" + 
                                              Constants.FormatDateTime(End.Value) + "'");

            DT = new DataTable();
            MDA.Fill(DT);

            double got = Convert.ToDouble(DT.Rows[0]["got"] == DBNull.Value ? 0 : DT.Rows[0]["got"]);

            Constants.Init(ref MSC, ref MDA, "SELECT SUM(P.price) AS spent FROM provider_product P WHERE P.date >= '" +
                                              Constants.FormatDateTime(Start.Value) + "' AND P.date <= '" +
                                              Constants.FormatDateTime(End.Value) + "'");

            DT = new DataTable();
            MDA.Fill(DT);

            double spent = Convert.ToDouble(DT.Rows[0]["spent"] == DBNull.Value ? 0 : DT.Rows[0]["spent"]);

            Profit.Text = (got - spent).ToString();
        }

    }
}
