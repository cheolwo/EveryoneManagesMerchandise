﻿using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofPlatform;
using BusinessData.ofWarehouse.ofInterface.ofPlatform;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessData.ofWarehouse.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WCommodityServer.Controllers.ofPlatform
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformWCommodityController : ControllerBase
    {
        private readonly ILogger<PlatformWCommodityController> _logger;
        private readonly IPlatformWCommodityManager _PlatformWCommodityManager;
        private readonly IPlatformWCommodityRepository _PlatformWCommodityRepository;

        public PlatformWCommodityController(ILogger<PlatformWCommodityController> logger,
            IPlatformWCommodityManager PlatformWCommodityManager, 
            IPlatformWCommodityRepository PlatformWCommodityRepository)
        {
            _logger = logger;
            _PlatformWCommodityRepository = PlatformWCommodityRepository;
            _PlatformWCommodityManager = PlatformWCommodityManager;
        }
        // GET: api/<PlatformWCommodityController>
        [HttpGet("{id}")]
        public async Task<ActionResult<PlatformWCommodity>> GetWCommodity(string id)
        {
            var WCommodity = await _PlatformWCommodityRepository.GetByIdAsync(id);

            if (WCommodity == null)
            {
                return NotFound();
            }
            var GetPlatformWCommodity = ModelToDTO<WCommodity, PlatformWCommodity>.ConvertToDTO(WCommodity, new PlatformWCommodity());
            return GetPlatformWCommodity;
        }

        [HttpPost]
        public async Task<ActionResult<PlatformWCommodity>> PostWCommodity(PlatformWCommodity PlatformWCommodity)
        {
            var model = DTOToModel<PlatformWCommodity, WCommodity>.ConvertToModel(PlatformWCommodity, new());
            var newWCommodity = await _PlatformWCommodityManager.CreateAsync(model);

            //return CreatedAtAction("GetWCommodity", new { id = WCommodity.Id }, WCommodity);
            return CreatedAtAction(nameof(GetWCommodity), new { id = newWCommodity.Id }, newWCommodity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutWCommodity(string id, PlatformWCommodity PlatformWCommodity)
        {
            var model = DTOToModel<PlatformWCommodity, WCommodity>.ConvertToModel(PlatformWCommodity, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _PlatformWCommodityManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWCommodity(string id)
        {
            var WCommodity = await _PlatformWCommodityRepository.GetByIdAsync(id);
            if (WCommodity == null)
            {
                return NotFound();
            }
            await _PlatformWCommodityRepository.DeleteByIdAsync(WCommodity.Id);

            return NoContent();
        }
    }
}
