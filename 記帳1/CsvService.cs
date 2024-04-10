using CSV1;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 記帳1.Models;

namespace 記帳1
{
    internal class CsvService
    {
        public List<CostItem> GetDatasbyDayrange(DateTime dateTime1, DateTime dateTime2)
        {
            List<CostItem> list = new List<CostItem>();
            CsvHelper read = new CsvHelper();
            TimeSpan span = dateTime2 - dateTime1;

            for (int i = 0; i <= span.Days; i++)
            {
                if (File.Exists($"{ConfigurationManager.AppSettings["filePath"]}{(dateTime1.AddDays(i).ToString("yyyy-MM-dd"))}\\{dateTime1.AddDays(i).ToString("yyyy-MM-dd")}.csv"))
                {
                    string csv = $"{ConfigurationManager.AppSettings["filePath"]}{(dateTime1.AddDays(i).ToString("yyyy-MM-dd"))}\\{dateTime1.AddDays(i).ToString("yyyy-MM-dd")}.csv";
                    list.AddRange(read.Read<CostItem>(csv));
                }
            }
            return list;
        }
       
        public void WriteCsv(DateTime dateTime1, CostItem goods)
        {
            CsvHelper csvwrite = new CsvHelper();
            string finalcsvpath = $"{ConfigurationManager.AppSettings["filePath"]}{dateTime1.ToString("yyyy-MM-dd")}\\{dateTime1.ToString("yyyy-MM-dd")}.csv";
            csvwrite.Write(goods, finalcsvpath);
        }
        
        public List<CostItem> ReadCsv(DateTime dateTime1)
        {
            CsvHelper csvread = new CsvHelper();
            string csvpath = $"{ConfigurationManager.AppSettings["filePath"]}{dateTime1.ToString("yyyy-MM-dd")}\\{dateTime1.ToString("yyyy-MM-dd")}.csv";
            return csvread.Read<CostItem>(csvpath);
        }
        
        public List<KeyValueModel> Groupbydatas(List<CostItem> datas, string IncomeExpense, string Item, string Paymethod)
        {
            var finaldatas = datas.Where(x => IncomeExpense != "請選擇" ? x.Incomexpense == IncomeExpense : true)
                 .Where(x => Item != "請選擇" ? x.Item == Item : true)
                 .Where(x => Paymethod != "請選擇" ? x.Paymethod == Paymethod : true).ToList();

            var results = new List<KeyValueModel>();

            if (IncomeExpense != "請選擇" && Item != "請選擇" && Paymethod != "請選擇")
            {
                results = finaldatas.GroupBy(x => new { x.Incomexpense, x.Item, x.Paymethod }).Select(x => new KeyValueModel(x.Key.Incomexpense + x.Key.Item + "用" + x.Key.Paymethod, x.Sum(y => int.Parse(y.Money)))).ToList();
                
            }
            else if (IncomeExpense != "請選擇" && Item != "請選擇")
            {
                results = finaldatas.GroupBy(x => new { x.Paymethod }).Select(x => new KeyValueModel(x.Key.Paymethod, x.Sum(y => int.Parse(y.Money)))).ToList();
                
            }
            else if (IncomeExpense != "請選擇" && Paymethod != "請選擇")
            {
                results = finaldatas.GroupBy(x => new { x.Item }).Select(x => new KeyValueModel(x.Key.Item, x.Sum(y => int.Parse(y.Money)))).ToList();
                
            }
            else if (Item != "請選擇" && Paymethod != "請選擇")
            {
                results = finaldatas.GroupBy(x => new { x.Incomexpense }).Select(x => new KeyValueModel(x.Key.Incomexpense, x.Sum(y => int.Parse(y.Money)))).ToList();
                
            }
            else if (Paymethod != "請選擇")
            {
                results = finaldatas.GroupBy(x => new { x.Incomexpense, x.Item }).Select(x => new KeyValueModel(x.Key.Incomexpense + x.Key.Item, x.Sum(y => int.Parse(y.Money)))).ToList();
                
            }
            else if (Item != "請選擇")
            {
                results = finaldatas.GroupBy(x => new { x.Incomexpense, x.Paymethod }).Select(x => new KeyValueModel(x.Key.Incomexpense + "用" + x.Key.Paymethod, x.Sum(y => int.Parse(y.Money)))).ToList();
                
            }
            else if (IncomeExpense != "請選擇")
            {
                results = finaldatas.GroupBy(x => new { x.Item, x.Paymethod }).Select(x => new KeyValueModel(x.Key.Item + "用" + x.Key.Paymethod, x.Sum(y => int.Parse(y.Money)))).ToList();
                
            }
            return results;
        }
    }
}
