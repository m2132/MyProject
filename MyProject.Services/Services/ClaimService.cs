using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPolicy = MyProject.Repositories.EPolicy;

namespace MyProject.Services.Services
{
    public class ClaimService : IClaimService
    {
        private readonly IClaimRepository _claimRepository;
        private readonly IMapper _mapper;
        public ClaimService(IClaimRepository claimRepository, IMapper mapper)
        {
            _claimRepository = claimRepository;
            _mapper = mapper;
        }

        public ClaimDTO Add(int id, Role roleId, Permission permissionId, Common.DTOs.EPolicy policy)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.Add(id, roleId, permissionId, (EPolicy)policy));
        }

        public void Delete(int id)
        {
            _claimRepository.Delete(id);
        }

        public List<ClaimDTO> GetList()
        {
            return _mapper.Map<List<ClaimDTO>>(_claimRepository.GetAll());
        }

        public ClaimDTO GetById(int id)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.GetById(id));
        }

        public ClaimDTO Update(ClaimDTO c)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.Update(_mapper.Map<Claim>(c)));
        }

        public ClaimDTO Add(int id, Common.DTOs.EPolicy policy)
        {
            throw new NotImplementedException();
        }
    }
}
