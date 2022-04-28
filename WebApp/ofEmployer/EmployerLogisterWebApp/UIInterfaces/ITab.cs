using Microsoft.AspNetCore.Components;

namespace EmployerLogisterWebApp.UIInterfaces
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}
