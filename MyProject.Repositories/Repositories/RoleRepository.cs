using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProject.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IContext _context;

        public RoleRepository(IContext context)
        {
            _context = context;
        }

        public Role Add(int id, string name, string description)
        {
            Role newRole = new Role { Id = id, Name = name, Description = description };
            _context.Roles.Add(newRole);
            return newRole;
        }

        public void Delete(int id)
        {
            Role delrl = _context.Roles.Find(id);
            _context.Roles.Remove(delrl);
        }

        public List<Role> GetAll()
        {
            return _context.Roles.ToList();
        }

        public Role GetById(int id)
        {
            return _context.Roles.Find(id);
        }

        public Role Update(Role r)
        {
            Role updateRole = _context.Roles.Find(r.Id);
            updateRole.Name = r.Name;
            updateRole.Description = r.Description;
            return updateRole;
        }
        
    }
}
