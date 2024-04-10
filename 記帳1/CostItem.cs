using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 記帳1
{
    internal class CostItem
    {
        [DisplayName("日期")]
        public string Datetime { get; set; }
        [DisplayName("收支出")]
        public string Incomexpense { get; set; }
        [DisplayName("類別")]
        public string Item { get; set; }
        [DisplayName("細項")]
        public string Detail { get; set; }
        [DisplayName("支出方式")]
        public string Paymethod { get; set; }
        [DisplayName("金額")]
        public string Money { get; set; }
        [DisplayName("收據/發票")]
        public string Picture1Path { get; set; }
        [DisplayName("產品圖片")]
        public string Picture2Path { get; set; }
        public CostItem() { }
       

    }
}
