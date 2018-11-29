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
    public partial class SectionForm : Form
    {

        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private List<int> IDS = new List<int>();
        private List<int> Manager_IDS = new List<int>();

        public SectionForm()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT * FROM section");
            Update();
        }

        private void AddSection_Click(object sender, EventArgs e)
        {
            int Manager_id = Manager_IDS[Manager.SelectedIndex];

            int MSID = Constants.GetMaxID(ref MSC, "SELECT MAX(id) AS id FROM section") + 1;
            MySqlCommand C = new MySqlCommand("INSERT INTO section VALUES(@id, @name, @manager_id)", MSC);

            C.Parameters.Add("@id", MSID);
            C.Parameters.Add("@name", SectionName.Text);
            C.Parameters.Add("@manager_id", Manager_id);

            C.ExecuteNonQuery();


            int MPID = Constants.GetMaxID(ref MSC, "SELECT MAX(id) AS id FROM posts") + 1;
            C = new MySqlCommand("INSERT INTO posts VALUES(@id, @name)", MSC);

            C.Parameters.Add("@id", MPID);
            C.Parameters.Add("@name", "Зав. отдела \"" + SectionName.Text + "\"");

            C.ExecuteNonQuery();


            C = new MySqlCommand("UPDATE worker SET post_id = @post_id, section_id = @section_id WHERE id=@id", MSC);

            C.Parameters.Add("@post_id", MPID);
            C.Parameters.Add("@section_id", MSID);
            C.Parameters.Add("@id", Manager_id);

            C.ExecuteNonQuery();
            Update();

            MessageBox.Show("Отдел успешно добавлен! Должность начальника отдела учреждена! Начальник отдела успешно назначен!");
        }

        private void RemoveSection_Click(object sender, EventArgs e)
        {
            if (!IDS.Contains(Convert.ToInt32(DelID.Value)))
            {
                MessageBox.Show("Отдела с указанным ID не существует!");
                return;
            }

            MySqlCommand C = new MySqlCommand("DELETE FROM section WHERE id=@id", MSC);

            C.Parameters.Add("@id", Convert.ToInt32(DelID.Value));

            C.ExecuteNonQuery();
            Update();

            MessageBox.Show("Отдел успешно удален!");
        }

        private void Update()
        {
            DT = new DataTable();
            MDA.Fill(DT);
            SectionList.DataSource = DT;

            for (int i = 0; i < SectionList.RowCount; i++)
                IDS.Add(Convert.ToInt32(SectionList.Rows[i].Cells["id"].Value));

            if (IDS.Count == 0)
                RemoveSection.Enabled = false;
            else
            {
                RemoveSection.Enabled = true;
                DelID.Minimum = IDS.Min();
                DelID.Maximum = IDS.Max();
            }

            MySqlDataAdapter MDA_Manager = new MySqlDataAdapter();
            DataTable DT_Manager = new DataTable();

            MDA_Manager.SelectCommand = new MySqlCommand("SELECT * FROM worker", MSC);
            MDA_Manager.Fill(DT_Manager);

            for(int i = 0; i < DT_Manager.Rows.Count; i++) {

                Manager_IDS.Add(Convert.ToInt32(DT_Manager.Rows[i]["id"]));
                Manager.Items.Add(DT_Manager.Rows[i]["surname"].ToString() + " " + 
                                  DT_Manager.Rows[i]["name"].ToString() + " " + 
                                  DT_Manager.Rows[i]["fathername"].ToString());
            }

            if (Manager.Items.Count == 0)
                AddSection.Enabled = false;
            else
            {
                AddSection.Enabled = true;
                Manager.SelectedIndex = 0;
            }
        }
    }
}
