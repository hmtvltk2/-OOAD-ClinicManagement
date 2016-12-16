namespace ClinicManager.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Service")]
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            ServiceDetail = new HashSet<ServiceDetail>();
        }

        public int ServiceID { get; set; }

        [Required]
        [StringLength(200)]
        public string ServiceName { get; set; }

        [Column(TypeName = "money")]
        public decimal ServiceFee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceDetail> ServiceDetail { get; set; }
    }
}
