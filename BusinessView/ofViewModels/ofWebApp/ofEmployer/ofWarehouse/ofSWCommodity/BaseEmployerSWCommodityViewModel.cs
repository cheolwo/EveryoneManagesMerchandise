using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerSWCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerSWCommodity? _EmployerSWCommodity = new();
        public EmployerSWCommodity? EmployerSWCommodity
        {
            get => _EmployerSWCommodity;
            set
            {
                SetValue(ref _EmployerSWCommodity, value);
            }
        }
        public BaseEmployerSWCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerSWCommodity = await _EmployerActorContext.GetByIdAsync<EmployerSWCommodity>(id);
        }
    }
    public class PostEmployerSWCommodityViewModel : BaseEmployerSWCommodityViewModel
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
        private EmployerSWCommodity? _postEmployerSWCommodity = new();
        public EmployerSWCommodity? PostEmployerSWCommodity
        {
            get => _postEmployerSWCommodity;
            set
            {
                SetValue(ref _postEmployerSWCommodity, value);
            }
        }
        public PostEmployerSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerSWCommodity EmployerSWCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerSWCommodity>(EmployerSWCommodity);
            if (PostValue != null)
            {
                PostEmployerSWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerSWCommodity = new();
            _postEmployerSWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerSWCommodityViewModel : BaseEmployerSWCommodityViewModel
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
        private EmployerSWCommodity? _putEmployerSWCommodity = new();
        public EmployerSWCommodity? PutEmployerSWCommodity
        {
            get => _putEmployerSWCommodity;
            set
            {
                SetValue(ref _putEmployerSWCommodity, value);
            }
        }
        public PutEmployerSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerSWCommodity EmployerSWCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerSWCommodity>(EmployerSWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerSWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerSWCommodity = new();
            _putEmployerSWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerSWCommodityViewModel : BaseEmployerSWCommodityViewModel
    {
        public DeleteEmployerSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerSWCommodity>(id);
        }
        public void Reset()
        {
            EmployerSWCommodity = new();
        }
    }
    public class GetsEmployerSWCommodityViewModel : BaseEmployerSWCommodityViewModel
    {
        private List<EmployerSWCommodity> _EmployerSWCommoditys = new();
        public List<EmployerSWCommodity> EmployerSWCommoditys
        {
            get=> _EmployerSWCommoditys;
            set
            {
                SetValue(ref _EmployerSWCommoditys, value);   
            }
        }
        public GetsEmployerSWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerSWCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerSWCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerSWCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerSWCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerSWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerSWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerSWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
