namespace ClinicManager.DataModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class BILL_DETAIL
    {
        [Key]
        [Column(Order = 0)]
        public int BillID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceID { get; set; }

        [Column(TypeName = "money")]
        public decimal ServiceFee { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public virtual BILL BILL { get; set; }
    }
}
