using IEA_ErpProject.BilgiGiris.Doktorlar;
using IEA_ErpProject.BilgiGiris.Firmalar;
using IEA_ErpProject.BilgiGiris.Hastaneler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject.Fonksiyonlar
{
    public class Formlar
    {
        public int HastanelerListesiAc(bool secim = false)
        {
            HastanelerListesi frm = new HastanelerListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();

            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                //frm.Secim=true;
                frm.Show();
            }

            return AnaSayfa.Aktarma;
        }
        public void HastaneGirisAc(int id)
        {
            HastaneGiris frm = new HastaneGiris();
            frm.MdiParent=Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }
        public void HastaneDetayAc(string adi,int id)
        {
            HastaneDetay frm = new HastaneDetay();
            frm.LblHastaneAdi.Text = adi;
            frm.LblHastaneId.Text = id.ToString();
            frm.ShowDialog();
            
        }

        public int DoktorlarListesiAc(bool secim = false)
        {
            DoktorlarListesi frm = new DoktorlarListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();

            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                //frm.Secim=true;
                frm.Show();
            }

            return AnaSayfa.Aktarma;
        }

        public void DoktorGirisAc(int id)
        {
            DoktorGiris frm = new DoktorGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }
        public int FirmalarListesiAc(bool secim = false)
        {
            FirmalarListesi frm = new FirmalarListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();

            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                //frm.Secim=true;
                frm.Show();
            }

            return AnaSayfa.Aktarma;
        }
        public void FirmaGirisAc(int id)
        {
            FirmaGiris frm = new FirmaGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }
    }
}
