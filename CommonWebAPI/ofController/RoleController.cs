namespace CommonWebAPIServer.ofController;

/*
[ApiController]는 웹 API를 쉽게 빌드할 수 있는 독특한 동작을 사용합니다. 
이러한 동작에는 매개 변수 소스 추론, 요구 사항으로 특성 라우팅, 모델 유효성 검사 오류 처리 기능 향상이 포함됩니다.
*/
[ApiController]
[Route("[controller]")]
public class PayRoleController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    public PayRoleController()
    {

    }
}