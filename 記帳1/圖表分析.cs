using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using 記帳1.Extensions;
using 記帳1.Models;

namespace 記帳1
{
    public partial class 圖表分析 : Form
    {
        public 圖表分析()
        {
            InitializeComponent();
        }

        private void 圖表分析_Load(object sender, EventArgs e)
        {
            this.InitComboBox();
        }
        private void InitComboBox()
        {
            IncomeExpense.SetDatas(new string[] { "請選擇", "支出", "收入" });

            Item.SetDatas(new string[] { "請選擇", "交通", "購物", "餐飲", "醫療", "居家", "娛樂", "教育" });

            Paymethod.SetDatas(new string[] { "請選擇", "現金", "悠遊卡", "信用卡", "LINY PAY", "Apple PAY", "街口支付" });

            List<KeyValueModel> list = new List<KeyValueModel>();
            list.Add(new KeyValueModel("圓餅圖", 1));
            list.Add(new KeyValueModel("直條圖", 2));
            list.Add(new KeyValueModel("折線圖", 3));

            ChartType.DataSource = list;
            ChartType.DisplayMember = "Key";
            ChartType.ValueMember = "Value";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //CsvService csvService = new CsvService();
            //List<CostItem> datas = csvService.GetDatasbyDayrange(dateTimePicker1.Value, dateTimePicker2.Value);
            //ShowLineChart(datas);
            //ShowDetails(csvService.Groupbydatas(datas, IncomeExpense.Text, Item.Text, Paymethod.Text));
            flowLayoutPanel1.Controls.Clear();
            Director director = new Director(dateTimePicker1.Value, dateTimePicker2.Value, IncomeExpense.Text, Item.Text, Paymethod.Text);
            Chart chart = director.Construct((ChartType)ChartType.SelectedValue);
            
            flowLayoutPanel1.Controls.Add(chart);

        }
        
        //private void ShowLineChart(List<CostItem> list)
        //{
        //    int batchsize = 30;
        //    List<List<KeyValueModel>> batches = SplitIntoBatches(list, batchsize);

        //    foreach (var item in batches)
        //    {
        //        List<string> x = new List<string>();
        //        List<double> y = new List<double>();
        //        foreach (var val in item)
        //        {
        //            x.Add(val.Key);
        //            y.Add(val.Value);
        //        }
        //        Series series = new Series();
        //        series.Points.DataBindXY(x, y);
        //        chart1.Series.Add(series);
        //    }

        //    for (int i = 0; i < chart1.Series.Count; i++)
        //    {
        //        chart1.Series[i].ChartType = SeriesChartType.Line;
        //    }
        //}
        //private void ShowPieChart(List<KeyValueModel> list)
        //{

        //    List<string> x = new List<string>();
        //    List<double> y = new List<double>();
        //    foreach (var item in list)
        //    {
        //        x.Add(item.Key);
        //        y.Add(Math.Round(item.Value / (double)list.Sum(itemValue => itemValue.Value) * 100, 2));
        //    }

        //    chart1.Series[0].Points.DataBindXY(x, y);
        //    chart1.Series[0].IsValueShownAsLabel = true;
        //    chart1.Series[0].ChartType = SeriesChartType.Pie;
        //}

        private List<List<KeyValueModel>> SplitIntoBatches(List<CostItem> source, int batchSize)
        {
            List<List<KeyValueModel>> batches = new List<List<KeyValueModel>>();

            for (int i = 0; i < source.Count; i += batchSize)
            {
                List<CostItem> batch = new List<CostItem>(source.GetRange(i, Math.Min(batchSize, source.Count - i)));
                batches.Add(batch.GroupBy(x => DateTime.Parse(x.Datetime).ToString("yyyy-MM")).Select(x => new KeyValueModel(x.Key, x.Sum(z => int.Parse(z.Money)))).ToList());
            }
            return batches;
        }

            

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
