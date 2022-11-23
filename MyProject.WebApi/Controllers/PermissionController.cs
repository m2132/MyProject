using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
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
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionService;
        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        // GET: api/<PermissionController>
        [HttpGet]
        public List<PermissionDTO> Get()
        {
            return _permissionService.GetList();
        }

        // GET api/<PermissionController>/5
        [HttpGet("{id}")]
        public PermissionDTO Get(int id)
        {
            return _permissionService.GetById(id);
        }

        // POST api/<PermissionController>
        [HttpPost]
        public void Post([FromBody] Permission p)
        {
            _permissionService.Add(p.Id, p.Name, p.Description);
        }

        // PUT api/<PermissionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PermissionModel p)
        {
            var Permission = _permissionService.GetById(id);
            Permission.Name = p.Name;
            Permission.Title = p.Description;
            _permissionService.Update(Permission);

        }

        // DELETE api/<PermissionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _permissionService.Delete(id);
        }
    }
}
