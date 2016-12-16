namespace ClinicManager.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("MedicalRecord")]
    public partial class MedicalRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalRecord()
        {
            Bill = new HashSet<Bill>();
            ServiceDetail = new HashSet<ServiceDetail>();
        }

        public int MedicalRecordID { get; set; }

        public int PatientID { get; set; }

        public int DoctorID { get; set; }

        [Required]
        [StringLength(200)]
        public string ExamineReason { get; set; }

        [Required]
        [StringLength(200)]
        public string Diagnostic { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ExamineDate { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public int PrescriptionsID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceDetail> ServiceDetail { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Prescription Prescription { get; set; }

        public virtual User User { get; set; }
    }
}
