using BusinessData;
using BusinessRazor.ofGeneric;
using Microsoft.AspNetCore.Components;
using System.Reflection;

namespace PlatformManager.Pages.ofGeneric
{
    public class EntityUpdateComponent<TEntity> : ComponentBase where TEntity : Entity, IRelationable, new()
    {
        [Parameter] public EventCallback<TEntity> EventUpdate {get; set;}
        [Parameter] public EventCallback EventCancel {get; set;}
        [Parameter] public TEntity ?Entity {get; set;}
        [Parameter] public bool IsOpen {get; set;}
        [Parameter] public TableViewMode ViewMode {get; set;}
        [CascadingParameter] public EntityTableComponent<TEntity> ?EntityTableComponent {get; set;}
        private List<PropertyInfo> OneValues = new();
        private List<PropertyInfo> ManyValues = new();
        protected override async Task OnParametersSetAsync()
        {
            if(EntityTableComponent != null)
            {
                var TableViewMode = EntityTableComponent.TableViewMode;
                OneValues = EntityTableComponent.EntitySingleObject;
                ManyValues = EntityTableComponent.EntityMultifleObject;
            }
        }
        protected override async Task OnInitializedAsync()
        {
            
        }
        public void Update()
        {
            // 모델 적합성 검사를 한 번 해 줄 필요가 있어.
           EventUpdate.InvokeAsync(Entity);
        }
        public void Cancel()
        {
            EventCancel.InvokeAsync();
        }
    }
}