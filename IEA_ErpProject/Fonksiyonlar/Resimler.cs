using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Fonksiyonlar
{
    public class Resimler
    {
        public byte[] ResimYukle(Image resim)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                resim.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public Image ResimGetirme(byte[] gelenByteArray)
        {
            using (MemoryStream ms = new MemoryStream(gelenByteArray))
            {
                Image resim = Image.FromStream(ms);
                return resim;
            }
        }
    }
}
