//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEA_ErpProject.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPersoneller
    {
        public int Id { get; set; }
        public string Unvan { get; set; }
        public string Adi { get; set; }
        public Nullable<int> DepartmanId { get; set; }
        public string Tel { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public Nullable<int> SehirId { get; set; }
        public Nullable<System.DateTime> IsBaslangıcTarih { get; set; }
        public Nullable<System.DateTime> IsBitisTarih { get; set; }
    
        public virtual Sehirler Sehirler { get; set; }
        public virtual tblDepartmanlar tblDepartmanlar { get; set; }
    }
}
