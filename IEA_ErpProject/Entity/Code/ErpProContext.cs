using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Entity.Code
{
    public class ErpProContext : DbContext //DbContext ErpProContext sınıfının base idir.
    {
        public ErpProContext() : base("name=ErpPro102Code")
        {
            Database.SetInitializer(new MyInitializer());
        }
        public DbSet<tblUser> TblUsers { get; set; }
        public DbSet<tblKonsinyeGonderim> TblKonsinyeGonderimler { get; set; }

       
    }
}
