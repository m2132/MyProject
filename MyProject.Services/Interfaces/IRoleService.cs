using MyProject.common.DTOs;
using MyProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IRoleService
    {
        List<RoleDTO> GetList();

        RoleDTO GetById(int id);

        RoleDTO Add(int id, string name, string description);

        RoleDTO Update(RoleDTO r);

        void Delete(int id);
    }
}
