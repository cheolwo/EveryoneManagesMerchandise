using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofProduct.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofProduct
{
    public class BaseEmployerMPCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerMPCommodity? _EmployerMPCommodity = new();
        public EmployerMPCommodity? EmployerMPCommodity
        {
            get => _EmployerMPCommodity;
            set
            {
                SetValue(ref _EmployerMPCommodity, value);
            }
        }
        public BaseEmployerMPCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerMPCommodity = await _EmployerActorContext.GetByIdAsync<EmployerMPCommodity>(id);
        }
    }
    public class PostEmployerMPCommodityViewModel : BaseEmployerMPCommodityViewModel
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
        private EmployerMPCommodity? _postEmployerMPCommodity = new();
        public EmployerMPCommodity? PostEmployerMPCommodity
        {
            get => _postEmployerMPCommodity;
            set
            {
                SetValue(ref _postEmployerMPCommodity, value);
            }
        }
        public PostEmployerMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerMPCommodity EmployerMPCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerMPCommodity>(EmployerMPCommodity);
            if (PostValue != null)
            {
                PostEmployerMPCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerMPCommodity = new();
            _postEmployerMPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerMPCommodityViewModel : BaseEmployerMPCommodityViewModel
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
        private EmployerMPCommodity? _putEmployerMPCommodity = new();
        public EmployerMPCommodity? PutEmployerMPCommodity
        {
            get => _putEmployerMPCommodity;
            set
            {
                SetValue(ref _putEmployerMPCommodity, value);
            }
        }
        public PutEmployerMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerMPCommodity EmployerMPCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerMPCommodity>(EmployerMPCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerMPCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerMPCommodity = new();
            _putEmployerMPCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerMPCommodityViewModel : BaseEmployerMPCommodityViewModel
    {
        public DeleteEmployerMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerMPCommodity>(id);
        }
        public void Reset()
        {
            EmployerMPCommodity = new();
        }
    }
    public class GetsEmployerMPCommodityViewModel : BaseEmployerMPCommodityViewModel
    {
        private List<EmployerMPCommodity> _EmployerMPCommoditys = new();
        public List<EmployerMPCommodity> EmployerMPCommoditys
        {
            get=> _EmployerMPCommoditys;
            set
            {
                SetValue(ref _EmployerMPCommoditys, value);   
            }
        }
        public GetsEmployerMPCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerMPCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerMPCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerMPCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerMPCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMPCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerMPCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerMPCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
