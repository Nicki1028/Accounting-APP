using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace 記帳1
{
    abstract class ChartBuilder
    {
         
        public abstract ChartBuilder Datapreprocess(DateTime dateTime1, DateTime dateTime2, string IncomeExpense = null, string Item = null, string Paymethod = null);
        public abstract ChartBuilder ReadData();
        public abstract Chart CreateChart();

        protected Chart InitChart()
        {
            Chart chart = new Chart();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);

            return chart;
        }
            

    }
}
