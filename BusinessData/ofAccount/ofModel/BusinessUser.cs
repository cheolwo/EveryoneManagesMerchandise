using BusinessData.ofCommon.ofInterface;
using System;
using System.Collections.Generic;
using System.Reflection;

// 사용자 등록을 하면
// Seed가 주입되도록 해서 기능을 이용할 수 있도록 만들자.
// 역할에 등록이 될 때마다 사용자 등록이 가능해지도록 만드는 게 바람직하겠다.
namespace BusinessData.ofAccount.ofModel
{
    // IdentityDataBase
    [DataContext(typeof(BusinessUserDbContext), DbConnectionString.BusinessUserDbConnection)]
    [Relation(typeof(BusinessUser), nameof(BusinessUser))]
    public class BusinessUser : Entity
    {
        //Name 의 경우 대표자성명
        public string StartDate { get; set; }
        public string BusinessName { get; set; }
        public string BusinessSector { get; set; }
        public string BusinssType { get; set; }
        public string RegisterNumber { get; set; }
        public string Email { get; set; }
        public string CoutryCode {get; set;}    // 바코드 국가코드
        public string LogisticsCode {get; set;} // 바코드 업체코드
        public List<JournalSetting> JournalSettings { get; set; }
        public List<PayService> PayServices { get; set; }
        public List<TableSetting> TableSettings { get; set; }

    }
    // public class PopBillInfo
    // {
    //     public string PopBillId { get; set; }
    //     public string Password { get; set; }
    //     public string LinkId { get; set; }
    //     public string SecreatKey { get; set; }
    // }
}
