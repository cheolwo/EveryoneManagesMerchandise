using BusinessView.ofViewModels.ofGeneric.ofPage;

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