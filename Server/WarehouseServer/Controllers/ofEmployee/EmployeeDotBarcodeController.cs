﻿using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotBarcodeServer.Controllers.ofEmployee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDotBarcodeController : ControllerBase
    {
        private readonly ILogger<EmployeeDotBarcodeController> _logger;
        private readonly IEmployeeDotBarcodeManager _EmployeeDotBarcodeManager;
        private readonly IEmployeeDotBarcodeRepository _EmployeeDotBarcodeRepository;

        public EmployeeDotBarcodeController(ILogger<EmployeeDotBarcodeController> logger,
            IEmployeeDotBarcodeManager EmployeeDotBarcodeManager, 
            IEmployeeDotBarcodeRepository EmployeeDotBarcodeRepository)
        {
            _logger = logger;
            _EmployeeDotBarcodeRepository = EmployeeDotBarcodeRepository;
            _EmployeeDotBarcodeManager = EmployeeDotBarcodeManager;
        }
        // GET: api/<EmployeeDotBarcodeController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDotBarcode>> GetDotBarcode(string id)
        {
            var DotBarcode = await _EmployeeDotBarcodeRepository.GetByIdAsync(id);

            if (DotBarcode == null)
            {
                return NotFound();
            }
            var GetEmployeeDotBarcode = ModelToDTO<DotBarcode, EmployeeDotBarcode>.ConvertToDTO(DotBarcode, new EmployeeDotBarcode());
            return GetEmployeeDotBarcode;
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeDotBarcode>> PostDotBarcode(EmployeeDotBarcode EmployeeDotBarcode)
        {
            var model = DTOToModel<EmployeeDotBarcode, DotBarcode>.ConvertToModel(EmployeeDotBarcode, new());
            var newDotBarcode = await _EmployeeDotBarcodeManager.CreateAsync(model);

            //return CreatedAtAction("GetDotBarcode", new { id = DotBarcode.Id }, DotBarcode);
            return CreatedAtAction(nameof(GetDotBarcode), new { id = newDotBarcode.Id }, newDotBarcode);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDotBarcode(string id, EmployeeDotBarcode EmployeeDotBarcode)
        {
            var model = DTOToModel<EmployeeDotBarcode, DotBarcode>.ConvertToModel(EmployeeDotBarcode, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployeeDotBarcodeManager.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDotBarcode(string id)
        {
            var DotBarcode = await _EmployeeDotBarcodeRepository.GetByIdAsync(id);
            if (DotBarcode == null)
            {
                return NotFound();
            }
            await _EmployeeDotBarcodeRepository.DeleteByIdAsync(DotBarcode.Id);

            return NoContent();
        }
    }
}
