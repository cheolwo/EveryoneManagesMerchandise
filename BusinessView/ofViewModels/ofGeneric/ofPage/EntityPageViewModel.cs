using System.ComponentModel;
using BusinessView.ofServices.ofCommon;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection;
using BusinessView.ofCommon.ofInterface;
using System.Exception;
using System;

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
    public static class EntityPropManager<TEntity> : IPropManager where TEntity : IEntityDTO
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
    public class EntityPageViewModel<TEntity> : BaseViewModel where TEntity : new()
    {
        private EntityPostViewModel<TEntity> _EntityPostViewModel;
        private EntityPutViewModel<TEntity> _EntityPutViewModel;
        private EntityDeleteViewModel<TEntity> _EntityDeleteViewModel;
        private EntityGetsViewModel<TEntity> _EntityGetsViewModel;
        public event PropertyChangedEventHandler? PropertyChanged;
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
            if(propertyChangedEventHandler != null)
            {
                 PropertyChanged += propertyChangedEventHandler;
                _EntityDeleteViewModel += propertyChangedEventHandler;
                _EntityPostViewModel += propertyChangedEventHandler;
                _EntityPutViewModel += propertyChangedEventHandler;
                _EntityGetsViewModel += propertyChangedEventHandler;
            }
            _EntityPostViewModel.PostPageToGets = OnClickDeleteToGets;
            _EntityPutViewModel.PutPageToGets = OnClickPutToGets;
            _EntityDeleteViewModel.DeletePageToGets = OnClickDeleteToGets;
            _EntityGetsViewModel.GetsPageToPost = OnClickGetsToPost;
            _EntityGetsViewModel.GetsPageToPut = OnClickGetsToPut;
            _EntityGetsViewModel.GetsPageToDelete = OnClickGetsToDelete;
        }
        private bool isSelectPost {get; set;}
        public bool isSelectPost
        {
            get => isSelectPost;
            set => SetValue(ref isSelectPost, value);
        }
        private bool isSelectPut {get; set;}
        public bool isSelectPut
        {
            get => isSelectPut;
            set => SetValue(ref isSelectPut, value);
        }
        private bool isSelectDelete {get; set;}
        public bool isSelectDelete
        {
            get => isSelectDelete;
            set => SetValue(ref isSelectDelete, value);
        }
        private bool isSelectGets {get; set;}
        public bool isSelectGets
        {
            get => isSelectGets;
            set => SetValue(ref isSelectGets, value);
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
    public class CenterPageViewModel<TCenter> : EntityPageViewModel<TCenter> where TCenter : new()
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
    public class CommodityPageViewModel<TCommodity> : EntityPageViewModel<TCommodity> where TCommodity : new()
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
    public class StatusPageViewModel<TStatus> : EntityPageViewModel<TStatus> where TStatus : new()
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