using AutoMapper;
using MyProject.common.DTOs;
using MyProject.Common.DTOs;
using MyProject.Repositories;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class PermissionSerevice : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;

        public PermissionSerevice(IPermissionRepository permissionRepository, IMapper mapper)
        {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
        }

        public PermissionDTO Add(int id, string name, string description)
        {
            return _mapper.Map<PermissionDTO>(_permissionRepository.Add(id, name, description));
        }

        public void Delete(int id)
        {
            _permissionRepository.Delete(id);
        }

        public PermissionDTO GetById(int id)
        {
            return _mapper.Map<PermissionDTO>(_permissionRepository.GetById(id));
        }

        public List<PermissionDTO> GetList()
        {
            return _mapper.Map<List<PermissionDTO>>(_permissionRepository.GetAll());
        }

        public PermissionDTO Update(PermissionDTO p)
        {
            return _mapper.Map<PermissionDTO>(_permissionRepository.Update(_mapper.Map<Permission>(p)));
        }
    }
}
