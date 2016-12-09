namespace ClinicManager.DataModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("QUEUE")]
    public partial class QUEUE
    {
        public int QueueID { get; set; }

        public int PatientID { get; set; }

        [Required]
        [StringLength(200)]
        public string ExamineReason { get; set; }

        public virtual PATIENT PATIENT { get; set; }
    }
}
