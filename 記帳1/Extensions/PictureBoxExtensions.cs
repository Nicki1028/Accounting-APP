using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 記帳1
{
    internal static class PictureBoxExtensions
    {
        public static void Savepicture(this PictureBox pictureBox, DateTimePicker dateTimePicker, string picturepath)
        {
            if (!Directory.Exists($"C:\\Users\\USER\\Desktop\\CSharp\\CSV1\\{dateTimePicker.Value.ToString("yyyy-MM-dd")}"))
            {
                Directory.CreateDirectory($"C:\\Users\\USER\\Desktop\\CSharp\\CSV1\\{dateTimePicker.Value.ToString("yyyy-MM-dd")}");
            }
       
            pictureBox.Image.Save(picturepath);
                
        }
        public static void Loadpicture(this PictureBox pictureBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName); //new Bitmap(openFileDialog.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        
    }
}
