namespace ClinicManager.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Prescription")]
    public partial class Prescription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prescription()
        {
            MedicalRecord = new HashSet<MedicalRecord>();
            PrescriptionDetail = new HashSet<PrescriptionDetail>();
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
        public virtual ICollection<MedicalRecord> MedicalRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrescriptionDetail> PrescriptionDetail { get; set; }
    }
}
