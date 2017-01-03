namespace ClinicManager.DataModel
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ServiceDetail")]
    public partial class ServiceDetail
    {
        public int ServiceDetailID { get; set; }

        public int MedicalRecordID { get; set; }

        public int ServiceID { get; set; }

        [Column(TypeName = "money")]
        public decimal ServiceFee { get; set; }

        public virtual MedicalRecord MedicalRecord { get; set; }

        public virtual Service Service { get; set; }
    }
}
