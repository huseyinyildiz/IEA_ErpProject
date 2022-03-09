using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity;

namespace IEA_ErpProject.Stok
{
    public partial class StokDurum : Form
    {
        private readonly ErpPro102SEntities _db = new ErpPro102SEntities();
        public bool Secim = false;
        public StokDurum()
        {
            InitializeComponent();
        }

        private void StokDurum_Load(object sender, EventArgs e)
        {
            Listele1();
            Listele2();
        }

        private void Listele2()
        {
            ListeStok1.Rows.Clear();
            int i = 0;

          //  var srg1 = from s in _db.tblStokDurum select s;

            var srg = (from s in _db.tblUrunGirisAlt
                group s by new {s.Barkod, s.UrunKodu, s.LotSeriNo}
                into g
                select new
                {
                    barkod = g.Key.Barkod,
                    urunkodu = g.Key.UrunKodu,
                    lot = g.Key.LotSeriNo,
                    adet = g.Sum(x => x.GirisAdet)
                }).ToList();
                


            foreach (var s in srg.ToList())
            {
                ListeStok1.Rows.Add();
                ListeStok1.Rows[i].Cells[0].Value = s.barkod;
                ListeStok1.Rows[i].Cells[1].Value = s.urunkodu;
                ListeStok1.Rows[i].Cells[2].Value = s.lot;
                ListeStok1.Rows[i].Cells[3].Value = s.adet;
                ListeStok1.Rows[i].Cells[4].Value = s.adet;
                i++;
            }

            ListeStok1.AllowUserToAddRows = false;
            ListeStok1.AllowUserToDeleteRows = false;
            ListeStok1.ReadOnly = true;
            ListeStok1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Listele1()
        {
            ListeStok.Rows.Clear();
            int i = 0;

            var srg = from s in _db.tblStokDurum select s;
            foreach (var s in srg.ToList())
            {
                ListeStok.Rows.Add();
                ListeStok.Rows[i].Cells[0].Value = s.Id;
                ListeStok.Rows[i].Cells[1].Value = s.Barkod;
                ListeStok.Rows[i].Cells[2].Value = s.UrunKodu;
                ListeStok.Rows[i].Cells[3].Value = s.LotSeriNo;
                ListeStok.Rows[i].Cells[4].Value = s.StokAdet;
                ListeStok.Rows[i].Cells[5].Value = s.RafAdet;
                ListeStok.Rows[i].Cells[6].Value = s.KonsinyeAdet;
                ListeStok.Rows[i].Cells[7].Value = s.SubeAdet;
                ListeStok.Rows[i].Cells[8].Value = s.UrunHareketAdet;
                ListeStok.Rows[i].Cells[9].Value = s.Uts;
                ListeStok.Rows[i].Cells[10].Value = s.UTarih;
                ListeStok.Rows[i].Cells[11].Value = s.SKTarih;
                i++;
            }

            ListeStok.AllowUserToAddRows = false;
            ListeStok.AllowUserToDeleteRows = false;
            ListeStok.ReadOnly = true;
            ListeStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
