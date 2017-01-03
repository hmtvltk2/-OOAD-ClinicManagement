namespace ClinicManager.DataModel
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PermissionDetail")]
    public partial class PermissionDetail
    {
        public int PermissionDetailID { get; set; }

        public int PermissionID { get; set; }

        public int UserGroupID { get; set; }

        public virtual Permission Permission { get; set; }

        public virtual UserGroup UserGroup { get; set; }
    }
}
