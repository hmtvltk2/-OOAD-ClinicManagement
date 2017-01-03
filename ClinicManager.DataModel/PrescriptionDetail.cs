namespace ClinicManager.DataModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PrescriptionDetail")]
    public partial class PrescriptionDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrescriptionID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MedicineID { get; set; }

        [Column(TypeName = "money")]
        public decimal MedicineFee { get; set; }

        public int Quantity { get; set; }

        [Required]
        [StringLength(200)]
        public string HowToUse { get; set; }

        public virtual Medicine Medicine { get; set; }

        public virtual Medicine Medicine1 { get; set; }

        public virtual Prescription Prescription { get; set; }

        public virtual Prescription Prescription1 { get; set; }
    }
}
