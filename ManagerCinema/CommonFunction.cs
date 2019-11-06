using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCinema
{
    public class CommonFunction
    {
        // this is function get id for insert 
        public static int getIdForInsert(DataTable dataTable)
        {
            int sum = 0;
            foreach(DataRow temp in dataTable.Rows)
            {
                if (temp["IdMovie"].ToString().Trim() == sum.ToString())
                {
                    sum++;
                }
                else
                    return sum;
            }
            return sum;
        }

        // convert string to image
        public static Image stringToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        // convert image to string
        public static string converImgToString(string path)
        {
            FileStream fs;
            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return Convert.ToBase64String(picbyte);
        }
    }

   
}
