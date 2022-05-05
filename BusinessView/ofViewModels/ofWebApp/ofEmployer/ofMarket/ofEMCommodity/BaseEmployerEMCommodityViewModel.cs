using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofMarket
{
    public class BaseEmployerEMCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerEMCommodity? _EmployerEMCommodity = new();
        public EmployerEMCommodity? EmployerEMCommodity
        {
            get => _EmployerEMCommodity;
            set
            {
                SetValue(ref _EmployerEMCommodity, value);
            }
        }
        public BaseEmployerEMCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerEMCommodity = await _EmployerActorContext.GetByIdAsync<EmployerEMCommodity>(id);
        }
    }
    public class PostEmployerEMCommodityViewModel : BaseEmployerEMCommodityViewModel
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
        private EmployerEMCommodity? _postEmployerEMCommodity = new();
        public EmployerEMCommodity? PostEmployerEMCommodity
        {
            get => _postEmployerEMCommodity;
            set
            {
                SetValue(ref _postEmployerEMCommodity, value);
            }
        }
        public PostEmployerEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerEMCommodity EmployerEMCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerEMCommodity>(EmployerEMCommodity);
            if (PostValue != null)
            {
                PostEmployerEMCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerEMCommodity = new();
            _postEmployerEMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerEMCommodityViewModel : BaseEmployerEMCommodityViewModel
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
        private EmployerEMCommodity? _putEmployerEMCommodity = new();
        public EmployerEMCommodity? PutEmployerEMCommodity
        {
            get => _putEmployerEMCommodity;
            set
            {
                SetValue(ref _putEmployerEMCommodity, value);
            }
        }
        public PutEmployerEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerEMCommodity EmployerEMCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerEMCommodity>(EmployerEMCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerEMCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerEMCommodity = new();
            _putEmployerEMCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerEMCommodityViewModel : BaseEmployerEMCommodityViewModel
    {
        public DeleteEmployerEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerEMCommodity>(id);
        }
        public void Reset()
        {
            EmployerEMCommodity = new();
        }
    }
    public class GetsEmployerEMCommodityViewModel : BaseEmployerEMCommodityViewModel
    {
        private List<EmployerEMCommodity> _EmployerEMCommoditys = new();
        public List<EmployerEMCommodity> EmployerEMCommoditys
        {
            get=> _EmployerEMCommoditys;
            set
            {
                SetValue(ref _EmployerEMCommoditys, value);   
            }
        }
        public GetsEmployerEMCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerEMCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerEMCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerEMCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerEMCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEMCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerEMCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerEMCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
