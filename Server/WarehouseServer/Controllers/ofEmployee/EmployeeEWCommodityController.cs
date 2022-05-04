﻿using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EWCommodityServer.Controllers.ofEmployee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeEWCommodityController : ControllerBase
    {
        private readonly ILogger<EmployeeEWCommodityController> _logger;
        private readonly IEmployeeEWCommodityManager _EmployeeEWCommodityManager;
        private readonly IEmployeeEWCommodityRepository _EmployeeEWCommodityRepository;

        public EmployeeEWCommodityController(ILogger<EmployeeEWCommodityController> logger,
            IEmployeeEWCommodityManager EmployeeEWCommodityManager, 
            IEmployeeEWCommodityRepository EmployeeEWCommodityRepository)
        {
            _logger = logger;
            _EmployeeEWCommodityRepository = EmployeeEWCommodityRepository;
            _EmployeeEWCommodityManager = EmployeeEWCommodityManager;
        }
        // GET: api/<EmployeeEWCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeEWCommodity>> GetEWCommodity(string id)
        {
            var EWCommodity = await _EmployeeEWCommodityRepository.GetByIdAsync(id);

            if (EWCommodity == null)
            {
                return NotFound();
            }
            var GetEmployeeEWCommodity = ModelToDTO<EWCommodity, EmployeeEWCommodity>.ConvertToDTO(EWCommodity, new EmployeeEWCommodity());
            return GetEmployeeEWCommodity;
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeEWCommodity>> PostEWCommodity(EmployeeEWCommodity EmployeeEWCommodity)
        {
            var model = DTOToModel<EmployeeEWCommodity, EWCommodity>.ConvertToModel(EmployeeEWCommodity, new());
            var newEWCommodity = await _EmployeeEWCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetEWCommodity", new { id = EWCommodity.Id }, EWCommodity);
            return CreatedAtAction(nameof(GetEWCommodity), new { id = newEWCommodity.Id }, newEWCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEWCommodity(string id, EmployeeEWCommodity EmployeeEWCommodity)
        {
            var model = DTOToModel<EmployeeEWCommodity, EWCommodity>.ConvertToModel(EmployeeEWCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployeeEWCommodityManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEWCommodity(string id)
        {
            var EWCommodity = await _EmployeeEWCommodityRepository.GetByIdAsync(id);
            if (EWCommodity == null)
            {
                return NotFound();
            }
            await _EmployeeEWCommodityRepository.DeleteByIdAsync(EWCommodity.Id);

            return NoContent();
        }
    }
}
