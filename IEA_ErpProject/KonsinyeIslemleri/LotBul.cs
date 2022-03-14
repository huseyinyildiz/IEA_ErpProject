using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity;
using IEA_ErpProject.KonsinyeIslemleri.Giris;

namespace IEA_ErpProject.KonsinyeIslemleri
{
    public partial class LotBul : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        public string ukod;
        public LotBul()
        {
            InitializeComponent();
        }

        private void LotBul_Load(object sender, EventArgs e)
        {
            this.Text = "Lot Seri No Bul ==>" + ukod;
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = _db.tblStokDurum.Where(x => x.UrunKodu == ukod).ToList();
            foreach (var s in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = s.Id;
                Liste.Rows[i].Cells[1].Value = s.Barkod;
                Liste.Rows[i].Cells[2].Value = s.LotSeriNo;
                Liste.Rows[i].Cells[3].Value = s.RafAdet;
                Liste.Rows[i].Cells[4].Value = s.Uts;
                Liste.Rows[i].Cells[5].Value = s.UTarih;
                Liste.Rows[i].Cells[6].Value = s.SKTarih;
                i++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            KonsinyeGonderim kon = Application.OpenForms["KonsinyeGonderim"] as KonsinyeGonderim;
            kon.Liste.CurrentRow.Cells[5].Value = Liste.CurrentRow.Cells[3].Value;
            kon.Liste.CurrentRow.Cells[2].Value = Liste.CurrentRow.Cells[1].Value;
            kon.Liste.CurrentRow.Cells[4].Value = Liste.CurrentRow.Cells[2].Value;
            kon.Liste.CurrentRow.Cells[8].Value = Liste.CurrentRow.Cells[0].Value;
            kon.Liste.CurrentRow.Cells[9].Value = Liste.CurrentRow.Cells[4].Value;
            kon.Liste.CurrentRow.Cells[10].Value = Liste.CurrentRow.Cells[5].Value;
            kon.Liste.CurrentRow.Cells[11].Value = Liste.CurrentRow.Cells[6].Value;

            Close();
        }
    }
}
