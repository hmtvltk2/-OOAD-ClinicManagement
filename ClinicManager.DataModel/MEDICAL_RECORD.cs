namespace ClinicManager.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class MEDICAL_RECORD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEDICAL_RECORD()
        {
            BILL = new HashSet<BILL>();
            SERVICE_DETAIL = new HashSet<SERVICE_DETAIL>();
        }

        [Key]
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
        public virtual ICollection<BILL> BILL { get; set; }

        public virtual PATIENT PATIENT { get; set; }

        public virtual PRESCRIPTION PRESCRIPTION { get; set; }

        public virtual USER USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICE_DETAIL> SERVICE_DETAIL { get; set; }
    }
}
