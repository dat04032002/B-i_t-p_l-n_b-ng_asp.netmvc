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
    
    public partial class Tb_NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_NhanVien()
        {
            this.Tb_PhieuNhap = new HashSet<Tb_PhieuNhap>();
        }
    
        public long Id { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string CMND { get; set; }
        public string QueQuan { get; set; }
        public string ChucVu { get; set; }
        public string TenDanhNhap { get; set; }
        public string MatKhau { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string GioiTinh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_PhieuNhap> Tb_PhieuNhap { get; set; }
    }
}
