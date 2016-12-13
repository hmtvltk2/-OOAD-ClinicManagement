namespace ClinicManager.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PharmacyType")]
    public partial class PharmacyType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PharmacyType()
        {
            Medicine = new HashSet<Medicine>();
        }

        public int PharmacyTypeID { get; set; }

        [Required]
        [StringLength(200)]
        public string PharmacyTypeName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicine> Medicine { get; set; }
    }
}
