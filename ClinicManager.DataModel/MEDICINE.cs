namespace ClinicManager.DataModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("MEDICINE")]
    public partial class MEDICINE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEDICINE()
        {
            PRESCRIPTION_DETAIL = new HashSet<PRESCRIPTION_DETAIL>();
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
        public virtual ICollection<PRESCRIPTION_DETAIL> PRESCRIPTION_DETAIL { get; set; }

        public virtual MEDICINE_TYPE MEDICINE_TYPE { get; set; }

        public virtual PHARMACY_TYPE PHARMACY_TYPE { get; set; }

        public virtual UNIT UNIT { get; set; }

        public virtual WAY_TO_USE WAY_TO_USE { get; set; }
    }
}
