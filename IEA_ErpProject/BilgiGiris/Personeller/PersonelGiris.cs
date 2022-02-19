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

namespace IEA_ErpProject.BilgiGiris.Personeller
{
    public partial class PersonelGiris : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private int secimId = -1;
        private tblPersoneller kayitBul;
        Fonksiyonlar.Formlar f = new Fonksiyonlar.Formlar();
        public PersonelGiris()
        {
            InitializeComponent();
        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void ComboDoldur()
        {
            TxtDepartmanAdı.DataSource = _db.tblDepartmanlar.ToList();
            TxtDepartmanAdı.ValueMember = "Id";
            TxtDepartmanAdı.DisplayMember = "Adi";
            TxtDepartmanAdı.SelectedIndex = -1;


            TxtPSehir.DataSource = _db.Sehirler.ToList();
            TxtPSehir.ValueMember = "Id";
            TxtPSehir.DisplayMember = "Name";
            TxtPSehir.SelectedIndex = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtPAdi.Text == "")
            {
                MessageBox.Show("İlgili alanlar doldurulmadan kayıt yapılamaz.");
                return;
            }
            try
            {
                tblPersoneller prs = new tblPersoneller();
                prs.Adi = TxtPAdi.Text;
                prs.Adres = TxtPAdres.Text;
                prs.Unvan = TxtUnvanAdi.Text;
                if (TxtPSehir.SelectedValue != null) prs.SehirId = (int)TxtPSehir.SelectedValue;
                if (TxtDepartmanAdı.SelectedValue != null) prs.DepartmanId = (int)TxtDepartmanAdı.SelectedValue;
                prs.Tel = txtTelefon.Text;
                prs.Gsm = TxtPGsm.Text;
                prs.Email = TxtPEmail.Text;
                prs.IsBaslangıcTarih = txtPBaslangicTarih.Value;
                prs.IsBitisTarih = txtPBitisTarih.Value;

                _db.tblPersoneller.Add(prs);
                _db.SaveChanges();
                MessageBox.Show("Kayıt İşlemi Gerçekleştirildi.");
                Listele();
                Temizle();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "HataKodu : HGK100");

            }
        }

        private void Temizle()
        {
            foreach (Control k in ScPersonel.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";
                }

                TxtPSehir.SelectedIndex = -1;
                TxtDepartmanAdı.SelectedIndex = -1;

            }
        }

        private List<tblPersoneller> prsList;

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;

            prsList = (from s in _db.tblPersoneller select s).ToList();//Firmalar tablosunda bilgi getirir

            foreach (var item in prsList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.Unvan;
                Liste.Rows[i].Cells[4].Value = item.Tel;
                Liste.Rows[i].Cells[5].Value = item.Gsm;
                Liste.Rows[i].Cells[6].Value = item.Email;

                if (item.Sehirler != null)
                {
                    Liste.Rows[i].Cells[7].Value = item.Sehirler.Name;
                }
                if (item.IsBaslangıcTarih != null)
                {
                    Liste.Rows[i].Cells[8].Value = item.IsBaslangıcTarih.Value;
                }
                if (item.IsBitisTarih != null)
                {
                    Liste.Rows[i].Cells[9].Value = item.IsBitisTarih.Value;
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
            btn.Size = new Size(25, TxtPersonelBul.ClientSize.Height);
            btn.Location = new Point(TxtPersonelBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            TxtPersonelBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = f.PersonellerListesiAc(true);
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
            kayitBul = prsList.FirstOrDefault(x => x.Id == secimId);

            try
            {
                if (kayitBul != null)
                {
                    txtPBaslangicTarih.Text = kayitBul.IsBaslangıcTarih.ToString();
                    txtPBitisTarih.Text = kayitBul.IsBitisTarih.ToString();
                    TxtPSehir.Text = kayitBul.Sehirler.Name;
                    TxtDepartmanAdı.Text = kayitBul.tblDepartmanlar.Adi;
                    TxtPAdres.Text = kayitBul.Adres;
                    txtTelefon.Text = kayitBul.Tel;
                    TxtPGsm.Text = kayitBul.Gsm;
                    TxtPEmail.Text = kayitBul.Email;
                    TxtUnvanAdi.Text = kayitBul.Unvan;
                    TxtPAdi.Text = kayitBul.Adi;
                    TxtPersonelBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');
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
                kayitBul.IsBaslangıcTarih = txtPBaslangicTarih.Value;
                kayitBul.IsBitisTarih = txtPBitisTarih.Value;
                if (TxtPSehir.SelectedValue != null)
                {
                    kayitBul.SehirId = Convert.ToInt32(TxtPSehir.SelectedValue);
                }
                if (TxtDepartmanAdı.SelectedValue != null)
                {
                    kayitBul.DepartmanId = Convert.ToInt32(TxtDepartmanAdı.SelectedValue);
                }

                kayitBul.Adres = TxtPAdres.Text;
                kayitBul.Unvan = TxtUnvanAdi.Text;
                kayitBul.Adi = TxtPAdi.Text;
                kayitBul.Tel = txtTelefon.Text;
                kayitBul.Gsm = TxtPGsm.Text;
                kayitBul.Email = TxtPEmail.Text;
                

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
                _db.tblPersoneller.Remove(kayitBul);
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
