//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace baitapcuoimonweb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Kho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Kho()
        {
            this.Tb_PhieuNhap = new HashSet<Tb_PhieuNhap>();
            this.Tb_PhieuNhap1 = new HashSet<Tb_PhieuNhap>();
        }
    
        public int Id { get; set; }
        public Nullable<long> IdSanPham { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual Tb_SanPham Tb_SanPham { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_PhieuNhap> Tb_PhieuNhap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_PhieuNhap> Tb_PhieuNhap1 { get; set; }
    }
}
