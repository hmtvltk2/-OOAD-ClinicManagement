namespace ClinicManager.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class SCHEDULE_INFO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCHEDULE_INFO()
        {
            SCHEDULE = new HashSet<SCHEDULE>();
        }

        [Key]
        public int ScheduleInfoID { get; set; }

        [Required]
        [StringLength(50)]
        public string ScheduleInfoName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCHEDULE> SCHEDULE { get; set; }
    }
}
