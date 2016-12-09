namespace ClinicManager.DataModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PRESCRIPTION_DETAIL
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

        public virtual MEDICINE MEDICINE { get; set; }

        public virtual PRESCRIPTION PRESCRIPTION { get; set; }
    }
}
