using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 記帳1
{
    public partial class Navbar : UserControl
    {
        public Navbar()
        {
            InitializeComponent();
        }

       
        private void changeform(object sender, EventArgs e)
        {           
            Button button = (Button)sender;
           
            Singletonform.ChangeForm(button.Text);
           
        }
    }
}
