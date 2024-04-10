using CSV1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 記帳1
{
    internal static class PictureColumnExtensions
    {
        public static void CreateColumn(this DataGridView dataGridView, List<CostItem>list)
        {
            dataGridView.DataSource = null;

            while (dataGridView.ColumnCount > 0)
            {
                dataGridView.Columns.RemoveAt(dataGridView.ColumnCount - 1);
            }
            GC.Collect();

            dataGridView.DataSource = list;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns[6].Visible = false;
            dataGridView.Columns[7].Visible = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.BackgroundColor = Color.White;

            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
            iconColumn.HeaderText = "收據/發票";
            dataGridView.Columns.Add(iconColumn);
            DataGridViewImageColumn iconColumn2 = new DataGridViewImageColumn();
            iconColumn2.HeaderText = "產品圖片";
            dataGridView.Columns.Add(iconColumn2);
            DataGridViewImageColumn iconColumn3 = new DataGridViewImageColumn();
            iconColumn3.HeaderText = "刪除";
            dataGridView.Columns.Add(iconColumn3);

            for (int i = 0; i < list.Count; i++)
            {
                dataGridView.Rows[i].Cells[8].Value = Image.FromFile(list[i].Picture1Path);
                dataGridView.Rows[i].Cells[9].Value = Image.FromFile(list[i].Picture2Path);
                dataGridView.Rows[i].Cells[10].Value = Image.FromFile("C:\\Users\\USER\\Desktop\\CSharp\\CSV1\\CSV1\\trash.png");
            }

        }


    }
}
