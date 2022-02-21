using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity;

namespace IEA_ErpProject.BilgiGiris.Urunler
{
    public partial class UrunKayitListesi : Form
    {
        public bool Secim = false;
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        public UrunKayitListesi()
        {
            InitializeComponent();
        }

        private void UrunKayitListesi_Load(object sender, EventArgs e)
        {

        }
    }
}
