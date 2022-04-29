﻿using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessData.ofWarehouse.Model;
using BusinessView.ofWarehouse.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessData.ofWarehouse.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofPlatform;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofPlatform
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformMWCommodityController : ControllerBase
    {
        private readonly ILogger<PlatformMWCommodityController> _logger;
        private readonly IPlatformMWCommodityManager _PlatformMWCommodityManager;
        private readonly IPlatformMWCommodityRepository _PlatformMWCommodityRepository;

        public PlatformMWCommodityController(ILogger<PlatformMWCommodityController> logger,
            IPlatformMWCommodityManager PlatformMWCommodityManager, 
            IPlatformMWCommodityRepository PlatformMWCommodityRepository)
        {
            _logger = logger;
            _PlatformMWCommodityRepository = PlatformMWCommodityRepository;
            _PlatformMWCommodityManager = PlatformMWCommodityManager;
        }
        // GET: api/<PlatformMWCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<PlatformMWCommodity>> GetMWCommodity(string id)
        {
            var MWCommodity = await _PlatformMWCommodityRepository.GetByIdAsync(id);

            if (MWCommodity == null)
            {
                return NotFound();
            }
            var GetPlatformMWCommodity = ModelToDTO<MWCommodity, PlatformMWCommodity>.ConvertToDTO(MWCommodity, new PlatformMWCommodity());
            return GetPlatformMWCommodity;
        }

        [HttpPost]
        public async Task<ActionResult<PlatformMWCommodity>> PostMWCommodity(PlatformMWCommodity PlatformMWCommodity)
        {
            var model = DTOToModel<PlatformMWCommodity, MWCommodity>.ConvertToModel(PlatformMWCommodity, new());
            var newMWCommodity = await _PlatformMWCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetMWCommodity", new { id = MWCommodity.Id }, MWCommodity);
            return CreatedAtAction(nameof(GetMWCommodity), new { id = newMWCommodity.Id }, newMWCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMWCommodity(string id, PlatformMWCommodity PlatformMWCommodity)
        {
            var model = DTOToModel<PlatformMWCommodity, MWCommodity>.ConvertToModel(PlatformMWCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _PlatformMWCommodityManager.UpdateAsync(model);
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
            var MWCommodity = await _PlatformMWCommodityRepository.GetByIdAsync(id);
            if (MWCommodity == null)
            {
                return NotFound();
            }
            await _PlatformMWCommodityRepository.DeleteByIdAsync(MWCommodity.Id);

            return NoContent();
        }
    }
}
