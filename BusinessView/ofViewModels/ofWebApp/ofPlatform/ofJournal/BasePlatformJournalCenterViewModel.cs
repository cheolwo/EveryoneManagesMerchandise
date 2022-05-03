using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofJournal.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofJournal
{
    public class BasePlatformJournalCenterViewModel : BaseViewModel
    {
        protected readonly PlatformActorContext _PlatformActorContext;
        protected PlatformJournalCenter? _PlatformJournalCenter = new();
        public PlatformJournalCenter? PlatformJournalCenter
        {
            get => _PlatformJournalCenter;
            set
            {
                SetValue(ref _PlatformJournalCenter, value);
            }
        }
        public BasePlatformJournalCenterViewModel(PlatformActorContext PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            PlatformJournalCenter = await _PlatformActorContext.GetByIdAsync<PlatformJournalCenter>(id);
        }
    }
    public class PostPlatformJournalCenterViewModel : BasePlatformJournalCenterViewModel
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
        private PlatformJournalCenter? _postPlatformJournalCenter = new();
        public PlatformJournalCenter? PostPlatformJournalCenter
        {
            get => _postPlatformJournalCenter;
            set
            {
                SetValue(ref _postPlatformJournalCenter, value);
            }
        }
        public PostPlatformJournalCenterViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
        public async Task PostAsync(PlatformJournalCenter PlatformJournalCenter)
        {
            var PostValue = await _PlatformActorContext.PostAsync<PlatformJournalCenter>(PlatformJournalCenter);
            if (PostValue != null)
            {
                PostPlatformJournalCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _PlatformJournalCenter = new();
            _postPlatformJournalCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutPlatformJournalCenterViewModel : BasePlatformJournalCenterViewModel
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
        private PlatformJournalCenter? _putPlatformJournalCenter = new();
        public PlatformJournalCenter? PutPlatformJournalCenter
        {
            get => _putPlatformJournalCenter;
            set
            {
                SetValue(ref _putPlatformJournalCenter, value);
            }
        }
        public PutPlatformJournalCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task PutAsync(PlatformJournalCenter PlatformJournalCenter)
        {
            var PutValue = await _PlatformActorContext.PutAsync<PlatformJournalCenter>(PlatformJournalCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutPlatformJournalCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _PlatformJournalCenter = new();
            _putPlatformJournalCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeletePlatformJournalCenterViewModel : BasePlatformJournalCenterViewModel
    {
        public DeletePlatformJournalCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _PlatformActorContext.DeleteByIdAsync<PlatformJournalCenter>(id);
        }
        public void Reset()
        {
            PlatformJournalCenter = new();
        }
    }
    public class GetsPlatformJournalCenterViewModel : BasePlatformJournalCenterViewModel
    {
        private List<PlatformJournalCenter> _PlatformJournalCenters = new();
        public List<PlatformJournalCenter> PlatformJournalCenters
        {
            get=> _PlatformJournalCenters;
            set
            {
                SetValue(ref _PlatformJournalCenters, value);   
            }
        }
        public GetsPlatformJournalCenterViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<PlatformJournalCenter>? dtos = await _PlatformActorContext.GetsAsync<PlatformJournalCenter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformJournalCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<PlatformJournalCenter>? dtos = await _PlatformActorContext.GetsAsyncByUserId<PlatformJournalCenter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _PlatformJournalCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = PlatformJournalCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { PlatformJournalCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
