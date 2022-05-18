using System.ComponentModel;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using BusinessView.ofCommon.ofInterface;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric
{
    public interface IPropManager
    {
        // List<PropertyInfo> OnlyGetProperties();
        // List<PropertyInfo> OnlyDetailProperties();
        // List<PropertyInfo> GetOneProperties();
        // List<PropertyInfo> GetManyProperties();
        // List<PropertyInfo> DetailOneProperties();
        // List<PropertyInfo> DetailManyProperties();
    }
    public enum ViewMode {Get, Detail}
    public static class EntityPropManager<TEntity> where TEntity : EntityDTO
    {   
        public static IEnumerable<string> GetStringProperties(ViewMode viewmode)
        {
            throw new NotImplementedException();
        }
        public static IEnumerable<string> GetIntProperties(ViewMode viewmode)
        {
            throw new NotImplementedException();
        }
        public static IEnumerable<string> GetDateTimeProperties(ViewMode viewmode)
        {
            throw new NotImplementedException();
        }
    }
    public class EntityPageViewModel<TEntity> : BaseViewModel where TEntity : EntityDTO, new()
    {
        public EntityPostViewModel<TEntity> _EntityPostViewModel;
        public EntityPutViewModel<TEntity> _EntityPutViewModel;
        public EntityDeleteViewModel<TEntity> _EntityDeleteViewModel;
        public EntityGetsViewModel<TEntity> _EntityGetsViewModel;
        public EntityPageViewModel(EntityPostViewModel<TEntity> EntityPostViewModel, EntityPutViewModel<TEntity> EntityPutViewModel,
                                            EntityDeleteViewModel<TEntity> EntityDeleteViewModel, EntityGetsViewModel<TEntity> EntityGetViewModel)
        {
            _EntityPostViewModel = EntityPostViewModel;
            _EntityPutViewModel =  EntityPutViewModel;
            _EntityDeleteViewModel = EntityDeleteViewModel;
            _EntityGetsViewModel = EntityGetViewModel;
        }
        public virtual void OnInitialized(PropertyChangedEventHandler propertyChangedEventHandler)
        {
               PropertyChanged += propertyChangedEventHandler;
             _EntityDeleteViewModel.PropertyChanged += propertyChangedEventHandler;
             _EntityPostViewModel.PropertyChanged += propertyChangedEventHandler;
             _EntityPutViewModel.PropertyChanged += propertyChangedEventHandler;
             _EntityGetsViewModel.PropertyChanged += propertyChangedEventHandler;

            _EntityPostViewModel.postPageToGets = OnClickDeleteToGets;
            _EntityPutViewModel.putPageToGets = OnClickPutToGets;
            _EntityDeleteViewModel.deletePageToGets = OnClickDeleteToGets;
            _EntityGetsViewModel.getsPageToPost = OnClickGetsToPost;
            _EntityGetsViewModel.getsPageToPut = OnClickGetsToPut;
            _EntityGetsViewModel.getsPageToDelete = OnClickGetsToDelete;
        }
        private bool isSelectPost {get; set;}
        public bool IsSelectPost
        {
            get => isSelectPost;
            set
            {
                isSelectPost = value;
                OnPropertyChanged();
            }
            
        }
        private bool isSelectPut {get; set;}
        public bool IsSelectPut
        {
            get => isSelectPut;
            set
            {
                isSelectPut = value;
                OnPropertyChanged();
            }
        }
        private bool isSelectDelete {get; set;}
        public bool IsSelectDelete
        {
            get => isSelectDelete;
            set
            {
                isSelectDelete = value;
                OnPropertyChanged();
            }
        }
        private bool isSelectGets {get; set;}
        public bool IsSelectGets
        {
            get => isSelectGets;
            set
            {
                isSelectGets = value;
                OnPropertyChanged();
            }
        }
        private bool isSelectDetail { get; set; }
        public bool IsSelectDatail
        {
            get => isSelectDetail;
            set
            {
                isSelectDetail = value;
                OnPropertyChanged();
            }
        }
        public async Task OnClickGetsToDetail(string id)
        {
            isSelectGets = false;
            isSelectDetail = true;
            await _EntityPostViewModel.GetByIdAsync(id);
        }
        public async Task OnClickGetsToPost(string id)
        {
            isSelectGets = false;
            isSelectPost = true;
            await _EntityPostViewModel.GetByIdAsync(id);
        }
        public async Task OnClickGetsToPut(string id)
        {
            isSelectGets = false;
            isSelectPut = true;
            await _EntityPostViewModel.GetByIdAsync(id);
        }
        public async Task OnClickGetsToDelete(string id)
        {
            isSelectGets = false;
            isSelectDelete = true;
            await _EntityPostViewModel.GetByIdAsync(id);
        }
        public void OnClickPostToGets()
        {
            isSelectGets = true;
            isSelectPost = false;
            OnPropertyChanged();
        }
        public void OnClickPutToGets()
        {
            isSelectGets = true;
            isSelectPut = false;
            OnPropertyChanged();
        }
        public void OnClickDeleteToGets()
        {
            isSelectGets = true;
            isSelectDelete = false;
            OnPropertyChanged();
        }
    }
    public class CenterPageViewModel<TCenter> : EntityPageViewModel<TCenter> where TCenter : EntityDTO, new()
    {
        private readonly ICenterPageRoadAddressService _CenterPageRoadAddressService;
        private readonly ICenterPageTaxService _CenterPageTaxService;
        private readonly ICenterPageIdentityRoleService _CenterPageIdentityRoleService;
        public CenterPageViewModel(ICenterPageRoadAddressService centerPageRoadAddressService,
                                        ICenterPageTaxService centerPageTaxService,
                                        ICenterPageIdentityRoleService centerPageIdentityRoleService,
            CenterPostViewModel<TCenter> CenterPostViewModel, 
            CenterPutViewModel<TCenter> CenterPutViewModel,
            CenterDeleteViewModel<TCenter> CenterDeleteViewModel, 
            CenterGetsViewModel<TCenter> CenterGetViewModel)
                                            :base(CenterPostViewModel, CenterPutViewModel, CenterDeleteViewModel, CenterGetViewModel)
        {
            _CenterPageIdentityRoleService = centerPageIdentityRoleService;
            _CenterPageTaxService = centerPageTaxService;
            _CenterPageRoadAddressService = centerPageRoadAddressService;
        }
    }
    public class CommodityPageViewModel<TCommodity> : EntityPageViewModel<TCommodity> where TCommodity : EntityDTO, new()
    {
        public CommodityPageViewModel(
            CommodityPostViewModel<TCommodity> CommodityPostViewModel, 
            CommodityPutViewModel<TCommodity> CommodityPutViewModel,
            CommodityDeleteViewModel<TCommodity> CommodityDeleteViewModel, 
            CommodityGetsViewModel<TCommodity> CommodityGetViewModel)
                                            :base(CommodityPostViewModel, CommodityPutViewModel, CommodityDeleteViewModel, CommodityGetViewModel)
        {
        }
    }
    public class StatusPageViewModel<TStatus> : EntityPageViewModel<TStatus> where TStatus : EntityDTO, new()
    {
        public StatusPageViewModel(
            StatusPostViewModel<TStatus> StatusPostViewModel, 
            StatusPutViewModel<TStatus> StatusPutViewModel,
            StatusDeleteViewModel<TStatus> StatusDeleteViewModel, 
            StatusGetsViewModel<TStatus> StatusGetViewModel)
                                            :base(StatusPostViewModel, StatusPutViewModel, StatusDeleteViewModel, StatusGetViewModel)
        {
        }
    }
}