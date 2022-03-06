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

namespace IEA_ErpProject.BilgiGiris.Doktorlar
{
    public partial class DoktorlarListesi : Form
    {
        public bool Secim = false;
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private List<tblDoktorlar> dktList;
        private int secimId = -1;
        Formlar f = new Formlar();
        public DoktorlarListesi()
        {
            InitializeComponent();
        }

        private void DoktorlarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;

            dktList = (from s in _db.tblDoktorlar where s.Adi.Contains(TxtDoktorAra.Text) select s).ToList();//Hastaneler tablosunda bilgi getirir

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

     

      

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
            {
                secimId = (int?)Liste.CurrentRow.Cells[1].Value ?? -1;
            }

            if (secimId > 0 && Secim && Application.OpenForms["DoktorGiris"] == null)
            {
                AnaSayfa.Aktarma = secimId;
                Close();
                //  f.FirmaGirisAc(AnaSayfa.Aktarma);
            }
            else if (Secim && Application.OpenForms["DoktorGiris"] != null)
            {
                //AnaSayfa.Aktarma = secimId;
                DoktorGiris frm = Application.OpenForms["DoktorGiris"] as DoktorGiris;
                frm.Ac(secimId);
                Close();
            }
            else if (!Secim)
            {
                f.DoktorGirisAc(secimId);
                Close();
            }
        }

        private void TxtDoktorAra_TextChanged(object sender, EventArgs e)
        {
           // Listele();
        }

        private void BtnDoktorAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
