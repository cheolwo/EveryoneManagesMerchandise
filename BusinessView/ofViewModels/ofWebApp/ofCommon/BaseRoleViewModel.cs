using BusinessView.ofDTO.ofCommon;
using BusinessView.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofCommon
{
    public class BaseRoleViewModel : BaseViewModel
    {
        protected readonly IActorViewService<IdentityRoleDTO> _actorViewService;
        protected IdentityRoleDTO? _identityRoleDTO = new();
        public IdentityRoleDTO? IdentityRoleDTO
        {
            get => _identityRoleDTO;
            set
            {
                SetValue(ref _identityRoleDTO, value);
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
        private bool _isPost = false;
        public bool IsPost
        {
            get => _isPost;
            set
            {
                _isPost = value;
                OnPropertyChanged();
            }
        }
        private IdentityRoleDTO? _postIdentityRoleDTO = new();
        public IdentityRoleDTO? PostIdentityRoleDTO
        {
            get => _postIdentityRoleDTO;
            set
            {
                SetValue(ref _postIdentityRoleDTO, value);
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
            _identityRoleDTO = new();
            _postIdentityRoleDTO = new();
            OnPropertyChanged();
        }
    }
    public class PutRoleViewModel : BaseRoleViewModel
    {
        private bool _isPut = false;
        public bool IsPut
        {
            get => _isPut;
            set
            {
                _isPut = value;
                OnPropertyChanged();
            }
        }
        private IdentityRoleDTO? _putIdentityRoleDTO = new();
        public IdentityRoleDTO? PutIdentityRoleDTO
        {
            get => _putIdentityRoleDTO;
            set
            {
                SetValue(ref _putIdentityRoleDTO, value);
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
            _identityRoleDTO = new();
            _putIdentityRoleDTO = new();
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
        private List<IdentityRoleDTO> _identityRoleDTOs = new();
        public List<IdentityRoleDTO> IdentityRoleDTOs
        {
            get=> _identityRoleDTOs;
            set
            {
                SetValue(ref _identityRoleDTOs, value);   
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
                    _identityRoleDTOs.Add(dto);
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
