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

namespace IEA_ErpProject.BilgiGiris.Personeller
{
    public partial class PersonellerListesi : Form
    {
        public bool Secim = false;
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        private List<tblPersoneller> prsList;
        private int secimId = -1;
        Formlar f = new Formlar();
        public PersonellerListesi()
        {
            InitializeComponent();
        }

        private void PersonellerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;

            prsList = (from s in _db.tblPersoneller where s.Adi.Contains(TxtPersonelAra.Text) select s).ToList();//Firmalar tablosunda bilgi getirir

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
                Liste.Rows[i].Cells[8].Value = item.IsBaslangıcTarih;
                Liste.Rows[i].Cells[9].Value = item.IsBitisTarih;


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

            if (secimId > 0 && Application.OpenForms["PersonelGiris"] == null)
            {
                AnaSayfa.Aktarma = secimId;
                Close();
                f.PersonelGirisAc(AnaSayfa.Aktarma);
            }
            else if (Secim && Application.OpenForms["PersonelGiris"] != null)
            {
                PersonelGiris frm = Application.OpenForms["PersonelGiris"] as PersonelGiris;
                frm.Ac(secimId);
                Close();
            }
        }

        private void BtnPersonelAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
