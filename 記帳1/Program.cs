using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 記帳1
{
    internal static class Program
    {
        

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]

        
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            記一筆 form = new 記一筆();
            Singletonform.lastform = form;
            Application.Run(form);
        }
    }
}
