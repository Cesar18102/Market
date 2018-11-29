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
    public partial class PostForm : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private List<int> IDS = new List<int>();

        public PostForm()
        {
            InitializeComponent();

            Constants.Init(ref MSC, ref MDA, "SELECT * FROM posts");
            Update();
        }

        private void AddPost_Click(object sender, EventArgs e)
        {
            int MPID = Constants.GetMaxID(ref MSC, "SELECT MAX(id) AS id FROM posts") + 1;
            MySqlCommand C = new MySqlCommand("INSERT INTO posts VALUES(@id, @name)", MSC);

            C.Parameters.Add("@id", MPID);
            C.Parameters.Add("@name", PostName.Text);

            C.ExecuteNonQuery();

            Update();
        }

        private void RemovePost_Click(object sender, EventArgs e)
        {
            if (!IDS.Contains(Convert.ToInt32(DelID.Value)))
            {
                MessageBox.Show("Должности с указанным ID не существует!");
                return;
            }

            MySqlCommand C = new MySqlCommand("DELETE FROM posts WHERE id=@id", MSC);
            C.Parameters.Add("@id", Convert.ToInt32(DelID.Value));
            C.ExecuteNonQuery();

            Update();
        }

        private void Update()
        {
            DT = new DataTable();
            MDA.Fill(DT);
            PostList.DataSource = DT;

            for (int i = 0; i < PostList.RowCount; i++)
                IDS.Add(Convert.ToInt32(PostList.Rows[i].Cells["id"].Value));

            if (IDS.Count == 0)
                RemovePost.Enabled = false;
            else
            {
                RemovePost.Enabled = true;
                DelID.Minimum = IDS.Min();
                DelID.Maximum = IDS.Max();
            }
        }
    }
}
