﻿using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofWarehouse.ofEmployer;
using BusinessData.ofWarehouse.Model;
using BusinessData.ofWarehouse.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotBarcodeServer.Controllers.ofEmployer
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerDotBarcodeController : ControllerBase
    {
        private readonly ILogger<EmployerDotBarcodeController> _logger;
        private readonly IEmployerDotBarcodeManager _EmployerDotBarcodeManager;
        private readonly IEmployerDotBarcodeRepository _EmployerDotBarcodeRepository;

        public EmployerDotBarcodeController(ILogger<EmployerDotBarcodeController> logger,
            IEmployerDotBarcodeManager EmployerDotBarcodeManager, 
            IEmployerDotBarcodeRepository EmployerDotBarcodeRepository)
        {
            _logger = logger;
            _EmployerDotBarcodeRepository = EmployerDotBarcodeRepository;
            _EmployerDotBarcodeManager = EmployerDotBarcodeManager;
        }
        // GET: api/<EmployerDotBarcodeController>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployerDotBarcode>> GetDotBarcode(string id)
        {
            var DotBarcode = await _EmployerDotBarcodeRepository.GetByIdAsync(id);

            if (DotBarcode == null)
            {
                return NotFound();
            }
            var GetEmployerDotBarcode = ModelToDTO<DotBarcode, EmployerDotBarcode>.ConvertToDTO(DotBarcode, new EmployerDotBarcode());
            return GetEmployerDotBarcode;
        }

        [HttpPost]
        public async Task<ActionResult<EmployerDotBarcode>> PostDotBarcode(EmployerDotBarcode EmployerDotBarcode)
        {
            var model = DTOToModel<EmployerDotBarcode, DotBarcode>.ConvertToModel(EmployerDotBarcode, new());
            var newDotBarcode = await _EmployerDotBarcodeManager.CreateAsync(model);

            //return CreatedAtAction("GetDotBarcode", new { id = DotBarcode.Id }, DotBarcode);
            return CreatedAtAction(nameof(GetDotBarcode), new { id = newDotBarcode.Id }, newDotBarcode);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDotBarcode(string id, EmployerDotBarcode EmployerDotBarcode)
        {
            var model = DTOToModel<EmployerDotBarcode, DotBarcode>.ConvertToModel(EmployerDotBarcode, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _EmployerDotBarcodeManager.UpdateAsync(model);
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
            var DotBarcode = await _EmployerDotBarcodeRepository.GetByIdAsync(id);
            if (DotBarcode == null)
            {
                return NotFound();
            }
            await _EmployerDotBarcodeRepository.DeleteByIdAsync(DotBarcode.Id);

            return NoContent();
        }
    }
}
