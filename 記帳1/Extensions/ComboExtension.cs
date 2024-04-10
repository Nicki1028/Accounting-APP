using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 記帳1.Models;

namespace 記帳1.Extensions
{
    internal static class ComboExtension
    {     
        public static void SetDatas(this ComboBox comboBox, IEnumerable<string> data)
        {
            comboBox.DataSource = null;
            List<KeyValueModel> keydata = new List<KeyValueModel>();

            int index = 1;
            foreach (var item in data)
            {
                keydata.Add(new KeyValueModel(item, index++));

            }          
            comboBox.DataSource = keydata;
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
        }
    }
}
