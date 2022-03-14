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
using IEA_ErpProject.Entity.Code;

namespace IEA_ErpProject.KonsinyeIslemleri.Giris
{
    public partial class KonsinyeGonderim : Form
    {
        private readonly ErpProContext _code;
        private readonly ErpPro102SEntities _db;
        public string[] myArray { get; set; }

        public bool Secim = false;
        public KonsinyeGonderim(ErpProContext code, ErpPro102SEntities db )
        {
            _code = code;
            _db = db;
            InitializeComponent();

        }

        //public KonsinyeGonderim(ErpProContext code)
        //{
        //    _code = code;
        //    InitializeComponent();

        //}

        private void KonsinyeGiris_Load(object sender, EventArgs e)
        {
            myArray = _db.tblUrunKayitUst.Select(x => x.UrunKodu).Distinct().ToArray();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            Liste.AllowUserToAddRows = false;
            tblKonsinyeGonderim[] kon = new tblKonsinyeGonderim[Liste.RowCount];
            for (int i = 0; i < Liste.RowCount; i++)
            {
                kon[i] = new tblKonsinyeGonderim();
                kon[i].CariAdi = TxtCariAdi.Text;
                kon[i].Aciklama = TxtKonGonderimAciklama.Text;
                kon[i].Adet = Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                kon[i].CariTur = TxtCariTur.Text;
                kon[i].GonderimTarih = TxtGonderimTarih.Value;
                var brk = Liste.Rows[i].Cells[2].Value;
                kon[i].UrunId = _db.tblStokDurum.FirstOrDefault(s => s.Barkod == brk).Id;
                kon[i].CreatedDate = DateTime.Now;
                kon[i].UpdatedDate = DateTime.Now;
                kon[i].CreatedUser = 1;
                kon[i].UpdatedUser = 1;
                kon[i].isDeleted = false;
                kon[i].CariId = 1;
            }

            _code.TblKonsinyeGonderimler.AddRange(kon);
            _code.SaveChanges();
        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBox txt = e.Control as TextBox;
                if (Liste.CurrentCell.ColumnIndex == 3 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource.AddRange(myArray);
                }
                else if (Liste.CurrentCell.ColumnIndex != 3 && txt != null)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.None;
                }

                //if (Liste.CurrentCell.ColumnIndex == 4)
                //{
                //    LotBul bul = new LotBul();
                //    bul.ShowDialog();
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void Liste_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void Liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Liste.CurrentCell.ColumnIndex == 4)
            {
                LotBul bul = new LotBul();
                if (Liste.CurrentRow.Cells[3].Value != null) bul.ukod = Liste.CurrentRow.Cells[3].Value.ToString();
                bul.ShowDialog();
            }
        }
    }
}
