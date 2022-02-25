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
using IEA_ErpProject.Fonksiyonlar;
using IEA_ErpProject.Properties;

namespace IEA_ErpProject.UrunGirisIslemleri
{
    public partial class UrunGiris : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private Formlar f = new Formlar();
        public UrunGiris()
        {
            InitializeComponent();
        }

        private void UrunGiris_Load(object sender, EventArgs e)
        {

        }

        private void TxtCariTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (TxtCariTur.Text)
            //{
            //    case "Hastane":
            //        TxtCariAdi.Text = "Acibadem";
            //        break;
            //    case "Doktor":
            //        TxtCariAdi.Text = "Ömer Taser";
            //        break;
            //    case "Personel":
            //        TxtCariAdi.Text = "Huseyin";
            //        break;
            //    case "Firma":
            //        TxtCariAdi.Text = "Google";
            //        break;
            //    case "Diger":
            //        TxtCariAdi.Text = "Bilinmiyor";
            //        break;
            //}
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(22, TxtCariAdi.ClientSize.Height);
            btn.Location = new Point(TxtCariAdi.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TxtCariAdi.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += btn_Click;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int CariId = -1;
            switch (TxtCariTur.Text)
            {
                case "Hastane":
                    CariId = f.HastanelerListesiAc(true);
                    if (CariId > 0)
                    {
                        HastaneAc(CariId);
                    }
                    break;
                case "Doktor":
                    CariId = f.DoktorlarListesiAc(true);
                    if (CariId > 0)
                    {
                        DoktorAc(CariId);
                    }
                    break;
                case "Personel":
                    //CariId = f.PersonellerListesiAc(true);
                    //if (CariId > 0)
                    //{
                    //    DoktorAc(CariId);
                    //}
                    TxtCariAdi.Text = "Yapim Asamasinda";
                    break;
                case "Firma":
                    CariId = f.FirmalarListesiAc(true);
                    if (CariId > 0)
                    {
                        FirmaAc(CariId);
                    }
                    break;
                case "Diger":
                    TxtCariAdi.Text = "Bilinmiyor";
                    break;
            }
            AnaSayfa.Aktarma = -1;
        }

        private void FirmaAc(int cariId)
        {
            TxtCariAdi.Text = _db.tblFirmalar.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void HastaneAc(int cariId)
        {
            TxtCariAdi.Text = _db.tblHastaneler.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void DoktorAc(int id)
        {
            TxtCariAdi.Text = _db.tblDoktorlar.FirstOrDefault(s => s.Id == id)?.Adi;
        }
    }
}
