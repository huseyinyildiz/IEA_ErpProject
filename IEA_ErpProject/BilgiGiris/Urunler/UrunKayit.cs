using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private int secimId = -1;

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            int id = f.UrunKayitListesiAc(true);
            if (id > 0)
            {
                UrunAc(id);
            }
            AnaSayfa.Aktarma = -1;
        }

        public void UrunAc(int uid)
        {
           
            Temizle();
            secimId = uid;
            Liste.AllowUserToAddRows = false;
            tblUrunKayitUst lst = _db.tblUrunKayitUst.FirstOrDefault(s => s.Uid == uid);

            txtAcıklamaEng.Text = lst.AciklamaEng;
            txtAcıklamaTr.Text = lst.AciklamaTr;
            txtGirisTarih.Text = lst.GirisTarih.ToString();
            
            if (lst.FirmaId!=null)
            {
                txtFirmaKodu.Text = lst.FirmaId.ToString();
                txtFirmaAdi.Text = lst.tblFirmalar.Adi;

            }
            
            txtUrunId.Text = lst.Uid.ToString().PadLeft(7,'0');
            txtUrunKodu.Text = lst.UrunKodu;
            txtKulSüre.Text = lst.KullanimSuresi.ToString();
            etiketId.Text = lst.Id.ToString().PadLeft(7,'0');
            if (lst.Resim != null) pbResim.Image = r.ResimGetirme(lst.Resim);

            var urunAlt = _db.tblUrunKayitAlt.Where(x => x.Uid == uid).ToList();
            var urnAltTek = _db.tblUrunKayitAlt.FirstOrDefault(x => x.Uid == uid);
            int i = 0;
            foreach (var alt in urunAlt)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = alt.GMDMKodu;
                Liste.Rows[i].Cells[1].Value = alt.UNSPCKodu;
                Liste.Rows[i].Cells[2].Value = alt.SB;
                Liste.Rows[i].Cells[3].Value = alt.KullanimDisi;
                Liste.Rows[i].Cells[4].Value = alt.Ubb;
                Liste.Rows[i].Cells[5].Value = alt.Sut;
                Liste.Rows[i].Cells[6].Value = alt.SutFiyat;
                Liste.Rows[i].Cells[7].Value = alt.SutAciklama;
                Liste.Rows[i].Cells[8].Value = alt.UTS;
                Liste.Rows[i].Cells[9].Value = false;
                Liste.Rows[i].Cells[10].Value = alt.Id;
               
                i++;
            }

            if (urnAltTek != null)
            {
                txtSinifi.Text = urnAltTek.Sinif;
                TxtParaBirimi.Text = urnAltTek.ParaBirimi;
                TxtMinFiyat.Text = urnAltTek.MinFiyat.ToString();
                TxtBirimFiyat.Text = urnAltTek.BirimFiyat.ToString();
            }

            // Liste.AllowUserToAddRows = false;
            // Liste.AllowUserToDeleteRows = false;
            // Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Liste.ReadOnly = true;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void YeniKaydet()
        {
            Liste.AllowUserToAddRows = false;
            if (txtUrunId.Text == "" || txtUrunKodu.Text=="" || txtFirmaKodu.Text=="")
            {
                MessageBox.Show("İlgili alanları doldurun");
                Liste.AllowUserToAddRows =true;
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
            ust.KullanimSuresi = int.Parse(txtKulSüre.Text);

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
            //Liste.Rows.Add();

            txtUrunId.Text = n.UidNo();
            secimId = -1;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            int a = Convert.ToInt32(txtUrunId.Text);
            Liste.AllowUserToAddRows = false;

            tblUrunKayitUst ust = _db.tblUrunKayitUst.FirstOrDefault(x => x.Uid == a);
            ust.AciklamaEng = txtAcıklamaEng.Text;
            ust.AciklamaTr = txtAcıklamaTr.Text;
            ust.GirisTarih = txtGirisTarih.Value;
            ust.FirmaId = int.Parse(txtFirmaKodu.Text);
           // if (pbResim.Image != null) ust.Resim = new System.Data.Linq.Binary(r.ResimYukle(pbResim.Image)).ToArray();
            ust.Uid = int.Parse(txtUrunId.Text);
            ust.UrunKodu = txtUrunKodu.Text;
            ust.KullanimSuresi = int.Parse(txtKulSüre.Text);

            _db.SaveChanges();

            List<tblUrunKayitAlt> alt = _db.tblUrunKayitAlt.Where(s => s.Uid == a).ToList();
            int ii = 0;
            foreach (var uAlt in alt)
            {
                if ((bool)Liste.Rows[ii].Cells[9].Value != true)
                {
                   // int indexId = alt[ii].Id;
                    //alt[ii] = _db.tblUrunKayitAlt.FirstOrDefault(s => s.Id == indexId);
                    uAlt.Aciklama = txtAcıklamaTr.Text;
                    uAlt.BirimFiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                    uAlt.Bransadi = "";
                    uAlt.GMDMKodu = Liste.Rows[ii].Cells[0].Value.ToString();
                    uAlt.UNSPCKodu = Liste.Rows[ii].Cells[1].Value.ToString();
                    uAlt.KullanimDisi = Convert.ToBoolean(Liste.Rows[ii].Cells[3].Value);
                    uAlt.SB = Convert.ToBoolean(Liste.Rows[ii].Cells[2].Value);
                    uAlt.MinFiyat = Convert.ToDecimal(TxtMinFiyat.Text);
                    uAlt.ParaBirimi = TxtParaBirimi.Text;
                    uAlt.Sinif = txtSinifi.Text;
                    uAlt.Sut = Liste.Rows[ii].Cells[5].Value.ToString();
                    uAlt.SutFiyat = Convert.ToDecimal(Liste.Rows[ii].Cells[6].Value);
                    uAlt.SutAciklama = Liste.Rows[ii].Cells[7].Value != null ? Liste.Rows[ii].Cells[7].Value.ToString() : "";

                    uAlt.Ubb = Liste.Rows[ii].Cells[4].Value.ToString();
                    uAlt.UTS = Convert.ToBoolean(Liste.Rows[ii].Cells[8].Value);
                    uAlt.Uid = int.Parse(txtUrunId.Text);
                    uAlt.UIKodu = txtUrunKodu.Text;
                    ii++;
                }
            }

            tblUrunKayitAlt[] yeni = new tblUrunKayitAlt[Liste.RowCount].ToArray();
            for (int i = 0; i < Liste.RowCount; i++)
            {
                if ((bool)Liste.Rows[i].Cells[9].Value == true)
                {
                    yeni[i] = new tblUrunKayitAlt();
                    yeni[i].Aciklama = txtAcıklamaTr.Text;
                    yeni[i].BirimFiyat = Convert.ToDecimal(TxtBirimFiyat.Text);
                    yeni[i].Bransadi = "";
                    yeni[i].GMDMKodu = Liste.Rows[i].Cells[0].Value.ToString();
                    yeni[i].UNSPCKodu = Liste.Rows[i].Cells[1].Value.ToString();
                    yeni[i].KullanimDisi = Convert.ToBoolean(Liste.Rows[i].Cells[3].Value);
                    yeni[i].SB = Convert.ToBoolean(Liste.Rows[i].Cells[2].Value);
                    yeni[i].MinFiyat = Convert.ToDecimal(TxtMinFiyat.Text);
                    yeni[i].ParaBirimi = TxtParaBirimi.Text;
                    yeni[i].Sinif = txtSinifi.Text;
                    yeni[i].Sut = Liste.Rows[i].Cells[5].Value.ToString();
                    yeni[i].SutFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                    yeni[i].SutAciklama = Liste.Rows[i].Cells[7].Value != null
                        ? Liste.Rows[i].Cells[7].Value.ToString()
                        : "";
                    yeni[i].Ubb = Liste.Rows[i].Cells[4].Value.ToString();
                    yeni[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                    yeni[i].Uid = int.Parse(txtUrunId.Text);
                    yeni[i].UIKodu = txtUrunKodu.Text;
                    _db.tblUrunKayitAlt.Add(yeni[i]);
                }
            }
            _db.SaveChanges();


        }

        private void BtnAddListeRow_Click(object sender, EventArgs e)
        {
            Liste.AllowUserToAddRows = Liste.AllowUserToAddRows != true;
            if (Liste.AllowUserToAddRows == true)
            {
                var srg = Liste.RowCount;
                if (Liste.CurrentRow != null) Liste.Rows[srg - 1].Cells[9].Value = true;
            }
            
        }

        private void btnRowsDelete_Click(object sender, EventArgs e)
        {
            if (secimId < 0)
            {
                MessageBox.Show("Önce kayıt seçin.");
                return;
                
            }
            tblUrunKayitAlt[] alt = new tblUrunKayitAlt[Liste.RowCount];
            int say=0;
            for (int i = 0; i < Liste.RowCount; i++)
            {
                if ((bool)Liste.Rows[i].Cells[9].Value==true)
                {
                    var srg = _db.tblUrunKayitAlt.Find(Liste.Rows[i].Cells[10].Value);
                    _db.tblUrunKayitAlt.Remove(srg);
                    say++;
                }
            }
            if (say == 0)
            {
                MessageBox.Show("Silinecek satır yok.Silmek istediğiniz satırın Durum Hücresini işaretleyin..");
                return;
            }

            try
            {
                if (_db.SaveChanges() > 0)
                {
                    MessageBox.Show("Satır silme işlemi yapıldı");
                    UrunAc(int.Parse(txtUrunId.Text));
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + " SQL - İşlem bilinmeyen bir sebepten ötürü başarısız.");
                throw;
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message + "C# - İslem bilmeyen bir sebepten ötürü yapılamadı");
            }

           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var srg = _db.tblUrunKayitUst.Find(int.Parse(etiketId.Text));
            var uid = _db.tblUrunKayitAlt.Where(s=>s.Uid == srg.Uid);
            _db.tblUrunKayitUst.Remove(srg);
            _db.tblUrunKayitAlt.RemoveRange(uid);
            try
            {
                if (_db.SaveChanges() > 0)
                {
                    MessageBox.Show("Satır silme işlemi yapıldı");
                    Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + " SQL - İşlem bilinmeyen bir sebepten ötürü başarısız.");
                throw;
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message + "C# - İslem bilmeyen bir sebepten ötürü yapılamadı");
            }
        }
    }
}
