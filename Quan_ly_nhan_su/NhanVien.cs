//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quan_ly_nhan_su
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.BaoHiems = new HashSet<BaoHiem>();
            this.HopDongs = new HashSet<HopDong>();
        }
    
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public Nullable<System.DateTime> Ngaysinh { get; set; }
        public string GioiTinh { get; set; }
        public string DanToc { get; set; }
        public string QueQuan { get; set; }
        public string SDT { get; set; }
        public string MaPB { get; set; }
        public string MaCV { get; set; }
        public string MaLuong { get; set; }
        public string MaTD { get; set; }
        public Nullable<bool> active { get; set; }
        public Nullable<int> isdelete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoHiem> BaoHiems { get; set; }
        public virtual ChucVu ChucVu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDongs { get; set; }
        public virtual Luong Luong { get; set; }
        public virtual PhongBan PhongBan { get; set; }
        public virtual TrinhDoHV TrinhDoHV { get; set; }
    }
}
