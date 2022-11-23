using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Repositories;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly IClaimService _claimService;

        public ClaimController(IClaimService claimService)
        {
            _claimService = claimService;
        }
        // GET: api/<ClaimController>
        [HttpGet]
        public List<ClaimDTO> Get()
        {
            return _claimService.GetList();
        }

        // GET api/<ClaimController>/5
        [HttpGet("{id}")]
        public ClaimDTO Get(int id)
        {
            return _claimService.GetById(id);
        }

        // POST api/<ClaimController>
        [HttpPost]
        public void Post([FromBody] ClaimDTO c)
        {

            _claimService.Add(c.Id,/*c.RoleId,c.PermissionId,*/c.Policy);
        }

        // PUT api/<ClaimController>/5
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] ClaimDTO c)
        {
            var claim= _claimService.GetById(id);
            claim.RoleId=c.RoleId;
            claim.PermissionId=c.PermissionId;
            claim.Policy=c.Policy;
            _claimService.Update(claim);
        }

        // DELETE api/<ClaimController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _claimService.Delete(id);
        }
    }
}
