using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 記帳1
{
    internal class Singletonform
    {
        public static Form lastform = null;
        static Dictionary<string, Form> formlist = new Dictionary<string, Form>();
        private static Form GetForm(string formtext, Form form)
        {

            if (!formlist.ContainsKey(formtext))
            {
                formlist.Add(formtext, form);
            }

            return formlist[formtext];
        }

        public static void ChangeForm(string buttontext)
        {
            if (lastform != null)
            {
                lastform.Hide();
            }

            switch (buttontext)
            {
                case "記事本":

                    lastform = GetForm("記事本", new 記事本());

                    break;
                case "記一筆":

                    lastform = GetForm("記一筆", new 記一筆());

                    break;
                case "帳戶":

                    lastform = GetForm("帳戶", new 帳戶());

                    break;
                case "圖表分析":

                    lastform = GetForm("圖表分析", new 圖表分析());

                    break;
            }
            lastform.Show();
        }
    }
}
