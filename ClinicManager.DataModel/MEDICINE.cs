namespace ClinicManager.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Medicine")]
    public partial class Medicine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicine()
        {
            PrescriptionDetail = new HashSet<PrescriptionDetail>();
        }

        public int MedicineID { get; set; }

        [Required]
        [StringLength(50)]
        public string MedicineName { get; set; }

        public int MedicineTypeID { get; set; }

        public int WayToUseID { get; set; }

        public int PharmacyTypeID { get; set; }

        public int UnitID { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrescriptionDetail> PrescriptionDetail { get; set; }

        public virtual MedicineType MedicineType { get; set; }

        public virtual PharmacyType PharmacyType { get; set; }

        public virtual Unit Unit { get; set; }

        public virtual WayToUse WayToUse { get; set; }
    }
}
