namespace ClinicManager.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("WayToUse")]
    public partial class WayToUse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WayToUse()
        {
            Medicine = new HashSet<Medicine>();
        }

        public int WayToUseID { get; set; }

        [Required]
        [StringLength(50)]
        public string WayToUseName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicine> Medicine { get; set; }
    }
}
