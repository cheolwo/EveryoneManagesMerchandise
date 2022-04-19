//public interface IActorViewService<T> where T : class
//{
//    Task<T> GetById(string Id);
//    Task<T> Post(T t);
//    Task<T> Delete(string Id);
//    Task<T> Update(T t, string Id);
//}
//public class Customer
//{
//    public void SearchCommodity(SearchOption option) {}
//}
//public class Member : Customer, IActorViewService<MemberOrdrerCommodity>
//{
//    private readonly IOrderWarehouseService _OrderWarehouseService;
//    private readonly IOrderPayServcie _OrderPayService;
//    private readonly IOrderDeliveryService _OrderDeliveryService;
//    private readonly IOrderReviewService _OrderReviewService;
//    private List<File> Files = new();
//    private bool StateofLogin;
//    public Member(IOrderWarehouseService orderWarehouseService, IOrderPayServcie orderPayServcie, 
//    IOrderDeliveryService orderDeliveryService, IOrderReviceService orderRevicwService)
//    {
//        _OrderPayService = orderWarehouseService;
//        _OrderPayService = orderPayServcie;
//        _OrderDeliveryService = orderDeliveryService;
//        _OrderReviewService = orderRevicwService;
//    }
//    public bool IsLogin() {return StateofLogin; }
//    public async Task OrderCommodity(Commodity commodity)
//    {
//        if(IsLogin())
//        {
//            await _OrderPayService.Pay(commodity);
//            await _OrderWarehouseService.Outgoing(commodity);
//        }
//    }
//    public async Task SearchDelivery(string OrderCommodityId) 
//    {
//        if(IsLogin())
//        {
//           await_OrderDeliveryService.SerachbyOrderCommodityId(OrderCommodityId);
//        }
//    }
//    public async void CreateReview(Review review)
//    { 
//        if(IsLogin())
//        {
//            if(Files.Count > 0)
//            {
//                UploadReviewFile(this.Files);
//            }
//            await _OrderReviewService.CreateReview(review);
//        }
//    }
//    public void UploadFile(File file)
//    {
//        if(file != null)
//        {
//            Files.Add(file);
//        }
//    }
//    private void UploadReviewFile(List<File> files)
//    {
//        // Awesome
//    }
//}