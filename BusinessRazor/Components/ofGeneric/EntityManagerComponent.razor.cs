using BusinessView.ofViewModels.ofGeneric.ofPage;
// EntityPageComponent 의 역할
// 1. EntityPageViewModel 의 초기화 - PropertyChanged 설정 및 Component Routing 설정

namespace BusinessRazor.Components.ofGeneric
{
    public partial class EntityManagerComponent<TEntity> : ComponentBase where TEntity : EntityDTO, new() 
    {
        [Parameter] public EntityPageViewModel<TEntity> _EntityPageViewModel {get; set;}
        
        protected override async Task OnInitializedAsync()
        {
            
        }
    }
}