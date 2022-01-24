using BusinessData;
using BusinessRazor.ofGeneric;
using Microsoft.AspNetCore.Components;
using System.Reflection;

namespace PlatformManager.Pages.ofGeneric
{
    // 여기서는 주로 값을 받을 수 있는 모델을 제공해줄 필요가 있어.
    // 사용자 테이블 모드에 따라 결정될 수 있는 부분이야.
    // 매개변수를 넘기면 EntityTable 에서 이를 이용할 수 있도록 만든다.
    // Dialog , Page 구성요소 비슷하고 렌더링에서 좀 달라지는 부분이 있다.
    // Create 및 Cancel 똑같고 View 단만 다르니까.
    public class EntityCreateComponent<TEntity> : ComponentBase where TEntity : Entity, IRelationable, new()
    {
        [Parameter] public EventCallback<TEntity> EventCreate {get; set;}
        [Parameter] public EventCallback EventCancel {get; set;}
        [Parameter] public TEntity ?Entity {get; set;}
        [Parameter] public bool IsOpen {get; set;}
        [Parameter] public TableViewMode ViewMode {get; set;}
        [CascadingParameter] public EntityTableComponent<TEntity> ?EntityTableComponent {get; set;}
        private List<PropertyInfo> EntitySingleObject = new();
        private List<PropertyInfo> EntityMultifleObject = new();
        protected override async Task OnParametersSetAsync()
        {
            if(EntityTableComponent != null)
            {
                var TableViewMode = EntityTableComponent.TableViewMode;
                EntitySingleObject = EntityTableComponent.EntitySingleObject;
                EntityMultifleObject = EntityTableComponent.EntityMultifleObject;
            }
        }
        public void Create()
        {
            // 모델 적합성 검사를 한 번 해 줄 필요가 있어.
           EventCreate.InvokeAsync(Entity);
        }
        public void Cancel()
        {
            EventCancel.InvokeAsync();
        }
    }
}