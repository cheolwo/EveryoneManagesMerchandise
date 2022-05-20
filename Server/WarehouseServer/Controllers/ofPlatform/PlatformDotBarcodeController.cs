using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofPlatform;
using BusinessData.ofWarehouse.ofInterface.ofPlatform;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers.ofPlatform
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformDotBarcodeController : ControllerBase
    {
        private readonly ILogger<PlatformDotBarcodeController> _logger;
        private readonly IPlatformDotBarcodeManager _PlatformDotBarcodeManager;
        private readonly IPlatformDotBarcodeRepository _PlatformDotBarcodeRepository;

        public PlatformDotBarcodeController(ILogger<PlatformDotBarcodeController> logger,
            IPlatformDotBarcodeManager PlatformDotBarcodeManager, 
            IPlatformDotBarcodeRepository PlatformDotBarcodeRepository)
        {
            _logger = logger;
            _PlatformDotBarcodeRepository = PlatformDotBarcodeRepository;
            _PlatformDotBarcodeManager = PlatformDotBarcodeManager;
        }
        // GET: api/<PlatformDotBarcodeController>
        [HttpGet("{id}")]
        public async Task<ActionResult<PlatformDotBarcode>> GetDotBarcode(string id)
        {
            var DotBarcode = await _PlatformDotBarcodeRepository.GetByIdAsync(id);

            if (DotBarcode == null)
            {
                return NotFound();
            }
            var GetPlatformDotBarcode = ModelToDTO<DotBarcode, PlatformDotBarcode>.ConvertToDTO(DotBarcode, new PlatformDotBarcode());
            return GetPlatformDotBarcode;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlatformDotBarcode>>> Gets()
        {
            var DotBarcodes = await _PlatformDotBarcodeRepository.GetToListAsync();
            if (DotBarcodes.Count == 0)
            {
                return new List<PlatformDotBarcode>();
            }
            List<PlatformDotBarcode> PlatformDotBarcodes = new List<PlatformDotBarcode>();
            foreach (var DotBarcode in DotBarcodes)
            {
                PlatformDotBarcodes.Add(ModelToDTO<DotBarcode, PlatformDotBarcode>.ConvertToDTO(DotBarcode, new PlatformDotBarcode()));
            }
            return PlatformDotBarcodes;
        }
        [HttpGet("User")]
        public async Task<ActionResult<IEnumerable<PlatformDotBarcode>>> GetsAsyncByUserId(string userid)
        {
            var DotBarcodes = await _PlatformDotBarcodeRepository.GetToListByUserId(userid);
            if (DotBarcodes.Count == 0)
            {
                return new List<PlatformDotBarcode>();
            }
            List<PlatformDotBarcode> PlatformDotBarcodes = new List<PlatformDotBarcode>();
            foreach (var DotBarcode in DotBarcodes)
            {
                PlatformDotBarcodes.Add(ModelToDTO<DotBarcode, PlatformDotBarcode>.ConvertToDTO(DotBarcode, new PlatformDotBarcode()));
            }
            return PlatformDotBarcodes;
        }

        [HttpPost]
        public async Task<ActionResult<PlatformDotBarcode>> PostDotBarcode(PlatformDotBarcode PlatformDotBarcode)
        {
            var model = DTOToModel<PlatformDotBarcode, DotBarcode>.ConvertToModel(PlatformDotBarcode, new());
            var newDotBarcode = await _PlatformDotBarcodeManager.CreateAsync(model);

            //return CreatedAtAction("GetDotBarcode", new { id = DotBarcode.Id }, DotBarcode);
            return CreatedAtAction(nameof(GetDotBarcode), new { id = newDotBarcode.Id }, newDotBarcode);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDotBarcode(string id, PlatformDotBarcode PlatformDotBarcode)
        {
            var model = DTOToModel<PlatformDotBarcode, DotBarcode>.ConvertToModel(PlatformDotBarcode, new());
            if (id != model.Id)
            {
                return BadRequest();
            }
            try
            {
                await _PlatformDotBarcodeManager.UpdateAsync(model);
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
            var DotBarcode = await _PlatformDotBarcodeRepository.GetByIdAsync(id);
            if (DotBarcode == null)
            {
                return NotFound();
            }
            await _PlatformDotBarcodeRepository.DeleteByIdAsync(DotBarcode.Id);

            return NoContent();
        }
    }
}
