
using MyProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public enum EPolicy
    {
        Allow = 1,
        Deny = 2,
    }
    public class ClaimDTO
    {
        public int Id { get; set; }

        public Role RoleId { get; set; }

        public Permission PermissionId { get; set; }

        public EPolicy Policy { get; set; }

    }
}
