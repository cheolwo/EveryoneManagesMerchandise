using BusinessView.ofUser;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofDTO.ofOrder.ofEmployer;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofOrder
{
    public class BaseEmployerMOCommodityViewModel : BaseViewModel
    {
        protected readonly EmployerActorContext _EmployerActorContext;
        protected EmployerMOCommodity? _EmployerMOCommodity = new();
        public EmployerMOCommodity? EmployerMOCommodity
        {
            get => _EmployerMOCommodity;
            set
            {
                SetValue(ref _EmployerMOCommodity, value);
            }
        }
        public BaseEmployerMOCommodityViewModel(EmployerActorContext EmployerActorContext)
        {
            _EmployerActorContext = EmployerActorContext;
        }
        public async Task GetByIdAsync(string id)
        {
            EmployerMOCommodity = await _EmployerActorContext.GetByIdAsync<EmployerMOCommodity>(id);
        }
    }
    public class PostEmployerMOCommodityViewModel : BaseEmployerMOCommodityViewModel
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
        private EmployerMOCommodity? _postEmployerMOCommodity = new();
        public EmployerMOCommodity? PostEmployerMOCommodity
        {
            get => _postEmployerMOCommodity;
            set
            {
                SetValue(ref _postEmployerMOCommodity, value);
            }
        }
        public PostEmployerMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            : base(EmployerActorContext)
        {

        }
        public async Task PostAsync(EmployerMOCommodity EmployerMOCommodity)
        {
            var PostValue = await _EmployerActorContext.PostAsync<EmployerMOCommodity>(EmployerMOCommodity);
            if (PostValue != null)
            {
                PostEmployerMOCommodity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _EmployerMOCommodity = new();
            _postEmployerMOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class PutEmployerMOCommodityViewModel : BaseEmployerMOCommodityViewModel
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
        private EmployerMOCommodity? _putEmployerMOCommodity = new();
        public EmployerMOCommodity? PutEmployerMOCommodity
        {
            get => _putEmployerMOCommodity;
            set
            {
                SetValue(ref _putEmployerMOCommodity, value);
            }
        }
        public PutEmployerMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task PutAsync(EmployerMOCommodity EmployerMOCommodity)
        {
            var PutValue = await _EmployerActorContext.PutAsync<EmployerMOCommodity>(EmployerMOCommodity);
            if(PutValue != null)
            {
                _isPut = true;
                PutEmployerMOCommodity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _EmployerMOCommodity = new();
            _putEmployerMOCommodity = new();
            OnPropertyChanged();
        }
    }
    public class DeleteEmployerMOCommodityViewModel : BaseEmployerMOCommodityViewModel
    {
        public DeleteEmployerMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _EmployerActorContext.DeleteByIdAsync<EmployerMOCommodity>(id);
        }
        public void Reset()
        {
            EmployerMOCommodity = new();
        }
    }
    public class GetsEmployerMOCommodityViewModel : BaseEmployerMOCommodityViewModel
    {
        private List<EmployerMOCommodity> _EmployerMOCommoditys = new();
        public List<EmployerMOCommodity> EmployerMOCommoditys
        {
            get=> _EmployerMOCommoditys;
            set
            {
                SetValue(ref _EmployerMOCommoditys, value);   
            }
        }
        public GetsEmployerMOCommodityViewModel(EmployerActorContext EmployerActorContext)
            :base(EmployerActorContext)
        {

        }
        public async Task GetsAsync()
        {
            IEnumerable<EmployerMOCommodity>? dtos = await _EmployerActorContext.GetsAsync<EmployerMOCommodity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<EmployerMOCommodity>? dtos = await _EmployerActorContext.GetsAsyncByUserId<EmployerMOCommodity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _EmployerMOCommoditys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = EmployerMOCommoditys.Find(e => e.Id.Equals(id));
            if(obj != null) { EmployerMOCommoditys.Remove(obj); OnPropertyChanged(); }
        }
    }
}
