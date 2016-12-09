namespace ClinicManager.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PATIENT")]
    public partial class PATIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PATIENT()
        {
            MEDICAL_RECORD = new HashSet<MEDICAL_RECORD>();
            QUEUE = new HashSet<QUEUE>();
        }

        public int PatientID { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(20)]
        public string Gender { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(200)]
        public string Job { get; set; }

        [StringLength(200)]
        public string Phone { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEDICAL_RECORD> MEDICAL_RECORD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUEUE> QUEUE { get; set; }
    }
}
