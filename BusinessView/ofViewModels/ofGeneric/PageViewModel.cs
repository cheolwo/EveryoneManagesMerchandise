using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofUser.ofCommon;
using System.Runtime.CompilerServices;

namespace BusinessView.ofViewModels.ofGeneric
{
    public abstract class BaseEntityViewModel<TEntity> : BaseViewModel where TEntity : new()
    {
        protected readonly ActorContext _ActorContext;
        protected TEntity? _TEntity = new();
        public TEntity? TEntity
        {
            get=>_TEntity;
            set
            {
                SetValue(ref _TEntity, value);
            }
        }
        public BaseEntityViewModel(ActorContext ActorContext)
        {
            _ActorContext = ActorContext;
        }    
        public async Task GetByIdAsync(string id)
        {
            TEntity = await _ActorContext.GetByIdAsync<TEntity>(id);
        }   
    }
    public abstract class PostViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : new()
    {
        public PostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
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
        private TEntity? _postTEntity = new();
        public TEntity? PostTEntity
        {
            get => _postTEntity;
            set
            {
                SetValue(ref _postTEntity, value);
            }
        }
        public async Task PostAsync(TEntity Entity)
        {
            var PostValue = await _ActorContext.PostAsync<TEntity>(Entity);
            if (PostValue != null)
            {
                PostTEntity = PostValue;
                IsPost = true;
            }
        }
        public void Reset()
        {
            IsPost = false;
            _TEntity = new();
            _postTEntity = new();
            OnPropertyChanged();
        }
    }
    public abstract class PutViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : new()
    {
         public PutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        private TEntity? _putTEntity = new();
        public TEntity? PutTEntity
        {
            get => _putTEntity;
            set
            {
                SetValue(ref _putTEntity, value);
            }
        }
        public async Task PutAsync(TEntity TEntity)
        {
            var PutValue = await _ActorContext.PutAsync<TEntity>(TEntity);
            if(PutValue != null)
            {
                _isPut = true;
                PutTEntity = PutValue;
            }
        }
        public void Reset()
        {
            _isPut = false;
            _TEntity = new();
            _putTEntity = new();
            OnPropertyChanged();
        }
    }
    public abstract class DeleteViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : new()
    {
         public DeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _ActorContext.DeleteByIdAsync<TEntity>(id);
        }
        public void Reset()
        {
            TEntity = new();
        }
    }
    public abstract class GetsViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : new()
    {
         public GetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        private List<TEntity> _TEntitys = new();
        public List<TEntity> TEntitys
        {
            get=> _TEntitys;
            set
            {
                SetValue(ref _TEntitys, value);   
            }
        }
        public async Task GetsAsync()
        {
            IEnumerable<TEntity>? dtos = await _ActorContext.GetsAsync<TEntity>();
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _TEntitys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<TEntity>? dtos = await _ActorContext.GetsAsyncByUserId<TEntity>(userid);
            if(dtos != null)
            {
                foreach(var dto in dtos)
                {
                    _TEntitys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void Delte(string id)
        {
            var obj = TEntitys.Find(e => e.Id.Equals(id));
            if(obj != null) { TEntitys.Remove(obj); OnPropertyChanged(); }
        }
    }
    public abstract class PaegViewModel<TEntity> : BaseViewModel where TEntity : new()
    {
        private readonly PostViewModel<TEntity> _PostViewModel;
        private readonly GetsViewModel<TEntity> _GetsViewModel;
        private readonly PutViewModel<TEntity> _PutViewModel;
        private readonly DeleteViewModel<TEntity> _DeleteViewModel;  
        public PaegViewModel(PostViewModel<TEntity> postViewModel, PutViewModel<TEntity> putViewModel, DeleteViewModel<TEntity> deleteViewModel, GetsViewModel<TEntity> getsViewModel)
        {
            _PostViewModel = postViewModel;
            _GetsViewModel = getsViewModel;
            _PutViewModel = putViewModel;
            _DeleteViewModel = deleteViewModel;
        }
        public void SetPropertyChangedEventHandler(PropertyChangedEventHandler propertyChanged)
        {
            _PostViewModel.PropertyChanged = propertyChanged;
            _GetsViewModel.PropertyChanged = propertyChanged;
            _PutViewModel.PropertyChanged = propertyChanged;
            _DeleteViewModel.PropertyChanged = propertyChanged;
            PropertyChanged = propertyChanged;
        }
        public PostViewModel<TEntity> PosetViewModel {get=>_PostViewModel;}
        public GetsViewModel<TEntity> GetsViewModel {get => _GetsViewModel;}
        public PutViewModel<TEntity> PutViewModel {get => _PutViewModel;}
        public DeleteViewModel<TEntity> DeleteViewModel {get => _DeleteViewModel;}
    }
}