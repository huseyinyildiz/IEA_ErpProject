using IEA_ErpProject.Entity;
using IEA_ErpProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    public partial class FirmaGiris : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private int secimId = -1;
        private tblFirmalar kayitBul;
        Fonksiyonlar.Formlar f = new Fonksiyonlar.Formlar();
        public FirmaGiris()
        {
            InitializeComponent();
        }

        private void FirmaGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void ComboDoldur()
        {

            TxtFirmaTip.DataSource = Enum.GetValues(typeof(FirmaTip));
            TxtFirmaTip.SelectedIndex = -1;

           
            TxtSehir.DataSource = _db.Sehirler.ToList();
            TxtSehir.ValueMember = "Id";
            TxtSehir.DisplayMember = "Name";
            TxtSehir.SelectedIndex = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (TxtFadi.Text == "")
            {
                MessageBox.Show("İlgili alanlar doldurulmadan kayıt yapılamaz.");
                return;
            }
            try
            {
                tblFirmalar firm = new tblFirmalar();
                firm.Adi = TxtFadi.Text;
                firm.Adres = TxtFAdres.Text;
                firm.FirmaTip = TxtFirmaTip.Text;
                if (TxtSehir.SelectedValue != null) firm.SehirId = (int)TxtSehir.SelectedValue;
                firm.VergiDairesi = txtFVergiDairesi.Text;
                firm.VergiNo = TxtFVergiNo.Text;

                _db.tblFirmalar.Add(firm);
                _db.SaveChanges();
                MessageBox.Show("Kayıt İşlemi Gerçekleştirildi.");
                Listele();
                Temizle();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "HataKodu : HGK100");

            }
        }

        private void Temizle()
        {
            foreach (Control k in ScFirma.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";
                }
               
                TxtSehir.SelectedIndex = -1;
                TxtFirmaTip.SelectedIndex = -1;

            }
        }

        private List<tblFirmalar> frmList;

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;

            frmList = (from s in _db.tblFirmalar select s).ToList();//Firmalar tablosunda bilgi getirir

            foreach (var item in frmList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.FirmaTip;

                if (item.Sehirler != null)
                {
                    Liste.Rows[i].Cells[4].Value = item.Sehirler.Name;
                }


                i++;

            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, TxtFirmaBul.ClientSize.Height);
            btn.Location = new Point(TxtFirmaBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            TxtFirmaBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = f.FirmalarListesiAc(true);
            if (id > 0)
            {
                Ac(id);
            }
            AnaSayfa.Aktarma = -1;
        }

        public void Ac(int id)
        {
            secimId = id;
            if (secimId < 0)
            {
                MessageBox.Show("Kayıt Id Bulunamadı.");
                return;

            }
            BtnDetayEkle.Visible = true;
            BtnDetayGoster.Visible = true;
            //tblHastaneler kayitBul = _db.tblHastaneler.Find(secimId); //DBden gelen ilgili ıd yi bulur kayıtbula atar
            kayitBul = frmList.FirstOrDefault(x => x.Id == secimId);

            try
            {
                if (kayitBul != null)
                {
                    TxtFVergiNo.Text = kayitBul.VergiNo;
                    TxtSehir.Text = kayitBul.Sehirler.Name;
                    TxtFAdres.Text = kayitBul.Adres;
                    TxtFirmaTip.Text = kayitBul.FirmaTip;
                    TxtFadi.Text = kayitBul.Adi;
                    txtFVergiDairesi.Text = kayitBul.VergiDairesi;
                    TxtFirmaBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Hata Kodu : HGListe101");
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Temizle();
            if (Liste.CurrentRow != null)
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value;

            }
            Ac(secimId);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            if (secimId < 0)
            {
                MessageBox.Show("Değiştirilecek kayıt bulunamadı, önce bir kayıt seçin.");
                return;
            }
            if (kayitBul != null)
            {
                kayitBul.VergiNo = TxtFVergiNo.Text;
                if (TxtSehir.SelectedValue != null)
                {
                    kayitBul.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);
                }

                kayitBul.Adres = TxtFAdres.Text;
                kayitBul.FirmaTip = TxtFirmaTip.Text;
                kayitBul.Adi = TxtFadi.Text;
                kayitBul.VergiDairesi = txtFVergiDairesi.Text;

            }
            _db.SaveChanges();
            MessageBox.Show("Güncelleme yapıldı.");
            Temizle();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId < 0)
            {
                MessageBox.Show("Silmek istediğiniz kaydı seçiniz.");
                return;
            }

            DialogResult dr = MessageBox.Show("Kayıt kalıcı olarak silinecektir, bu işlemi yapmak istediğinizden emin misiniz?!!", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void Sil()
        {
            if (secimId > 0)
            {
                _db.tblFirmalar.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydınız silinmiştir.Geçmiş olsun");
                Temizle();
                Listele();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
