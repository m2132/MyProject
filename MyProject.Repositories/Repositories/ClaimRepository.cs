using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProject.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly IContext _context;

        public ClaimRepository(IContext context)
        {
            _context = context;
        }
        public Claim Add(int id, Role roleId, Permission permissionId, EPolicy policy)
        {
            Claim newClaim = new Claim { Id = id, Permission = permissionId, Role = roleId, Policy = policy };
            _context.Claims.Add(newClaim);
            return newClaim;
        }

        public void Delete(int id)
        {
            Claim delcl = _context.Claims.Find(id);
            _context.Claims.Remove(delcl);
        }

        public List<Claim> GetAll()
        {
            return _context.Claims.ToList();
        }

        public Claim GetById(int id)
        {
            return _context.Claims.Find(id);
        }

        public Claim Update(Claim c)
        {
            Claim updateClaim = _context.Claims.Find( c.Id);
            updateClaim.Role = c.Role;
            updateClaim.Permission = c.Permission;
            updateClaim.Policy = c.Policy;
            return updateClaim;
        }
    }
}
