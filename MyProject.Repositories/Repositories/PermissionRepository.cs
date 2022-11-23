using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProject.Repositories
{
    public class PermissionRepository : IPermissionRepository

    {
        private readonly IContext _context;

        public PermissionRepository(IContext context)
        {
            _context = context;
        }
        public Permission Add(int id, string name, string description)
        {
            Permission newPermission = new Permission { Id = id, Name = name, Description = description };
            _context.Permissions.Add(newPermission);
            return newPermission;

        }

        public void Delete(int id)
        {
            Permission delper = _context.Permissions.Find(id);
            _context.Permissions.Remove(delper);
        }

        public List<Permission> GetAll()
        {
            return _context.Permissions.ToList();
        }

        public Permission GetById(int id)
        {
            return _context.Permissions.Find( id);

        }

        public Permission Update(Permission p)
        {
            Permission updatePermission = _context.Permissions.Find(p.Id);
            updatePermission.Name = p.Name;
            updatePermission.Description = p.Description;
            return updatePermission;
        }
    }
}
