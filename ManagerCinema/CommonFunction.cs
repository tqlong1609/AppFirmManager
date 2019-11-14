using System;
using System.Data;
using System.Drawing;
using System.IO;

namespace ManagerCinema
{
    public class CommonFunction
    {
        private const string FORMAT_MONNEY = "{0:#,##0}"; // format: 20,000

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

        public static string formatMonney(int monney)
        {
            return string.Format(FORMAT_MONNEY, monney);
        }

        public static int getIdOnTime()
        {
            DateTime dateTime = DateTime.Now;
            string hour = dateTime.Hour.ToString();
            string minutes = dateTime.Minute.ToString();
            string secound = dateTime.Second.ToString();
            string miliSecound = dateTime.Millisecond.ToString();
            return int.Parse(hour + minutes + secound + miliSecound);
        }
    }


}
