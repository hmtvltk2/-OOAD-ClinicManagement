namespace ClinicManager.DataModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("MedicineType")]
    public partial class MedicineType
    {
        public int MedicineTypeID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Tên loại thuốc không được dài quá 100 ký tự")]
        public string MedicineTypeName { get; set; }
    }
}
