using CSV1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 記帳1
{
    internal static class FileExtensions
    {
        public static void FileDeleteandSave(this DateTimePicker dateTimePicker, List<CostItem> list)
        {
            File.Delete($"C:\\Users\\USER\\Desktop\\CSharp\\CSV1\\{dateTimePicker.Value.ToString("yyyy-MM-dd")}\\{dateTimePicker.Value.ToString("yyyy-MM-dd")}.csv");
            CsvHelper write = new CsvHelper();
            write.Writelist(list, $"C:\\Users\\USER\\Desktop\\CSharp\\CSV1\\{dateTimePicker.Value.ToString("yyyy-MM-dd")}\\{dateTimePicker.Value.ToString("yyyy-MM-dd")}.csv");
        }
    }
}
