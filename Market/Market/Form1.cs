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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Worker_Click(object sender, EventArgs e)
        {
            WorkerForm WF = new WorkerForm();
            WF.ShowDialog();
        }

        private void Section_Click(object sender, EventArgs e)
        {
            SectionForm SCF = new SectionForm();
            SCF.ShowDialog();
        }

        private void Post_Click(object sender, EventArgs e)
        {
            PostForm PTF = new PostForm();
            PTF.ShowDialog();
        }

        private void Provider_Click(object sender, EventArgs e)
        {
            ProviderForm PVF = new ProviderForm();
            PVF.ShowDialog();
        }

        private void Supply_Click(object sender, EventArgs e)
        {
            SupplyForm SPF = new SupplyForm();
            SPF.ShowDialog();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            ProductForm PDF = new ProductForm();
            PDF.ShowDialog();
        }

        private void Deal_Click(object sender, EventArgs e)
        {
            DealForm DF = new DealForm();
            DF.ShowDialog();
        }

        private void Storage_Click(object sender, EventArgs e)
        {
            Storage S = new Storage();
            S.ShowDialog();
        }

        private void Summary_Click(object sender, EventArgs e)
        {
            Summary S = new Summary();
            S.ShowDialog();
        }
    }
}
