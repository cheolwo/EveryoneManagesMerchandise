using BusinessView.ofDTO.ofCommon;
using BusinessView.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofCommon
{
    public class BaseRoleViewModel : BaseViewModel
    {
        protected readonly IActorViewService<IdentityRoleDTO> _actorViewService;
        protected IdentityRoleDTO? identityRoleDTO = new();
        public IdentityRoleDTO? IdentityRoleDTO
        {
            get => identityRoleDTO;
            set
            {
                SetValue(ref identityRoleDTO, value);
            }
        }
        public BaseRoleViewModel(IActorViewService<IdentityRoleDTO> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        public async Task GetByIdAsync(string id)
        {
            IdentityRoleDTO = await _actorViewService.GetByIdAsync(id);
        }
    }
    public class PostRoleViewModel : BaseRoleViewModel
    {
        private bool isPost = false;
        public bool IsPost
        {
            get => isPost;
            set
            {
                isPost = value;
                OnPropertyChanged();
            }
        }
        private IdentityRoleDTO? postIdentityRoleDTO = new();
        public IdentityRoleDTO? PostIdentityRoleDTO
        {
            get => postIdentityRoleDTO;
            set
            {
                SetValue(ref postIdentityRoleDTO, value);
            }
        }
        public PostRoleViewModel(IActorViewService<IdentityRoleDTO> actorViewService)
            : base(actorViewService)
        {

        }
        public async Task PostAsync(IdentityRoleDTO identityRoleDTO)
        {
            var PostRole = await _actorViewService.PostAsync(identityRoleDTO);
            if (PostRole != null)
            {
                PostIdentityRoleDTO = PostRole;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            identityRoleDTO = new();
            postIdentityRoleDTO = new();
            OnPropertyChanged();
        }
    }
    public class PutRoleViewModel : BaseRoleViewModel
    {
        private bool isPut = false;
        public bool IsPut
        {
            get => isPut;
            set
            {
                isPut = value;
                OnPropertyChanged();
            }
        }
        private IdentityRoleDTO? putIdentityRoleDTO = new();
        public IdentityRoleDTO? PutIdentityRoleDTO
        {
            get => putIdentityRoleDTO;
            set
            {
                SetValue(ref putIdentityRoleDTO, value);
            }
        }
        public PutRoleViewModel(IActorViewService<IdentityRoleDTO> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task PutAsync(IdentityRoleDTO identityRoleDTO)
        {
            var PutRole = await _actorViewService.PutAsync(identityRoleDTO);
            if(PutRole != null)
            {
                isPut = true;
                PutIdentityRoleDTO = PutRole;
            }
        }
        public void Reset()
        {
            isPut = false;
            identityRoleDTO = new();
            putIdentityRoleDTO = new();
            OnPropertyChanged();
        }
    }
    public class DeleteRoleViewModel : BaseRoleViewModel
    {
        public DeleteRoleViewModel(IActorViewService<IdentityRoleDTO> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _actorViewService.DeleteAsync(id);
        }
        public void Reset()
        {
            IdentityRoleDTO = new();
        }
    }
    public class GetsRoleViewModel : BaseRoleViewModel
    {
        private List<IdentityRoleDTO> identityRoleDTOs = new();
        public List<IdentityRoleDTO> IdentityRoleDTOs
        {
            get=> identityRoleDTOs;
            set
            {
                SetValue(ref identityRoleDTOs, value);   
            }
        }
        public GetsRoleViewModel(IActorViewService<IdentityRoleDTO> actorViewService)
            :base(actorViewService)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<IdentityRoleDTO>? dtos = await _actorViewService.GetAsync();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    identityRoleDTOs.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void DelteAsync(string id)
        {
            var obj = IdentityRoleDTOs.Find(e => e.Id.Equals(id));
            if(obj != null) { IdentityRoleDTOs.Remove(obj); OnPropertyChanged(); }
        }
    }
}
