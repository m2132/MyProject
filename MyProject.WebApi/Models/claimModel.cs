using MyProject.Common.DTOs;

namespace MyProject.WebApi.Models
{
    public class claimModel
    {
        public int RoleId { get; set; }

        public int PermissionId { get; set; }

        public EPolicy Policy { get; set; }
    }
}
