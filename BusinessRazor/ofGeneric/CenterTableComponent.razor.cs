using BusinessData;
using BusinessData.ofAccount.ofModel;
using BusinessData.ofCommon.ofInterface;
using BusinessLogic.ofManager.ofGeneric;
using BusinessRazor.ofGeneric;
using Microsoft.AspNetCore.Components;

namespace BusinessRazor.Pages.ofGeneric
{
    public class CenterTableComponent<TCenter> : EntityTableComponent<TCenter> where TCenter : Center, IRelationable, ITablable, new()
    {
        protected readonly CenterManager<TCenter> _CenterManager;
        public CenterTableComponent(CenterManager<TCenter> CenterManager, EntityManager<BusinessUser> businessUserManager,
                                EntityNavigateFactory<TCenter> EntityrNavigateFactory, NavigationManager navigationManager)
                                :base(CenterManager, businessUserManager, EntityrNavigateFactory, navigationManager)
        {
            _CenterManager = CenterManager;
        }
        public TCenter Center = new();
        public List<TCenter> Centers = new();
        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();
        }
        protected override async Task OnInitializedAsync()
        {
            base.OnInitializedAsync();
            foreach(var Center in Entities)
            {
                TCenter center = new();
                center = await _CenterManager._centerDataRepository.GetByCenterWithStatus(Center);
                Centers.Add(center);
            }
        }
            
    }
}