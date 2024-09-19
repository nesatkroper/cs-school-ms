using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_school_ms.service
{
    public class method
    {
        public static string BrowseImage()
        {
            string imgLocation = null;

            try
            {
                OpenFileDialog dailog = new OpenFileDialog();
                dailog.Filter = "PNG files(*.png)|*.png| jpg files(*.jpg)|*.jpg| All Files(*.*)|*.*";
                if (dailog.ShowDialog() == DialogResult.OK)
                    imgLocation = dailog.FileName.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return imgLocation;
        }

        public static string CopyImage_ToDestination(string desFolderName, string ImgLocation)
        {
            string imgDesPath = null, imgName = Path.GetFileName(ImgLocation);

            if (!Directory.Exists(desFolderName))
                Directory.CreateDirectory(desFolderName);

            try
            {
                if (!string.IsNullOrEmpty(ImgLocation))
                {
                    imgDesPath = Path.Combine(Application.StartupPath, desFolderName, imgName);
                    File.Copy(ImgLocation, imgDesPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return imgName;
        }
    }
}
