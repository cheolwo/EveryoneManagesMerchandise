using BusinessView.ofDTO.ofCommon;
using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityUserDTOController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;

        public IdentityUserDTOController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IEnumerable<IdentityUserDTO>> Get()
        {
            var Users = _userManager.Users;
            List<IdentityUserDTO> result = new List<IdentityUserDTO>();
            foreach (var user in Users)
            {
                var identityuserdto = ModelToDTO<IdentityUser, IdentityUserDTO>.ConvertToDTO(user, new IdentityUserDTO());
                result.Add(identityuserdto);
            }
            return result;
        }
    }
}
