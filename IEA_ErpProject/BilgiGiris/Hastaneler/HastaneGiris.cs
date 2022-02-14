using IEA_ErpProject.Entity;
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
        public HastaneGiris()
        {
            InitializeComponent();
        }

        private void HastaneGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
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
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
