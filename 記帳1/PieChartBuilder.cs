using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using 記帳1.Models;

namespace 記帳1
{
    internal class PieChartBuilder: ChartBuilder
    {
        protected List<KeyValueModel> final;
        protected List<string> x = new List<string>();
        protected List<double> y = new List<double>();


        public override ChartBuilder Datapreprocess(DateTime dateTime1, DateTime dateTime2, string IncomeExpense, string Item, string Paymethod)
        {

            CsvService csvService = new CsvService();
            List<CostItem> datas = csvService.GetDatasbyDayrange(dateTime1, dateTime2);
            final = csvService.Groupbydatas(datas, IncomeExpense, Item, Paymethod);

            return this;
        }
        public override ChartBuilder ReadData()
        {

            foreach (var item in final)
            {
                x.Add(item.Key);               
                y.Add(Math.Round(item.Value / (double)final.Sum(itemValue => itemValue.Value) * 100, 2));
            }
            return this;

        }
        public override Chart CreateChart()
        {
            Chart chart = this.InitChart();
            chart.Series[0].Points.DataBindXY(x, y);
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].ChartType = SeriesChartType.Pie;
            return chart;
        }
    }
}

