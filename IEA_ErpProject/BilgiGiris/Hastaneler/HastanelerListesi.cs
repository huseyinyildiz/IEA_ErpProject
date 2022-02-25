using IEA_ErpProject.Entity;
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

namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    public partial class HastanelerListesi : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private List<tblHastaneler> hstList;
        private int secimId = -1;
        public bool Secim=false;
        Formlar f = new Formlar();
        public HastanelerListesi()
        {
            InitializeComponent();
        }

        private void HastanelerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;

            hstList = (from s in _db.tblHastaneler
                       where s.Adi.Contains(TxtHastaneAra.Text)
                       select s).ToList();//Hastaneler tablosunda bilgi getirir

            foreach (var item in hstList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
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
                secimId = (int?)Liste.CurrentRow.Cells[1].Value ?? -1;
            }

            if(secimId > 0 )
            {
                if (  Application.OpenForms["HastaneGiris"] == null && Application.OpenForms["UrunGiris"] == null)
                {
                    AnaSayfa.Aktarma = secimId;
                    Close();
                    f.HastaneGirisAc(AnaSayfa.Aktarma); 
                }
                else if (Application.OpenForms["UrunGiris"] !=null)
                {
                    AnaSayfa.Aktarma = secimId;
                    Close();
                }
            } 
            else if (Secim && Application.OpenForms["HastaneGiris"] != null)
            {
                HastaneGiris frm = Application.OpenForms["HastaneGiris"] as HastaneGiris;
                frm.Ac(secimId);
                Close();
            }
           
            
        }

        private void BtnHastaneAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void TxtHastaneAra_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
