using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using 記帳1.Models;

namespace 記帳1
{
    internal class Director
    {
        public DateTime datetime1;
        public DateTime datetime2;
        public string IncomeExpense;
        public string Item;
        public string Paymethod;
        
        
        public Director(DateTime dateTime1, DateTime dateTime2, string IncomeExpense, string Item, string Paymethod) 
        {
            this.datetime1 = dateTime1;
            this.datetime2 = dateTime2;
            this.IncomeExpense = IncomeExpense;
            this.Item = Item;
            this.Paymethod = Paymethod;
        }
        
        public Chart Construct (ChartType chartType)
        {
            Chart chart = null;
            switch (chartType)
            {
                case ChartType.直條圖:
                     chart = new BarChartBuilder().Datapreprocess(datetime1, datetime2 , IncomeExpense, Item, Paymethod)
                                                  .ReadData()
                                                  .CreateChart();
                    
                    
                    break;

                case ChartType.圓餅圖:
                    chart = new PieChartBuilder().Datapreprocess(datetime1, datetime2, IncomeExpense, Item, Paymethod)
                                                 .ReadData()
                                                 .CreateChart();


                    break;
                case ChartType.折線圖:
                    chart = new LineChartBuilder().Datapreprocess(datetime1, datetime2)
                                                 .ReadData()
                                                 .CreateChart();


                    break;
            }
            return chart;


        } 
    }

    class Student { 
        protected string name;
      public Student showInfo()
        {
            return this;
        }
    }
}
