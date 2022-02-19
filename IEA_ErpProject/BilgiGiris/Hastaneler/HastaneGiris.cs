using IEA_ErpProject.Entity;
using IEA_ErpProject.Fonksiyonlar;
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

namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    public partial class HastaneGiris : Form
    {

        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private int secimId = -1;
        private tblHastaneler kayitBul;
        Formlar f = new Formlar();
        public HastaneGiris()
        {
            InitializeComponent();
        }

        private void HastaneGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void ComboDoldur()
        {
            TxtTipAdi.DataSource = _db.tblHastaneTipleri.ToList();//select* from tblHastaneTipleri --> sgl e bu kod gidicek burdan gelen sonuç datasource un içine eklenecek artık veriler datasource da
            TxtTipAdi.ValueMember = "Id";
            TxtTipAdi.DisplayMember = "TipAdi";
            TxtTipAdi.SelectedIndex = -1;

            TxtSehir.DataSource = _db.Sehirler.ToList();
            TxtSehir.ValueMember = "Id";
            TxtSehir.DisplayMember = "name";
            TxtSehir.SelectedIndex = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (TxtHadi.Text == "")
            {
                MessageBox.Show("İlgili alanlar doldurulmadan kayıt yapılamaz.");
                return;
            }
            try
            {
                tblHastaneler hst = new tblHastaneler();
                hst.Adi = TxtHadi.Text;
                hst.Adres = TxtAdres.Text;
                hst.CariAdi = TxtCariHadi.Text;
                if (TxtSehir.SelectedValue != null) hst.SehirId = (int)TxtSehir.SelectedValue;
                if (TxtTipAdi.SelectedValue != null) hst.TipId = (int)TxtTipAdi.SelectedValue;
                hst.Tel = txtTelefon.Text;
                hst.VergiDairesi = txtVergiDairesi.Text;
                hst.VergiNo = TxtVergiNo.Text;

                _db.tblHastaneler.Add(hst);
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
            foreach (Control k in ScHastane.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";
                }
            }
            TxtTipAdi.SelectedIndex = -1;
            TxtSehir.SelectedIndex = -1;
            secimId = -1;
            kayitBul = null;
            BtnDetayEkle.Visible = false;
            BtnDetayGoster.Visible = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private List<tblHastaneler> hstList;
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;

            hstList = (from s in _db.tblHastaneler select s).ToList();//Hastaneler tablosunda bilgi getirir

            foreach (var item in hstList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i+1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.tblHastaneTipleri.TipAdi;
                Liste.Rows[i].Cells[4].Value = item.Tel;
                Liste.Rows[i].Cells[5].Value = item.Sehirler.Name;
                i++;
               
            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            
            if(Liste.CurrentRow != null)
            {
                 secimId = (int)Liste.CurrentRow.Cells[1].Value;

            }
            Ac(secimId);
        }

        public void Ac(int secimId)
        {
            if(secimId < 0)
            {
                MessageBox.Show("Kayıt Id Bulunamadı.");
                return;
                
            }
            BtnDetayEkle.Visible = true;
            BtnDetayGoster.Visible = true;
            //tblHastaneler kayitBul = _db.tblHastaneler.Find(secimId); //DBden gelen ilgili ıd yi bulur kayıtbula atar
            kayitBul = hstList.FirstOrDefault(x=>x.Id==secimId);

            try
            {
                if (kayitBul != null)
                {
                    TxtVergiNo.Text = kayitBul.VergiNo;
                    TxtTipAdi.Text = kayitBul.tblHastaneTipleri.TipAdi;
                    TxtSehir.Text = kayitBul.Sehirler.Name;
                    TxtAdres.Text = kayitBul.Adres;
                    TxtCariHadi.Text = kayitBul.CariAdi;
                    TxtHadi.Text = kayitBul.Adi;
                    txtTelefon.Text = kayitBul.Tel;
                    txtVergiDairesi.Text = kayitBul.VergiDairesi;
                    TxtHastaneBul.Text = kayitBul.Id.ToString().PadLeft(5,'0');
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Hata Kodu : HGListe101");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            if(secimId < 0)
            {
                MessageBox.Show("Değiştirilecek kayıt bulunamadı, önce bir kayıt seçin.");
                return;
            }
            if (kayitBul != null)
            {
                kayitBul.Adi = TxtHadi.Text;
                kayitBul.Adres = TxtAdres.Text;
                kayitBul.CariAdi = TxtCariHadi.Text;
                kayitBul.Tel = txtTelefon.Text;
                kayitBul.VergiDairesi = txtVergiDairesi.Text;
                kayitBul.SehirId = (int?)TxtSehir.SelectedValue;
                kayitBul.TipId = (int?)TxtTipAdi.SelectedValue;
                kayitBul.VergiNo = TxtVergiNo.Text;
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

            if(dr == DialogResult.Yes)
            {
                Sil();
            }


        }

        private void Sil()
        {
            
            if(secimId > 0)
            {
                _db.tblHastaneler.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydınız silinmiştir.Geçmiş olsun");
                Temizle();
                Listele();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25,TxtHastaneBul.ClientSize.Height);
            btn.Location = new Point(TxtHastaneBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            TxtHastaneBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = f.HastanelerListesiAc(true);
            if (id > 0)
            {
                Ac(id);
            }
            AnaSayfa.Aktarma = -1;
        }

        private void BtnDetayEkle_Click(object sender, EventArgs e)
        {
            string adi = "";
            int id = -1;
            if (secimId > 0)
            {
                adi = TxtHadi.Text;
                id = int.Parse(TxtHastaneBul.Text);
                f.HastaneDetayAc(adi,id);
            }
            else
            {
                MessageBox.Show("Önce bir kayıt seçin!!");
                return;
            }
        }

        private void BtnDetayGoster_Click(object sender, EventArgs e)
        {
            HastaneDetayGoster goster = new HastaneDetayGoster();
            goster.Hadi = TxtHadi.Text;
            goster.ShowDialog();
        }
    }
}
