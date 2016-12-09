namespace ClinicManager.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("USER")]
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            BILL = new HashSet<BILL>();
            MEDICAL_RECORD = new HashSet<MEDICAL_RECORD>();
        }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateOfBirth { get; set; }

        public int UserGroupID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL> BILL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEDICAL_RECORD> MEDICAL_RECORD { get; set; }

        public virtual USER_GROUP USER_GROUP { get; set; }
    }
}
