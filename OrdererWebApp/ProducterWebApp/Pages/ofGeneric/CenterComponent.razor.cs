using Microsoft.AspNetCore.Components;

namespace ProducterWebApp.Pages.ofGeneric
{
    public partial class CenterComponent : ComponentBase
    {
        [CascadingParameter] private UserComponent UserComponent { get; set; }
        protected override void OnAfterRender(bool firstRender)
        {
            if(firstRender)
            {

            }
            else
            {

            }
            base.OnAfterRender(firstRender);
        }
    }
}
