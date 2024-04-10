using CSV1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 記帳1.Models;
using 記帳1.Extensions;

namespace 記帳1
{
    public partial class 帳戶 : Form
    {
        public 帳戶()
        {
            InitializeComponent();
        }

        private void 帳戶_Load(object sender, EventArgs e)
        {
            this.InitComboBox();
        }
        private void InitComboBox()
        {
            IncomeExpense.SetDatas(new string[] { "請選擇","支出", "收入" });

            Item.SetDatas(new string[] { "請選擇","交通", "購物", "餐飲", "醫療", "居家", "娛樂", "教育" });
            
            Paymethod.SetDatas(new string[] { "請選擇","現金", "悠遊卡", "信用卡", "LINY PAY", "Apple PAY", "街口支付" });

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MVC/MVCS/MVP/MVVM
            // MVC
            // C-Controller 要輕 => M&V 溝通橋梁
            // M-Model 要重 => 商業邏輯 流程控制 功能實作
            // S-Service  => 功能實作
            // V-View 要笨 => 最無腦的
            CsvService csvService = new CsvService();
            List<CostItem> datas = csvService.GetDatasbyDayrange(dateTimePicker1.Value, dateTimePicker2.Value);
            ShowDetails(csvService.Groupbydatas(datas, IncomeExpense.Text, Item.Text, Paymethod.Text));
  
            //foreach (var result in results)
            //{
            //    Console.WriteLine(result.Key +":"+result.Value);
            //}
            //ShowDetails(results);

        }

        private void ShowDetails(List<KeyValueModel> list)
        {
            foreach (var item in list)
            {
                Label lblitem = new Label();
                Label lblprice = new Label();
                lblitem.Text = item.Key;
                lblprice.Text = item.Value.ToString();
                flowLayoutPanel1.Controls.Add(lblitem);
                flowLayoutPanel1.Controls.Add(lblprice);
            }

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            

        }
    }
}
