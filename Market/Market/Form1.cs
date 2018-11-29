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
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Word;
using System.IO;
using MySql.Data.MySqlClient;

namespace Market
{
    public partial class Form1 : Form
    {
        private MySqlConnection MSC;
        private MySqlDataAdapter MDA;
        private DataTable DT;

        private Word.Application Application;
        private Word.Document Document;
        private Word.Range R;
        private Word.Table T;
        private Word.Paragraph P;
        private Object missingObj = System.Reflection.Missing.Value;
        private Object trueObj = true;
        private Object falseObj = false;

        public delegate string ValueAt<Q>(Q SP, int i);

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

        private void SypplyReport_Click(object sender, EventArgs e)
        {
            Constants.Init(ref MSC, ref MDA, "SELECT P.name, PP.date, PP.amount, PP.price FROM provider_product PP, product P WHERE P.id = PP.product_id");
            DataTable DT = new DataTable();
            MDA.Fill(DT);
            List<Supply> SPL = new List<Supply>();

            for (int i = 0; i < DT.Rows.Count; i++)
                SPL.Add(new Supply(DT.Rows[i]["name"].ToString(), (DateTime)DT.Rows[i]["date"], Convert.ToDouble(DT.Rows[i]["amount"]), Convert.ToDouble(DT.Rows[i]["price"])));


            PrintWord<Supply>(new List<string>() { "Продукт", "Дата поставки", "Количество", "Цена поставки" },
                            (S, i) => {

                                Supply SP = S as Supply;
                                switch (i) {

                                    case 0: return SP.product; break;
                                    case 1: return SP.date.Date.ToShortDateString(); break;
                                    case 2: return SP.amount.ToString(); break;
                                    case 3: return SP.price.ToString(); break;
                                    default: return ""; break;
                                }
                            }, SPL, "Отчет по поставкам");
        }

        private void DealReport_Click(object sender, EventArgs e)
        {
            Constants.Init(ref MSC, ref MDA, "SELECT P.name, D.date, D.amount, D.price FROM deals D, product P WHERE P.id = D.product_id");
            DataTable DT = new DataTable();
            MDA.Fill(DT);
            List<Supply> SPL = new List<Supply>();

            for (int i = 0; i < DT.Rows.Count; i++)
                SPL.Add(new Supply(DT.Rows[i]["name"].ToString(), (DateTime)DT.Rows[i]["date"], Convert.ToDouble(DT.Rows[i]["amount"]), Convert.ToDouble(DT.Rows[i]["price"])));


            PrintWord<Supply>(new List<string>() { "Продукт", "Дата поставки", "Количество", "Цена покупки" },
                            (S, i) =>
                            {

                                Supply SP = S as Supply;
                                switch (i)
                                {

                                    case 0: return SP.product; break;
                                    case 1: return SP.date.Date.ToShortDateString(); break;
                                    case 2: return SP.amount.ToString(); break;
                                    case 3: return SP.price.ToString(); break;
                                    default: return ""; break;
                                }
                            }, SPL, "Отчет по покупкам");
        }

        private void PrintWord<Q>(List<string> headers, ValueAt<Q> V, List<Q> Values, string head)
        {

            this.UseWaitCursor = true;
            FileStream FS = File.Create(Environment.CurrentDirectory + "/Print.doc");
            FS.Close();

            Application = new Word.Application();
            Object PrintPath = Environment.CurrentDirectory + "/Print.doc";

            Document = Application.Documents.Add(ref PrintPath, ref missingObj, ref missingObj, ref missingObj);
            Document.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            R = Document.Sections[1].Range;

            T = Document.Tables.Add(R, Values.Count + 2, headers.Count, missingObj, missingObj);
            T.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            T.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            T.Rows[1].Cells.Merge();
            T.Rows[1].Cells[1].Width = 698;
            T.Rows[1].Cells[1].Range.Text = head;
            T.Rows[1].Cells[1].Range.Font.Size = 18;
            T.Rows[1].Cells[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            T.Rows[1].Cells[1].Range.Borders.Enable = 0;

            for (int i = 1; i <= headers.Count; i++)
            {

                T.Rows[2].Cells[i].Width = 700 / headers.Count;
                T.Rows[2].Cells[i].Range.Text = headers[i - 1];

                T.Rows[2].Cells[i].Range.Font.Size = 14;
                T.Rows[2].Cells[i].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            }

            for (int i = 0; i < Values.Count; i++)
                for (int j = 0; j < headers.Count; j++)
                {
                    T.Rows[i + 3].Cells[j + 1].Width = 700 / headers.Count;
                    T.Rows[i + 3].Cells[j + 1].Range.Text = V(Values[i], j);
                }

            Document.Save();
            Document.Close(missingObj, missingObj, missingObj);
            this.UseWaitCursor = false;
        }
    }
}
