﻿using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessView.ofGeneric;
using BusinessView.ofWarehouse.ofEmployee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MWCommodityServer.Controllers.ofEmployee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeMWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployeeMWCommodityController> _logger;
        private readonly IEmployeeMWCommodityManager _EmployeeMWCommodityManager;
        private readonly IEmployeeMWCommodityRepository _EmployeeMWCommodityRepository;

        public EmployeeMWCommodityController(ILogger<EmployeeMWCommodityController> logger,
            IEmployeeMWCommodityManager EmployeeMWCommodityManager, 
            IEmployeeMWCommodityRepository EmployeeMWCommodityRepository)
        {
            _logger = logger;
            _EmployeeMWCommodityRepository = EmployeeMWCommodityRepository;
            _EmployeeMWCommodityManager = EmployeeMWCommodityManager;
        }
        // GET: api/<EmployeeMWCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeMWCommodity>> GetMWCommodity(string id)
        {
            var MWCommodity = await _EmployeeMWCommodityRepository.GetByIdAsync(id);

            if (MWCommodity == null)
            {
                return NotFound();
            }
            var GetEmployeeMWCommodity = ModelToDTO<MWCommodity, EmployeeMWCommodity>.ConvertToDTO(MWCommodity, new EmployeeMWCommodity());
            return GetEmployeeMWCommodity;
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeMWCommodity>> PostMWCommodity(EmployeeMWCommodity EmployeeMWCommodity)
        {
            var model = DTOToModel<EmployeeMWCommodity, MWCommodity>.ConvertToModel(EmployeeMWCommodity, new());
            var newMWCommodity = await _EmployeeMWCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetMWCommodity", new { id = MWCommodity.Id }, MWCommodity);
            return CreatedAtAction(nameof(GetMWCommodity), new { id = newMWCommodity.Id }, newMWCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMWCommodity(string id, EmployeeMWCommodity EmployeeMWCommodity)
        {
            var model = DTOToModel<EmployeeMWCommodity, MWCommodity>.ConvertToModel(EmployeeMWCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployeeMWCommodityManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMWCommodity(string id)
        {
            var MWCommodity = await _EmployeeMWCommodityRepository.GetByIdAsync(id);
            if (MWCommodity == null)
            {
                return NotFound();
            }
            await _EmployeeMWCommodityRepository.DeleteByIdAsync(MWCommodity.Id);

            return NoContent();
        }
    }
}
