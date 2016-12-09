namespace ClinicManager.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class WAY_TO_USE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WAY_TO_USE()
        {
            MEDICINE = new HashSet<MEDICINE>();
        }

        [Key]
        public int WayToUseID { get; set; }

        [Required]
        [StringLength(50)]
        public string WayToUseName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEDICINE> MEDICINE { get; set; }
    }
}
