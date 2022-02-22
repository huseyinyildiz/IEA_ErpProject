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

namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    public partial class FirmalarListesi : Form
    {
        public bool Secim = false;
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private List<tblFirmalar> frmList;
        private int secimId = -1;
        Formlar f = new Formlar();
        public FirmalarListesi()
        {
            InitializeComponent();
        }

        private void FirmalarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;

            frmList = (from s in _db.tblFirmalar where s.Adi.Contains(TxtFirmaAra.Text) select s).ToList();//Firmalar tablosunda bilgi getirir

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

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
            {
                secimId = (int?)Liste.CurrentRow.Cells[1].Value ?? -1;
            }

            if (secimId > 0 && Secim && Application.OpenForms["FirmaGiris"] == null)
            {
                AnaSayfa.Aktarma = secimId;
                Close();
              //  f.FirmaGirisAc(AnaSayfa.Aktarma);
            }
            else if (Secim && Application.OpenForms["FirmaGiris"]!=null)
            {
                //AnaSayfa.Aktarma = secimId;
                FirmaGiris frm = Application.OpenForms["FirmaGiris"] as FirmaGiris;
                frm.Ac(secimId);
                Close();
            }
            else if (!Secim)
            {
                f.FirmaGirisAc(secimId);
                Close();
            }
        }

        private void BtnFirmaAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
