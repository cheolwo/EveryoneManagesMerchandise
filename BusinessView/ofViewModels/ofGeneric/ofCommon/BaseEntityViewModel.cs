using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofCommon.ofInterface;
using System.Reflection;
using BusinessView.ofCommon;
using System.Collections;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric.ofCommon
{
    public delegate void PostPageToGets();
    public delegate void PutPageToGets();
    public delegate void DeletePageToGets();
    public delegate Task GetsPageToPost(string id);
    public delegate Task GetsPageToPut(string id);
    public delegate Task GetsPageToDelete(string id);
    public enum ComponentMode { Get, Detail }
    public class BaseEntityViewModel<TEntity> : BaseViewModel where TEntity : EntityDTO, new()
    {
        protected readonly ActorContext _ActorContext;
        protected TEntity? _TEntity = new();
        public TEntity? Entity
        {
            get=>_TEntity;
            set
            {
                SetValue(ref _TEntity, value);
            }
        }
        private ComponentMode _ComponentMode = new();
        public ComponentMode ComponentMode
        {
            get => _ComponentMode;
            set
            {
                _ComponentMode = value;
                OnPropertyChanged();
            }
        }
        public IDictionary<string, PropertyInfo> StringProperty {get; private set;}
        public IDictionary<string, PropertyInfo> IntProperty {get; private set;}
        public IDictionary<string, PropertyInfo> DateTimeProperty {get; private set;}
        public List<PropertyInfo> PropertiesByComponentMode {get; private set;}
        public BaseEntityViewModel(ActorContext ActorContext)
        {
            _ActorContext = ActorContext;
            ComponentMode = ComponentMode.Get;
            PropertiesByComponentMode = PropertyClassification.GetPropertiesByComponentMode(ComponentMode);
            InitializedByComponentMode(ComponentMode);
        }    
        private void InitializedByComponentMode(ComponentMode componentMode)
        {
            if(StringProperty != null) {StringProperty.Clear();}
            if(IntProperty != null) {IntProperty.Clear();}
            if(DateTimeProperty != null) {DateTimeProperty.Clear();}

            StringProperty = PropertyClassification.ClassifyStringProperty(ComponentMode, typeof(TEntity));
            IntProperty = PropertyClassification.ClassifyIntProperty(ComponentMode, typeof(TEntity));
            DateTimeProperty = PropertyClassification.ClassifyDateTimeProperty(ComponentMode, typeof(TEntity));
        }
        public async Task GetByIdAsync(string id)
        {
            Entity = await _ActorContext.GetByIdAsync<TEntity>(id);
        }   
        public void SelectDetailMode()
        {
            ComponentMode = ComponentMode.Detail;
            InitializedByComponentMode(ComponentMode);
        }
        public void SelectGetMode()
        {
            ComponentMode = ComponentMode.Get;
            InitializedByComponentMode(ComponentMode);
        }
    }
    /*
    */
    public class EntityPostViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public PostPageToGets? postPageToGets {get; set;}
        public EntityPostViewModel(ActorContext actorContext)
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
            if(base.Files.Count > 0)
            {
                Entity.BrowserFileToDTO(base.Files);
            }
            var PostValue = await _ActorContext.PostAsync<TEntity>(Entity);
            if (PostValue != null)
            {
                PostTEntity = PostValue;
                IsPost = true;
                Back();
            }
        }
        public void Back()
        {
            Reset();
            if(postPageToGets == null) { throw new ArgumentNullException("PostPageToGets Is Null");}
            postPageToGets();
        }
        public void Reset()
        {
            IsPost = false;
            _TEntity = new();
            _postTEntity = new();
            Files = new();
            OnPropertyChanged();
        }
    }
    public class EntityPutViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public PutPageToGets? putPageToGets {get; set;}
        public EntityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
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
            if(base.Files.Count > 0)
            {
                Entity.BrowserFileToDTO(base.Files);
            }
            var PutValue = await _ActorContext.PutAsync<TEntity>(TEntity);
            if(PutValue != null)
            {
                _isPut = true;
                PutTEntity = PutValue;
                Back();
            }
        }
        public void Back()
        {
            Reset();
            if(putPageToGets == null ) {throw new ArgumentNullException("PutPageToGets == null");}
            putPageToGets();
        }
        public void Reset()
        {
            _isPut = false;
            _TEntity = new();
            _putTEntity = new();
            Files = new();
            OnPropertyChanged();
        }
    }
    public class EntityDeleteViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public DeletePageToGets? deletePageToGets {get; set;}
        public EntityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public async Task DeleteAsync(string id)
        {
            if(base.Files.Count > 0)
            {
                Entity.BrowserFileToDTO(base.Files);
            }
            await _ActorContext.DeleteByIdAsync<TEntity>(id);
            Back();
        }
        public void Back()
        {
            Reset();
            if(deletePageToGets == null) { throw new ArgumentNullException("DeletePageToGets Is Null");}
            deletePageToGets();
        }
        public void Reset()
        {
            Files = new();
            Entity = new();
        }
    }
    public class EntityGetsViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public GetsPageToPost? getsPageToPost {get; set;}
        public GetsPageToPut? getsPageToPut {get; set; }
        public GetsPageToDelete? getsPageToDelete { get; set; }

        public EntityGetsViewModel(ActorContext actorContext)
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
        public async Task GetsPageToPost(string id)
        {
            if(getsPageToPost == null ) {throw new ArgumentNullException("GetsPageToPost Is Null");}
            await getsPageToPost(id);
        }
        public async Task GetsPageToPut(string id)
        {
            if(getsPageToPut == null ) {throw new ArgumentNullException("GetsPageToPut Is Null");}
            await getsPageToPut(id);
        }
        public async Task GetsPageToDelete(string id)
        {
            if(getsPageToDelete == null ) {throw new ArgumentNullException("GetsPageToDelete Is Null");}
            await getsPageToDelete(id);
        }
    }
}