using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity.Code;

namespace IEA_ErpProject.Giris
{
    public partial class GirisEkrani : Form
    {
        private readonly ErpProContext code = new ErpProContext();
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text!="" && txtSifre.Text!="")
            {
                //var srg = code.TblUsers.FirstOrDefault(s => s.Username == txtKullanici.Text && s.Password == txtSifre.Text);
                var srg1 = (from s in code.TblUsers
                    where (s.Username == txtKullanici.Text && s.Password == txtSifre.Text)
                    select s).FirstOrDefault();
                if (srg1!= null)
                {
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                    anaSayfa.lblUserName.Text = srg1.Name;
                    anaSayfa.lblUserNickName.Text = srg1.Username;
                    Hide();
                }
                else
                {
                    MessageBox.Show(@"Kullanıcı adı veya şifre hatalıdır.");
                }

            }
        }
    }
}
