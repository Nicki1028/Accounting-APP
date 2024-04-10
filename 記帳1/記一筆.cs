using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 記帳1.Extensions;
using 記帳1.Models;
using CSV1;
using System.IO;
using System.Configuration;

namespace 記帳1
{
    public partial class 記一筆 : Form
    {
        public 記一筆()
        {
            InitializeComponent();
        }

        private void navbar1_Load(object sender, EventArgs e)
        {

        }

        private void 記一筆_Load(object sender, EventArgs e)
        {
            this.InitComboBox();          
        }

        private void InitComboBox()
        {
            IncomeExpense.SetDatas(new string[] { "支出", "收入" });

            item.SetDatas(new string[] { "交通", "購物", "餐飲", "醫療", "居家", "娛樂", "教育" });

            Detail.SetDatas(new string[] { "加油", "公車", "捷運", "火車", "高鐵", "Uber" });
           
            Paymethod.SetDatas(new string[] { "現金", "悠遊卡", "信用卡", "LINY PAY", "Apple PAY", "街口支付" });

        }

        private void item_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (item.Text)
            {
                case "交通":                 
                    Detail.SetDatas(new string[] { "加油", "公車", "捷運", "火車", "高鐵", "Uber" });                 
                    break;
                case "購物":
                    Detail.SetDatas(new string[] { "3C", "化妝品","其他" });
                    break;
                case "餐飲":
                    Detail.SetDatas(new string[] { "早餐" , "午餐", "晚餐", "零食", "咖啡", "手搖飲", "牛奶", "其他" });
                    break;
                case "居家":
                    Detail.SetDatas(new string[] { "房租", "盥洗用品", "家用物品", "清洗用品" });
                    break;
                case "醫療":
                    Detail.SetDatas(new string[] { "掛號費", "健保費", "手術費" });
                    break;
                case "娛樂":
                    Detail.SetDatas(new string[] { "飯店住宿", "飛機費", "玩具用品", "健身費" });
                    break;
                case "教育":
                    Detail.SetDatas(new string[] { "書籍", "線上課程", "講座", "家教" });
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string picturepath1 = $"{ConfigurationManager.AppSettings["filePath"]}{dateTimePicker1.Value.ToString("yyyy-MM-dd")}\\{Guid.NewGuid().ToString()}.png";
            string picturepath2 = $"{ConfigurationManager.AppSettings["filePath"]}{dateTimePicker1.Value.ToString("yyyy-MM-dd")}\\{Guid.NewGuid().ToString()}.png";
            pictureBox1.Savepicture(dateTimePicker1, picturepath1);
            pictureBox2.Savepicture(dateTimePicker1, picturepath2);

            CostItem goods = new CostItem();
            goods.Datetime = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            goods.Incomexpense = IncomeExpense.Text;
            goods.Item = item.Text;       
            goods.Detail = Detail.Text;
            goods.Paymethod = Paymethod.Text;
            goods.Money = Money.Text;
            goods.Picture1Path = picturepath1;
            goods.Picture2Path = picturepath2;


            CsvService csvService = new CsvService();
            csvService.WriteCsv(dateTimePicker1.Value, goods);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Loadpicture();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Loadpicture();
        }
    }
}
