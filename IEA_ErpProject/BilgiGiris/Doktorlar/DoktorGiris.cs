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

namespace IEA_ErpProject.BilgiGiris.Doktorlar
{
    public partial class DoktorGiris : Form
    {
        Fonksiyonlar.Formlar f = new Fonksiyonlar.Formlar();
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private int secimId=-1;
        private tblDoktorlar kayitBul;
        public DoktorGiris()
        {
            InitializeComponent();
        }

        private void DoktorGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void ComboDoldur()
        {
            TxtUnvan.DataSource = Enum.GetValues(typeof(Unvan));
            TxtUnvan.SelectedIndex = -1;

            var srg = _db.tblHastaneler;


            TxtHastane1.DataSource = srg.ToList();
            TxtHastane1.ValueMember = "Id";
            TxtHastane1.DisplayMember = "Adi"; 
            TxtHastane1.SelectedIndex = -1;

            TxtHastane2.DataSource = srg.ToList();
            TxtHastane2.ValueMember = "Id";
            TxtHastane2.DisplayMember = "Adi";
            TxtHastane2.SelectedIndex = -1;

            TxtHastane3.DataSource = srg.ToList();
            TxtHastane3.ValueMember = "Id";
            TxtHastane3.DisplayMember = "Adi";
            TxtHastane3.SelectedIndex = -1;

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
            tblDoktorlar dkt = new tblDoktorlar
            {
                Adi = TxtDadi.Text,
                DTarih = txtDTarih.Value,
                Email = TxtEmail.Text,
                Gsm = TxtGsm.Text,
                Muayenehane = TxtMAdres.Text,
                Tel1 = txtTelefon1.Text,
                Tel2 = txtTelefon2.Text,
                Unvan = TxtUnvan.Text,
                VergiDairesi = txtVergiDairesi.Text,
                VergiNo = TxtVergiNo.Text

            };
            if (TxtHastane1.SelectedValue != null) dkt.Hastane1id = Convert.ToInt32(TxtHastane1.SelectedValue);
            if (TxtHastane2.SelectedValue != null) dkt.Hastane2id = Convert.ToInt32(TxtHastane2.SelectedValue);
            if (TxtHastane3.SelectedValue != null) dkt.Hastane3id = Convert.ToInt32(TxtHastane3.SelectedValue);
            if (TxtSehir.SelectedValue != null) dkt.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);
            _db.tblDoktorlar.Add(dkt);
            _db.SaveChanges();

            MessageBox.Show("Kayıt başarıyla tamamlandı.");
            Temizle();
            Listele();
        }
        private List<tblDoktorlar> dktList;

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;

            dktList = (from s in _db.tblDoktorlar select s).ToList();//Hastaneler tablosunda bilgi getirir

            foreach (var item in dktList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                Liste.Rows[i].Cells[3].Value = item.Tel1;
                Liste.Rows[i].Cells[4].Value = item.Tel2;
                Liste.Rows[i].Cells[5].Value = item.Gsm;
                Liste.Rows[i].Cells[6].Value = item.Email;

                if (item.Sehirler != null)
                {
                    Liste.Rows[i].Cells[7].Value = item.Sehirler.Name;
                }

               
                i++;

            }
            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void Temizle()
        {

            foreach (Control k in ScDoktor.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                {
                    k.Text = "";
                }
                TxtHastane1.SelectedIndex = -1;
                TxtHastane2.SelectedIndex = -1;
                TxtHastane3.SelectedIndex = -1;
                txtDTarih.Value = DateTime.Now;
                TxtSehir.SelectedIndex = -1;
                TxtUnvan.SelectedIndex = -1;

            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(25, TxtDoktorBul.ClientSize.Height);
            btn.Location = new Point(TxtDoktorBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.Ara32x32;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            TxtDoktorBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = f.DoktorlarListesiAc(true);
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
            kayitBul = dktList.FirstOrDefault(x => x.Id == secimId);

            try
            {
                if (kayitBul != null)
                {
                    TxtVergiNo.Text = kayitBul.VergiNo;
                    txtTelefon1.Text = kayitBul.Tel1;
                    TxtSehir.Text = kayitBul.Sehirler.Name;
                    TxtMAdres.Text = kayitBul.Muayenehane;
                    TxtUnvan.Text = kayitBul.Unvan;
                    TxtDadi.Text = kayitBul.Adi;
                    txtTelefon2.Text = kayitBul.Tel2;
                    txtVergiDairesi.Text = kayitBul.VergiDairesi;
                   if(kayitBul.tblHastaneler!=null) TxtHastane1.Text = kayitBul.tblHastaneler.Adi;
                    if (kayitBul.tblHastaneler1 != null) TxtHastane2.Text = kayitBul.tblHastaneler1.Adi;
                    if (kayitBul.tblHastaneler2 != null) TxtHastane3.Text = kayitBul.tblHastaneler2.Adi;
                    TxtEmail.Text = kayitBul.Email;
                    txtDTarih.Text = kayitBul.DTarih.ToString();
                    TxtGsm.Text = kayitBul.Gsm;
                    TxtDoktorBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');
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
                kayitBul.VergiNo = TxtVergiNo.Text;
                 kayitBul.Tel1= txtTelefon1.Text;
                if (TxtSehir.SelectedValue != null)
                {
                    kayitBul.SehirId = Convert.ToInt32(TxtSehir.SelectedValue);
                }
                
                kayitBul.Muayenehane = TxtMAdres.Text;
                kayitBul.Unvan = TxtUnvan.Text;
                kayitBul.Adi = TxtDadi.Text;
                kayitBul.Tel2 = txtTelefon2.Text;
                kayitBul.VergiDairesi = txtVergiDairesi.Text;

                if(TxtHastane1.SelectedValue != null)
                {
                    kayitBul.Hastane1id = Convert.ToInt32(TxtHastane1.SelectedValue);
                }
                if(TxtHastane2.SelectedValue != null)
                {
                    kayitBul.Hastane2id = Convert.ToInt32(TxtHastane2.SelectedValue);
                }
                if(TxtHastane3.SelectedValue != null)
                {
                    kayitBul.Hastane3id = Convert.ToInt32(TxtHastane3.SelectedValue);
                }
                
                

                kayitBul.Email = TxtEmail.Text; 
                kayitBul.DTarih = txtDTarih.Value;
                kayitBul.Gsm = TxtGsm.Text;
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
                _db.tblDoktorlar.Remove(kayitBul);
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
