namespace ClinicManager.DataModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class SERVICE_DETAIL
    {
        [Key]
        [Column(Order = 0)]
        public int MedicalRecordID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceID { get; set; }

        [Column(TypeName = "money")]
        public decimal ServiceFee { get; set; }

        public virtual MEDICAL_RECORD MEDICAL_RECORD { get; set; }

        public virtual SERVICE SERVICE { get; set; }
    }
}
