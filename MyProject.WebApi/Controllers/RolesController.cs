using Microsoft.AspNetCore.Mvc;
using MyProject.common.DTOs;
using MyProject.Repositories;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using MyProject.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
       
        private readonly IRoleService _roleService;

        public RolesController( IRoleService roleService)
        {   
            _roleService = roleService;
        }
        // GET: api/<RolesController>
        [HttpGet]
        public List<RoleDTO> Get()
        {
            return _roleService.GetList();
        }

        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public RoleDTO Get(int id)
        {
            return _roleService.GetById(id);
        }

        // POST api/<RolesController>
        [HttpPost]
        public void Post([FromBody] Role r)
        {
            _roleService.Add(r.Id, r.Name, r.Description);
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RoleModel r)
        {
            var role = _roleService.GetById(id);
            role.Name = r.Name;
            role.Title = r.Description;
            _roleService.Update(role);

        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _roleService.Delete(id);
        }
    }
}
