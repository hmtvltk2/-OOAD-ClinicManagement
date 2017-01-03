namespace ClinicManager.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            BillDetail = new HashSet<BillDetail>();
            BillDetail1 = new HashSet<BillDetail>();
        }

        public int BillID { get; set; }

        public int MedicalRecordID { get; set; }

        [Column(TypeName = "money")]
        public decimal ServiceFee { get; set; }

        [Column(TypeName = "money")]
        public decimal MedicineFee { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateOfBill { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public int UserID { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetail1 { get; set; }

        public virtual MedicalRecord MedicalRecord { get; set; }
    }
}
