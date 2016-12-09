namespace ClinicManager.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PRESCRIPTION")]
    public partial class PRESCRIPTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRESCRIPTION()
        {
            MEDICAL_RECORD = new HashSet<MEDICAL_RECORD>();
            PRESCRIPTION_DETAIL = new HashSet<PRESCRIPTION_DETAIL>();
        }

        public int PrescriptionID { get; set; }

        public int MedicalRecordID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Date { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEDICAL_RECORD> MEDICAL_RECORD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESCRIPTION_DETAIL> PRESCRIPTION_DETAIL { get; set; }
    }
}
