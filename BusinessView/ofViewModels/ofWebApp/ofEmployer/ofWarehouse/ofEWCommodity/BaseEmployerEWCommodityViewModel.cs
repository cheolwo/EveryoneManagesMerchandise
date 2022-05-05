using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofWarehouse
{
    public class BaseEmployerEWCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerEWCommodity? _EmployerEWCommodity = new();
        public EmployerEWCommodity? EmployerEWCommodity
        {
            get => _EmployerEWCommodity;
            set
            {
                SetValue(ref _EmployerEWCommodity, value);
            }
        }
        public BaseEmployerEWCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerEWCommodity = await _EmployerActorContext.GetByIdAsync<EmployerEWCommodity>(id);
        }
    }
    public class PostEmployerEWCommodityViewModel : BaseEmployerEWCommodityViewModel
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
        private EmployerEWCommodity? _postEmployerEWCommodity = new();
        public EmployerEWCommodity? PostEmployerEWCommodity
        {
            get => _postEmployerEWCommodity;
            set
            {
                SetValue(ref _postEmployerEWCommodity, value);
            }
        }
        public PostEmployerEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerEWCommodity EmployerEWCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerEWCommodity>(EmployerEWCommodity);
            if (PostValue != null)
            {
                PostEmployerEWCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerEWCommodity = new();
            _postEmployerEWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerEWCommodityViewModel : BaseEmployerEWCommodityViewModel
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
        private EmployerEWCommodity? _putEmployerEWCommodity = new();
        public EmployerEWCommodity? PutEmployerEWCommodity
        {
            get => _putEmployerEWCommodity;
            set
            {
                SetValue(ref _putEmployerEWCommodity, value);
            }
        }
        public PutEmployerEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerEWCommodity EmployerEWCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerEWCommodity>(EmployerEWCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerEWCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerEWCommodity = new();
            _putEmployerEWCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerEWCommodityViewModel : BaseEmployerEWCommodityViewModel
    {
        public DeleteEmployerEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerEWCommodity>(id);
        }
        public void Reset()
        {
            EmployerEWCommodity = new();
        }
    }
    public class GetsEmployerEWCommodityViewModel : BaseEmployerEWCommodityViewModel
    {
        private List<EmployerEWCommodity> _EmployerEWCommoditys = new();
        public List<EmployerEWCommodity> EmployerEWCommoditys
        {
            get=> _EmployerEWCommoditys;
            set
            {
                SetValue(ref _EmployerEWCommoditys, value);   
            }
        }
        public GetsEmployerEWCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerEWCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerEWCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerEWCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerEWCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerEWCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerEWCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerEWCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
