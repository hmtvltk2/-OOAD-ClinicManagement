namespace ClinicManager.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class MEDICINE_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEDICINE_TYPE()
        {
            MEDICINE = new HashSet<MEDICINE>();
        }

        [Key]
        public int MedicineTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string MedicineTypeName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEDICINE> MEDICINE { get; set; }
    }
}
