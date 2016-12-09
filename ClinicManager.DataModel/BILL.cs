namespace ClinicManager.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BILL")]
    public partial class BILL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BILL()
        {
            BILL_DETAIL = new HashSet<BILL_DETAIL>();
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

        public virtual USER USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL_DETAIL> BILL_DETAIL { get; set; }

        public virtual MEDICAL_RECORD MEDICAL_RECORD { get; set; }
    }
}
