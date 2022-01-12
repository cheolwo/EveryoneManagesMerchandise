using BusinessData;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRazor.ofCommon
{
    // 개발자가 StateHasChanged를 호출하면 렌더러가 생성됩니다.
    // EventCallBack 은 내제적으로 StateHashChanged 를 포함합니다.
    // 그래서 따로 StateHasChanged를 호출할 필요가 없습니다.
    public class FormofCenterLogin
    {
        public string Id {get; set;}
        public string CenterLoginId {get; set;}
        public string CenterPassword {get; set;}
        public FormofCenterLogin()
        {
            this.Id = "";
            this.CenterLoginId = "";
            this.CenterPassword = "";
        }
    }
    // Validator를 만드는 것도 나쁘지 않겠는데....
    public partial class CenterLoginComponent : ComponentBase
    {
        [Parameter] public EventCallback<FormofCenterLogin> EventLogin {get; set;}
        [Parameter] public EventCallback Switch {get; set;}
        public FormofCenterLogin formofCenterLogin = new();
        public async Task Login()
        {
            await EventLogin.InvokeAsync(formofCenterLogin);
            await Switch.InvokeAsync();
        }
    } 
}