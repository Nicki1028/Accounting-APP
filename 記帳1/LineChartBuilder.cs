using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using 記帳1.Models;

namespace 記帳1
{
    internal class LineChartBuilder:ChartBuilder
    {
       
        protected List<List<KeyValueModel>> batches = new List<List<KeyValueModel>>();
        protected List<string> x = new List<string>();
        protected List<double> y = new List<double>();

        public override ChartBuilder Datapreprocess(DateTime dateTime1, DateTime dateTime2, string IncomeExpense = null, string Item = null, string Paymethod=null)
        {
            CsvService csvService = new CsvService();
            List<CostItem> datas = csvService.GetDatasbyDayrange(dateTime1, dateTime2);         

            for (int i = 0; i < datas.Count; i += 30)
            {
                List<CostItem> batch = new List<CostItem>(datas.GetRange(i, Math.Min(30, datas.Count - i)));
                batches.Add(batch.GroupBy(x => DateTime.Parse(x.Datetime).ToString("yyyy-MM")).Select(x => new KeyValueModel(x.Key, x.Sum(z => int.Parse(z.Money)))).ToList());
            }                        
            //final = csvService.Groupbydatas(datas, IncomeExpense, Item, Paymethod);
            return this;
        }
        public override ChartBuilder ReadData()
        {
            foreach (var item in batches)
            {
                foreach (var val in item)
                {
                    x.Add(val.Key);
                    y.Add(val.Value);
                }              
            }
            return this;

        }
        public override Chart CreateChart()
        {           
            Chart chart = this.InitChart();
            
            chart.Series[0].Points.DataBindXY(x, y);
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].ChartType = SeriesChartType.Line;
                    
            return chart;
        }
    }
}

