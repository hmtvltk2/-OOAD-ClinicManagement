namespace ClinicManager.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SERVICE")]
    public partial class SERVICE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICE()
        {
            SERVICE_DETAIL = new HashSet<SERVICE_DETAIL>();
        }

        public int ServiceID { get; set; }

        [Required]
        [StringLength(200)]
        public string ServiceName { get; set; }

        [Column(TypeName = "money")]
        public decimal ServiceFee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICE_DETAIL> SERVICE_DETAIL { get; set; }
    }
}
