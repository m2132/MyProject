﻿using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IClaimService
    {
        List<ClaimDTO> GetList();

        ClaimDTO GetById(int id);

       ClaimDTO Add(int id,/* Role roleId, Permission permissionId,*/ EPolicy policy);

        ClaimDTO Update(ClaimDTO c);

        void Delete(int id);
    }
}
