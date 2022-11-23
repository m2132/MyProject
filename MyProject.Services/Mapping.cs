using AutoMapper;
using MyProject.common.DTOs;
using MyProject.Common.DTOs;
using MyProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Role, RoleDTO>().ForMember(dest=>dest.Title,opt=>opt.MapFrom(src=>src.Description)).ReverseMap();
            CreateMap<Permission, PermissionDTO>().ForMember(dest=>dest.Title,opt=>opt.MapFrom(src=>src.Description)).ReverseMap();
            CreateMap<Claim,ClaimDTO>().ReverseMap();
        }
    }
}
