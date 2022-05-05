using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofTrade.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofTrade
{
    public class BaseEmployerTradeCenterViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerTradeCenter? _EmployerTradeCenter = new();
        public EmployerTradeCenter? EmployerTradeCenter
        {
            get => _EmployerTradeCenter;
            set
            {
                SetValue(ref _EmployerTradeCenter, value);
            }
        }
        public BaseEmployerTradeCenterViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerTradeCenter = await _EmployerActorContext.GetByIdAsync<EmployerTradeCenter>(id);
        }
    }
    public class PostEmployerTradeCenterViewModel : BaseEmployerTradeCenterViewModel
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
        private EmployerTradeCenter? _postEmployerTradeCenter = new();
        public EmployerTradeCenter? PostEmployerTradeCenter
        {
            get => _postEmployerTradeCenter;
            set
            {
                SetValue(ref _postEmployerTradeCenter, value);
            }
        }
        public PostEmployerTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerTradeCenter EmployerTradeCenter)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerTradeCenter>(EmployerTradeCenter);
            if (PostValue != null)
            {
                PostEmployerTradeCenter = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerTradeCenter = new();
            _postEmployerTradeCenter = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerTradeCenterViewModel : BaseEmployerTradeCenterViewModel
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
        private EmployerTradeCenter? _putEmployerTradeCenter = new();
        public EmployerTradeCenter? PutEmployerTradeCenter
        {
            get => _putEmployerTradeCenter;
            set
            {
                SetValue(ref _putEmployerTradeCenter, value);
            }
        }
        public PutEmployerTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerTradeCenter EmployerTradeCenter)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerTradeCenter>(EmployerTradeCenter);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerTradeCenter = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerTradeCenter = new();
            _putEmployerTradeCenter = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerTradeCenterViewModel : BaseEmployerTradeCenterViewModel
    {
        public DeleteEmployerTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerTradeCenter>(id);
        }
        public void Reset()
        {
            EmployerTradeCenter = new();
        }
    }
    public class GetsEmployerTradeCenterViewModel : BaseEmployerTradeCenterViewModel
    {
        private List<EmployerTradeCenter> _EmployerTradeCenters = new();
        public List<EmployerTradeCenter> EmployerTradeCenters
        {
            get=> _EmployerTradeCenters;
            set
            {
                SetValue(ref _EmployerTradeCenters, value);   
            }
        }
        public GetsEmployerTradeCenterViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerTradeCenter>? dtos = await _EmployerActorContext.GetsAsync<EmployerTradeCenter>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerTradeCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerTradeCenter>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerTradeCenter>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerTradeCenters.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerTradeCenters.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerTradeCenters.Remove(obj); OnPropertyChanged(); }
        }
    }
}
