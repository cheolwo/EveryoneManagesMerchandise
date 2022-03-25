// 사용자 등록을 하면
// Seed가 주입되도록 해서 기능을 이용할 수 있도록 만들자.
// 역할에 등록이 될 때마다 사용자 등록이 가능해지도록 만드는 게 바람직하겠다.
namespace BusinessData.ofAccount.ofModel
{
    [DataContext(typeof(BusinessUserDbContext), DbConnectionString.BusinessUserDbConnection)]
    [Relation(typeof(PayService), nameof(PayService))]
    public class PayService : Entity
    {
        public string DetailServiceName { get; set; } // TCommodity, SCommodity... 등등
        public BusinessUser BusinessUser { get; set; }
    }
    // public class PopBillInfo
    // {
    //     public string PopBillId { get; set; }
    //     public string Password { get; set; }
    //     public string LinkId { get; set; }
    //     public string SecreatKey { get; set; }
    // }
}
