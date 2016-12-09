namespace ClinicManager.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PHARMACY_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHARMACY_TYPE()
        {
            MEDICINE = new HashSet<MEDICINE>();
        }

        [Key]
        public int PharmacyTypeID { get; set; }

        [Required]
        [StringLength(200)]
        public string PharmacyTypeName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEDICINE> MEDICINE { get; set; }
    }
}
