namespace BusinessView.ofWarehouse
{
    // 모바일, 데스크탑, Web 에서 이용될 수 있도록 공통코드를 만들기 위해서는
    // WebAPI 를 이용하는 게 지금으로서는 가장 바람직하다.
    // 1. API 경로
    // 2. 어떠한 서버에 접근하는지
    // 3. 어떠한 정보를 다루는지를 통해 API 경로를 결정한다.
    // WebAPI 를 만들 때는 ViewModel과 깊은 관련이 있도록 만들 수 있도록 한다.
    public class UserService
    {
        public HttpClient IdentityClient {get; set;}      
    }
    public class WarehouseManager
    {
        public HttpClient httpClient;
        public WarehouseManager()
        {
            
        }
    }
}