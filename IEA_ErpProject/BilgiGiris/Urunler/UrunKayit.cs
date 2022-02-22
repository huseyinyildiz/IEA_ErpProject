using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.BilgiGiris.Firmalar;
using IEA_ErpProject.Entity;
using IEA_ErpProject.Fonksiyonlar;
using IEA_ErpProject.Properties;

namespace IEA_ErpProject.BilgiGiris.Urunler
{
    public partial class UrunKayit : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private Numaralar n = new Numaralar();
        private Resimler r = new Resimler();
        private bool _resim = false;
        Formlar f = new Formlar();
        OpenFileDialog _dosya = new OpenFileDialog();
        public UrunKayit()
        {
            InitializeComponent();
        }

        private void UrunKayit_Load(object sender, EventArgs e)
        {
            txtUrunId.Text=n.UidNo();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        private void ResimSec()
        {
            _dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (_dosya.ShowDialog() == DialogResult.OK)
            {
                pbResim.ImageLocation = _dosya.FileName;
                _resim = true;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, txtUrunId.ClientSize.Height);
            btn.Location = new Point(txtUrunId.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            txtUrunId.Controls.Add(btn);


            var btnFirma = new Button();
            btnFirma.Size = new Size(25, txtFirmaKodu.ClientSize.Height);
            btnFirma.Location = new Point(txtFirmaKodu.ClientSize.Width - btnFirma.Width - 1);
            btnFirma.Cursor = Cursors.Default;
            btnFirma.BackgroundImage = Resources.Ara32x32;
            btnFirma.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            btnFirma.BackgroundImageLayout = ImageLayout.Stretch;
            txtFirmaKodu.Controls.Add(btnFirma);





            base.OnLoad(e);
            btn.Click += BtnUrun_Click;
            btnFirma.Click += BtnFirma_Click;
        }

        private void BtnFirma_Click(object sender, EventArgs e)
        {
           
            int id = f.FirmalarListesiAc(true);
            if (id > 0)
            {
                FirmaAc(id);
            }
            AnaSayfa.Aktarma = -1;
        }

        private void FirmaAc(int id)
        {   int cariId = id;
            tblFirmalar frm = _db.tblFirmalar.First(s => s.Id == cariId);
            txtFirmaKodu.Text = frm.Id.ToString().PadLeft(7, '0');
            txtFirmaAdi.Text = frm.Adi;
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            int id = f.UrunKayitListesiAc(true);
            if (id > 0)
            {
                UrunAc(id);
            }
            AnaSayfa.Aktarma = -1;
        }

        private void UrunAc(int id)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void YeniKaydet()
        {
            Liste.AllowUserToAddRows = false;
            if (txtUrunId.Text == "" && txtUrunKodu.Text=="")
            {
                MessageBox.Show("İlgili alanları doldurun");
                return;
            }

            tblUrunKayitUst ust = new tblUrunKayitUst();
            ust.AciklamaEng = txtAcıklamaEng.Text;
            ust.AciklamaTr = txtAcıklamaTr.Text;
            ust.GirisTarih = txtGirisTarih.Value;
            ust.FirmaId = int.Parse(txtFirmaKodu.Text);
            if(pbResim.Image!=null) ust.Resim = new System.Data.Linq.Binary(r.ResimYukle(pbResim.Image)).ToArray();
            ust.Uid = int.Parse(txtUrunId.Text);
            ust.UrunKodu = txtUrunKodu.Text;

            _db.tblUrunKayitUst.Add(ust);


            tblUrunKayitAlt[] alt = new tblUrunKayitAlt[Liste.RowCount];
            for (int i = 0; i < Liste.RowCount; i++)
            {
                alt[i] = new tblUrunKayitAlt();
                alt[i].Aciklama = txtAcıklamaTr.Text;
                alt[i].BirimFiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                alt[i].Bransadi = "";
                alt[i].GMDMKodu = Liste.Rows[i].Cells[0].Value.ToString();
                alt[i].UNSPCKodu = Liste.Rows[i].Cells[1].Value.ToString();
                alt[i].KullanimDisi = Convert.ToBoolean(Liste.Rows[i].Cells[3].Value);
                alt[i].SB = Convert.ToBoolean(Liste.Rows[i].Cells[2].Value);
                alt[i].MinFiyat = Convert.ToDecimal(TxtMinFiyat.Text);
                alt[i].ParaBirimi = TxtParaBirimi.Text;
                alt[i].Sinif = txtSinifi.Text;
                alt[i].Sut = Liste.Rows[i].Cells[5].Value.ToString();
                alt[i].SutFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                alt[i].SutAciklama = Liste.Rows[i].Cells[7].Value.ToString();
                alt[i].Ubb = Liste.Rows[i].Cells[4].Value.ToString();
                alt[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                alt[i].Uid = int.Parse(txtUrunId.Text);
                alt[i].UIKodu = txtUrunKodu.Text;

                _db.tblUrunKayitAlt.Add(alt[i]);
            }




            _db.SaveChanges();

            MessageBox.Show("Kayıt yaptın çıkabilirsin.");

            Temizle();
        }

        private void Temizle()
        {
            foreach (Control item in spcUrunKayit.Panel1.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    if (item.Name!=txtUrunId.Name)
                    {
                        item.Text = "";
                    }
                    
                }

                pbResim.Image = null;
            }
            Liste.Rows.Clear();
            Liste.Rows.Add();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
