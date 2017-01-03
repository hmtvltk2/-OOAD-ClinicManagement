namespace ClinicManager.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Patient")]
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            MedicalRecord = new HashSet<MedicalRecord>();
            Queue = new HashSet<Queue>();
            Queue1 = new HashSet<Queue>();
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
        public virtual ICollection<MedicalRecord> MedicalRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Queue> Queue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Queue> Queue1 { get; set; }
    }
}
