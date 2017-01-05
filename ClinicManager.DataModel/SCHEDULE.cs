namespace ClinicManager.DataModel
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Schedule")]
    public partial class Schedule
    {
        [Key]
        public int PatientScheduleID { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public int DoctorID { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ScheduleDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ScheduleType { get; set; }
    }
}
