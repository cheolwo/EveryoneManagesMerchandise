using BusinessView.ofDTO.ofCommon;
using BusinessView.ofGeneric;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BusinessView.ofViewModels.ofWebApp.ofCommon
{
    // 단순 유저 CRUD 용 BaseUserViewModel
    public class BaseUserViewModel : INotifyPropertyChanged
    {
        protected IActorViewService<IdentityUserDTO> _actorViewService;
        public BaseUserViewModel(IActorViewService<IdentityUserDTO> actorViewService)
        {
            _actorViewService = actorViewService;
        }
        private bool isBusy = false;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                SetValue(ref isBusy, value);
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected void SetValue<T>(ref T backingFiled, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingFiled, value)) return;
            backingFiled = value;
            OnPropertyChanged(propertyName);
        }
    }
    // Gets
    public class UsersViewModel : BaseUserViewModel
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
        public UsersViewModel(IActorViewService<IdentityUserDTO> actorViewService) : base(actorViewService)
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
