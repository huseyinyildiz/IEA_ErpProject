using IEA_ErpProject.BilgiGiris.Doktorlar;
using IEA_ErpProject.BilgiGiris.Firmalar;
using IEA_ErpProject.BilgiGiris.Hastaneler;
using IEA_ErpProject.BilgiGiris.Personeller;
using IEA_ErpProject.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.BilgiGiris.Urunler;
using IEA_ErpProject.UrunGirisIslemleri;

namespace IEA_ErpProject
{
    public partial class AnaSayfa : Form
    {
        Formlar f = new Formlar();

        public static int Aktarma = -1;
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void pnlSolUst_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblMenu.Text = btnBilgiGiris.Text;
            MenuOlustur("bilgi");
        }

        private void MenuOlustur(string info)
        {
            tvMenu.Nodes.Clear(); //Her seferinde tekrar oluştursun.

            if (info=="bilgi")
            {
                tvMenu.Nodes.Add("Hastaneler"); //root eleman 
                tvMenu.Nodes[0].Nodes.Add("Hastaneler Listesi"); //child 
                tvMenu.Nodes[0].Nodes.Add("Hastane Bilgi Giriş");

                tvMenu.Nodes.Add("Doktorlar");
                tvMenu.Nodes[1].Nodes.Add("Doktorlar Listesi");
                tvMenu.Nodes[1].Nodes.Add("Doktor Bilgi Giriş");

                tvMenu.Nodes.Add("Firmalar");
                tvMenu.Nodes[2].Nodes.Add("Firmalar Listesi");
                tvMenu.Nodes[2].Nodes.Add("Firma Bilgi Giriş");

                tvMenu.Nodes.Add("Personeller");
                tvMenu.Nodes[3].Nodes.Add("Personeller  Listesi");
                tvMenu.Nodes[3].Nodes.Add("Personel Bilgi Giriş");

                tvMenu.Nodes.Add("Urunler");
                tvMenu.Nodes[4].Nodes.Add("Urun Kayit Listesi");
                tvMenu.Nodes[4].Nodes.Add("Urun Kayit");
            }
            else if (info=="urun")
            {
                tvMenu.Nodes.Add("Ürünler");
                tvMenu.Nodes[0].Nodes.Add("Ürünler Listesi"); //child 
                tvMenu.Nodes[0].Nodes.Add("Ürün Bilgi Giriş");

            } else if (info=="stok")
            {
                tvMenu.Nodes.Add("Stok");
                tvMenu.Nodes[0].Nodes.Add("Stok Durum"); //child 
                //tvMenu.Nodes[0].Nodes.Add("Ürün Bilgi Giriş");

            }

        }

        private void btnUrunGiris_Click(object sender, EventArgs e)
        {
            lblMenu.Text=btnUrunGiris.Text;
            MenuOlustur("urun");
        }

        private void tvMenu_DoubleClick(object sender, EventArgs e)
        {
            string isim = "";
            if (tvMenu.SelectedNode != null)
            {
                isim = tvMenu.SelectedNode.Text;
            }
            if (isim == "Hastaneler Listesi" && Application.OpenForms["HastanelerListesi"] == null)
            {
                //HastanelerListesi frm = new HastanelerListesi();
                //frm.MdiParent = Form.ActiveForm;
                //// frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa;

                //frm.Show(); // Bu formu çalıştır.
                f.HastanelerListesiAc();
            }
            else if (isim == "Hastane Bilgi Giriş" && Application.OpenForms["HastaneGiris"] == null)
            {
                HastaneGiris frm = new HastaneGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim =="Doktorlar Listesi" && Application.OpenForms["DoktorlarListesi"]== null)
            {
                //DoktorlarListesi frm = new DoktorlarListesi();
                //frm.MdiParent = Form.ActiveForm;
                //frm.Show();
                f.DoktorlarListesiAc();
                
            }
            else if (isim =="Doktor Bilgi Giriş" && Application.OpenForms["DoktorGiris"]== null)
            {
                DoktorGiris frm = new DoktorGiris();
                frm.MdiParent= Form.ActiveForm;
                frm.Show();
            }
            else if (isim =="Firmalar Listesi" && Application.OpenForms["FirmalarListesi"] == null)
            {
                FirmalarListesi frm = new FirmalarListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if(isim =="Firma Bilgi Giriş" && Application.OpenForms["FirmaGiris"] == null)
            {
                FirmaGiris frm = new FirmaGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim =="Personeller  Listesi" && Application.OpenForms["PersonellerListesi"] == null)
            {
                PersonellerListesi frm = new PersonellerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim =="Personel Bilgi Giriş" && Application.OpenForms["PersonelGiris"] == null)
            {
                PersonelGiris frm = new PersonelGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim =="Urun Kayit Listesi" && Application.OpenForms["UrunKayitListesi"] == null)
            {
                f.UrunKayitListesiAc();
            }
            else if (isim == "Urun Kayit" && Application.OpenForms["UrunKayit"] == null)
            {
                UrunKayit frm = new UrunKayit();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Ürünler Listesi" && Application.OpenForms["UrunlerGirisListesi"] == null)
            {
                f.UrunGirisListesiAc();
            }
            else if (isim == "Ürün Bilgi Giriş" && Application.OpenForms["UrunGiris"] == null)
            {
                UrunGiris frm = new UrunGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if (isim == "Stok Durum" && Application.OpenForms["StokDurum"] == null)
            {
                f.StokDurumAc();
            }
            

        }

        private void btnStokIslemleri_Click(object sender, EventArgs e)
        {
            lblMenu.Text = btnStokIslemleri.Text;
            MenuOlustur(("stok"));
        }
    }
}
