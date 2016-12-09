namespace ClinicManager.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PERMISSION")]
    public partial class PERMISSION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERMISSION()
        {
            USER_GROUP = new HashSet<USER_GROUP>();
        }

        public int PermissionID { get; set; }

        [Required]
        [StringLength(50)]
        public string PermissionsName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_GROUP> USER_GROUP { get; set; }
    }
}
