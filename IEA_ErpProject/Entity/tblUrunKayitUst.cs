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
    
    public partial class tblUrunKayitUst
    {
        public int Id { get; set; }
        public string UrunKodu { get; set; }
        public string AciklamaTr { get; set; }
        public string AciklamaEng { get; set; }
        public Nullable<System.DateTime> GirisTarih { get; set; }
        public byte[] Resim { get; set; }
        public Nullable<int> Uid { get; set; }
    }
}
