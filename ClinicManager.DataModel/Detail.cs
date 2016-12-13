namespace ClinicManager.DataModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Detail")]
    public partial class Detail
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

        public virtual MedicalRecord MedicalRecord { get; set; }

        public virtual Service Service { get; set; }
    }
}
