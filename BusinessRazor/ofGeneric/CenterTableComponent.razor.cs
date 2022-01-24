using BusinessData;
using BusinessData.ofCommon.ofInterface;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace BusinessRazor.Pages.ofGeneric
{
    public class CenterTableComponent<TCenter> : EntityTableComponent<TCenter> where TCenter : Center, IRelationable, ITablable, new()
    {
        protected readonly ICenterManager<TCenter> _CenterManager;
        public CenterTableComponent(ICenterManager<TCenter> CenterManager, IEntityManager<BusinessUser> businessUserManager,
                                EntityNavigateFactory<TCenter> EntityrNavigateFactory, NavigationManager navigationManager)
                                :base(CenterManager, businessUserManager, EntityrNavigateFactory, navigationManager)
        {
            _CenterManager = CenterManager;
        }
        protected override async Task OnParameterSetAsync()
        {
            base.OnParameterSetAsync();
        }
        protected override async Task OnInitialziedAsync()
        {
            base.OnInitializedAsync();
            if(Entities != null)
            {
                foreach(var center in Entities)
                {
                    center = await _CenterManager.GetByCenterWithRelated(center);
                }
            }
               
        }
            
    }
}