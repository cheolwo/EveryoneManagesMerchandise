namespace BusinessView.ofService
{
    // 모바일, 데스크탑, Web 에서 이용될 수 있도록 공통코드를 만들기 위해서는
    // WebAPI 를 이용하는 게 지금으로서는 가장 바람직하다.
    // 1. API 경로
    // 2. 어떠한 서버에 접근하는지
    // 3. 어떠한 정보를 다루는지를 통해 API 경로를 결정한다.
    // WebAPI 를 만들 때는 ViewModel과 깊은 관련이 있도록 만들 수 있도록 한다.

    /*
        UserService
        1. CreateRoute
        (1) 지역을 확인하는 단계
        (2) 대단위 업무를 확인하는 단계 // 주문, 단체주문, 생산, 무역, 창고... 등
        (3) 주관리서버 및 버퍼서버를 구분하는 단계
        (4) ViewModel을 통해 Route 를 생성하는 단계를 포함하는 CreateRoute 메서드
    */
    public class UserService
    {
        public HttpClient IdentityClient {get; set;}
        //public virtual string CreateHttpRequestMessage(ViewModel viewmodel)
        //{
            
        //}
        //private string GetIdentityRegionCode()
        //{
            
        //}
    }
    public class WarehouseService : UserService
    {
        public HttpClient httpClient;
        public WarehouseService()
        {
            
        }
    }
    
}