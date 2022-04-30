using BusinessView.ofDTO.ofCommon;
using BusinessView.ofGeneric;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace BusinessView.ofViewModels.ofWebApp.ofCommon
{
    // 단순 유저 CRUD 용 BaseUserViewModel
    public class BaseUserViewModel : BaseViewModel
    {
        protected IActorViewService<IdentityUserDTO> _actorViewService;
        private IdentityUserDTO identityUserDTO = new();
        public IdentityUserDTO IdentityUserDTO
        {
            get => identityUserDTO;
            set
            {
                SetValue(ref identityUserDTO, value);
            }
        }
        public BaseUserViewModel(IActorViewService<IdentityUserDTO> actorViewService)
        {
            _actorViewService = actorViewService;
        }
    }
    public class GetUserViewModel  : BaseUserViewModel
    {
        protected IHttpContextAccessor _httpContextAccessor;      
        public GetUserViewModel(IActorViewService<IdentityUserDTO> actorViewService,
            IHttpContextAccessor httpContextAccessor) : base(actorViewService)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<IdentityUserDTO> GetCurrentUserAsync(UserManager<IdentityUser> userManager)
        {
            var CurrentUser = await userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            return ModelToDTO<IdentityUser, IdentityUserDTO>.ConvertToDTO(CurrentUser, new IdentityUserDTO());
        }
        public async Task<IdentityUser> GetCurrentIdentityUserAsync(UserManager<IdentityUser> userManager)
        {
            return await userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
        }
    }
    public class PostUserViewModel : BaseUserViewModel
    {      
        public PostUserViewModel(IActorViewService<IdentityUserDTO> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task Create(IdentityUserDTO identityUserDTO)
        {
            await _actorViewService.Post(identityUserDTO);
        }
    }
    public class PutUserViewModel : BaseUserViewModel
    {
        public PutUserViewModel(IActorViewService<IdentityUserDTO> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task Update(IdentityUserDTO identityUserDTO)
        {
            await _actorViewService.Put(identityUserDTO);
        }
    }
    public class DeleteUserViewModel : BaseUserViewModel
    {
        public DeleteUserViewModel(IActorViewService<IdentityUserDTO> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task Delete(string id)
        {
            await _actorViewService.Delete(id);
        }
    }
    public class GetsUserViewModel : BaseUserViewModel
    {
        private List<IdentityUserDTO> identityUserDTOs = new();
        public List<IdentityUserDTO> IdentityUserDTOs
        {
            get => identityUserDTOs;
            private set
            {
                identityUserDTOs = value;
                OnPropertyChanged();
            }
        }
        private IdentityUserDTO identityUserDTO = new();
        public IdentityUserDTO IdentityUserDTO
        {
            get => identityUserDTO;
            set
            {
                identityUserDTO = value;
                OnPropertyChanged();
            }
        }
        public GetsUserViewModel(IActorViewService<IdentityUserDTO> actorViewService,
            IHttpContextAccessor httpContextAccessor) : base(actorViewService)
        {
        }
        public async Task ExecuteLoadIdentityUserDTOCommand()
        {
            IsBusy = true;
            try
            {
                var identityUserDTOs = await _actorViewService.Get();
                if (identityUserDTOs != null)
                {
                    foreach (var identityUserDTO in identityUserDTOs)
                    {
                        IdentityUserDTOs.Add(identityUserDTO);
                    }
                    IdentityUserDTO = IdentityUserDTOs.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                IsBusy = false;
                
            }
        }
    }
}
