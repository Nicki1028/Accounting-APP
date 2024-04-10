using CSV1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 記帳1
{
    public partial class 記事本 : Form
    {
        List<CostItem> list = new List<CostItem>();
        public 記事本()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void navbar1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(($"{ConfigurationManager.AppSettings["filePath"]}{dateTimePicker1.Value.ToString("yyyy-MM-dd")}")))
            {
                CsvService csvService = new CsvService();
                list = csvService.ReadCsv(dateTimePicker1.Value);
                dataGridView1.CreateColumn(list);
            }
            else
            {
                MessageBox.Show("沒有此日的檔案");
            }

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (dataGridView1.Columns[e.ColumnIndex].HeaderText)
            {
                case "收支出":
                    list[e.RowIndex].Incomexpense = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(); 
                    break;
                case "類別":
                    list[e.RowIndex].Item = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    break;
                case "細項":
                    list[e.RowIndex].Detail = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    break;
                case "支出方式":
                    list[e.RowIndex].Paymethod = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    break;
                case "金額":
                    list[e.RowIndex].Money = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    break;

            }
           
            foreach (var data in list)
            {
                Console.WriteLine(data.Item + " " + data.Incomexpense + " " + data.Detail + " " + data.Money + " "+data.Paymethod);
            }

            dateTimePicker1.FileDeleteandSave(list);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "收據/發票")
            {
                PictureForm pictureForm = new PictureForm(list[e.RowIndex].Picture1Path.ToString());
                pictureForm.ShowDialog();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "產品圖片")
            {
                PictureForm pictureForm = new PictureForm(list[e.RowIndex].Picture2Path.ToString());
                pictureForm.ShowDialog();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "刪除")
            {
                                                           
                list.RemoveAt(e.RowIndex);
                dateTimePicker1.FileDeleteandSave(list);                             
                dataGridView1.CreateColumn(list);
                
            }
        }
    }
}
