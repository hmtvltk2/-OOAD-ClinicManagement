namespace ClinicManager.DataModel
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Queue")]
    public partial class Queue
    {
        public int QueueID { get; set; }

        public int PatientID { get; set; }

        [Required]
        [StringLength(200)]
        public string ExamineReason { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ExamineDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        public int DoctorID { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual User User { get; set; }
    }
}
