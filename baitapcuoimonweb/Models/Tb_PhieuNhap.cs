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
    
    public partial class Tb_PhieuNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_PhieuNhap()
        {
            this.Tb_ChiTietPhieuNHap = new HashSet<Tb_ChiTietPhieuNHap>();
        }
    
        public long Id { get; set; }
        public Nullable<long> IdNhanVien { get; set; }
        public Nullable<long> IdSanPham { get; set; }
        public Nullable<int> IdKho { get; set; }
        public Nullable<double> TongTien { get; set; }
        public Nullable<long> NhaCungCap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_ChiTietPhieuNHap> Tb_ChiTietPhieuNHap { get; set; }
        public virtual Tb_Kho Tb_Kho { get; set; }
        public virtual Tb_Kho Tb_Kho1 { get; set; }
        public virtual Tb_NhaCungCap Tb_NhaCungCap { get; set; }
        public virtual Tb_NhanVien Tb_NhanVien { get; set; }
    }
}
