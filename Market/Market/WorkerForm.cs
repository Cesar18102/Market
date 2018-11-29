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
    public partial class WorkerForm : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private List<int> IDS = new List<int>();
        private List<int> Section_IDS = new List<int>();
        private List<int> Post_IDS = new List<int>();

        public WorkerForm()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT * FROM worker");
            Update();
        }

        private void HireWorker_Click(object sender, EventArgs e)
        {
            MySqlCommand C = new MySqlCommand("INSERT INTO worker VALUES(@id, @name, @surname, @fathername, @post_id, @address, @phone, @section_id)", MSC);

            C.Parameters.Add("@id", 0);
            C.Parameters.Add("@name", WorkerName.Text);
            C.Parameters.Add("@surname", WorkerSurname.Text);
            C.Parameters.Add("@fathername", WorkerFathername.Text);
            C.Parameters.Add("@post_id", Post_IDS[WorkerPost.SelectedIndex]);
            C.Parameters.Add("@address", WorkerAddress.Text);
            C.Parameters.Add("@phone", WorkerPhone.Text);

            if(WorkerSection.SelectedIndex == -1)
                C.Parameters.Add("@section_id", DBNull.Value);
            else
                C.Parameters.Add("@section_id", Section_IDS[WorkerSection.SelectedIndex]);

            C.ExecuteNonQuery();

            Update();

            MessageBox.Show("Сотрудник успешно нанят!");
        }

        private void FireWorker_Click(object sender, EventArgs e)
        {

            Update();
        }

        private void Update()
        {
            DT = new DataTable();
            MDA.Fill(DT);
            WorkerList.DataSource = DT;

            for (int i = 0; i < WorkerList.RowCount; i++)
                IDS.Add(Convert.ToInt32(WorkerList.Rows[i].Cells["id"].Value));

            if (IDS.Count == 0)
                FireWorker.Enabled = false;
            else
            {
                FireWorker.Enabled = true;
                DelID.Minimum = IDS.Min();
                DelID.Maximum = IDS.Max();
            }


            MySqlDataAdapter MDA_Section = new MySqlDataAdapter();
            DataTable DT_Section = new DataTable();

            MDA_Section.SelectCommand = new MySqlCommand("SELECT * FROM section", MSC);
            MDA_Section.Fill(DT_Section);

            for (int i = 0; i < DT_Section.Rows.Count; i++) {

                Section_IDS.Add(Convert.ToInt32(DT_Section.Rows[i]["id"]));
                WorkerSection.Items.Add(DT_Section.Rows[i]["name"].ToString());
            }

            if (WorkerSection.Items.Count != 0)
                WorkerSection.SelectedIndex = 0;


            MySqlDataAdapter MDA_Post = new MySqlDataAdapter();
            DataTable DT_Post = new DataTable();

            MDA_Post.SelectCommand = new MySqlCommand("SELECT * FROM posts", MSC);
            MDA_Post.Fill(DT_Post);

            for (int i = 0; i < DT_Post.Rows.Count; i++) {

                Post_IDS.Add(Convert.ToInt32(DT_Post.Rows[i]["id"]));
                WorkerPost.Items.Add(DT_Post.Rows[i]["name"].ToString());
            }

            if (Post_IDS.Count == 0)
                HireWorker.Enabled = false;
            else
            {
                WorkerPost.SelectedIndex = 0;
                HireWorker.Enabled = true;
            }
        }
    }
}
