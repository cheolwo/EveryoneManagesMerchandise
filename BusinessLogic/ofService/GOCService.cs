using BusinessData.ofProduct;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGroupOrder;
using BusinessLogic.ofManager.ofOrder;

namespace BusinessLogic.ofService.ofOrderer
{
    // 서비스단의 경우 Management 를 DI 하는 쪽으로 만드는 게 바람직하지.
    // Management가 Manager 모듈을 DI 하는 쪽으로 만들고.
    // 결국에는 RCL 에서 Parameter 로 받는 개체가 Service 개체이기 때문에
    // 이를 고려해서 Service 개체를 설계해야되
    // Service 개체에 대해 Override 로 하여 기능이 이용될 수 있도록 만들어야 해.
    
    // 서비스로 넘기면 어떠한 RCL 페이지에서 이용하든 일단 어떠한 Management 모듈을 이용하는지에 대해
    // 밝힐 필요가 있지.
    // (1) 개체형식을 통해 이용할 Management 모듈을 특정하는 단계
    // 검색, 생성, 수정, 삭제
    /*
        검색의 경우 
    */
    // (2) 
    // Service 개체의 경우 직접적으로 서비스하는 게 아니라 공통적인 형식을 제공하는 의미가 강하지.
    // IRelationable 로 하면 Management 로 구분하는 게 아니라 어떠한 DbCotnext 영역에 속하는 지의 여부에 따라
    // 구분이 이루어질 수 있네.
    public enum ServciePurpose {Get, Create, Update, Delete}
    public interface IService
    {
        int ServiceTypeChekc(IRelationable relationable, ServciePurpose purpose);
    }

    // 단순히 여기 부분을 OrderManagement 이렇게 할 게 아니라 특성을 부여해서 어떠한
    // DataContext 에 속하는 영역인지로 구분을 할 수 있겠다.
    // 일단은 ViewModel 신경쓰지말고 Model 에 대한 코드를 만들 수 있도록 하자.

    // 생산가능품목의 확인
    // 계약품 관리
    // 주문품 관리
    // 내가 봤을 때 서비스 개체의 반환형은 Json 양식으로 통일시키는 게 바람직해보인다.
    // 그래야 이후에 모바일로 확장할 떄 간편히 할 수 있으니까.
    
    public class OrdererService : IService
    {   
        private readonly OrderManagement _orderManagement;  // 주문은 출고와 관련이 있다.
        private readonly ContractManagement _contractManagement; // 계약은 입고와 관련이 있다.
        private readonly JournalManagement _journalManagement; // 회계는 주문 및 계약과 관련이 있다.
        public OrdererService(OrderManagement orderManagement)
        {
            _orderManagement = orderManagement;
        }
        
    }
    public class GOCService
    {
        private readonly IStatusManager<SPCommodity> _SPCommodityManager;
        private readonly IOrderCenterManager _OrderCenterManager;
        private readonly IGroupOrderCenterManager _GroupOrderCenterManager;
        public GOCService(IStatusManager<SPCommodity> sPCommodityManager, IOrderCenterManager orderCenterManager, IGroupOrderCenterManager groupOrderCenterManager)
        {
            _SPCommodityManager = sPCommodityManager;
            _OrderCenterManager = orderCenterManager;
            _GroupOrderCenterManager = groupOrderCenterManager;
        }
    }
}