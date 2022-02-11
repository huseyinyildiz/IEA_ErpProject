using IEA_ErpProject.BilgiGiris.Hastaneler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject
{
    public partial class AnaSayfa : Form
    {
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
            }
            else if (info=="urun")
            {
                tvMenu.Nodes.Add("Ürünler");
                tvMenu.Nodes[0].Nodes.Add("Ürünler Listesi"); //child 
                tvMenu.Nodes[0].Nodes.Add("Ürün Bilgi Giriş");

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
                HastanelerListesi frm = new HastanelerListesi();
                frm.MdiParent = Form.ActiveForm;
                // frm.MdiParent = Application.OpenForms["AnaSayfa"] as AnaSayfa;

                frm.Show(); // Bu formu çalıştır.
            }
            else if (isim == "Hastane Bilgi Giriş" && Application.OpenForms["HastaneGiris"] == null)
            {
                HastaneGiris frm = new HastaneGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
        }
    }
}
