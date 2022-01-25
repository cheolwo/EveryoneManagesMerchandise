using BusinessData;
using BusinessData.ofAccount.ofModel;
using BusinessData.ofCommon.ofInterface;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Components;

namespace PlatformManager.ofComponent.ofGeneric
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
        public async Task OnParametersSetAsync()
        {
        }
        public async Task OnInitializedAsync()
        {
            foreach(var Center in Entities)
            {
                TCenter center = new();
                center = await _CenterManager._centerDataRepository.GetByCenterWithStatus(Center);
                Centers.Add(center);
            }
        }
            
    }
}