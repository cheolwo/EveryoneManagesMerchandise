using BusinessData.ofCommon.ofInterface;
using System;
using System.Collections.Generic;
using System.Reflection;

// 사용자 등록을 하면
// Seed가 주입되도록 해서 기능을 이용할 수 있도록 만들자.
// 역할에 등록이 될 때마다 사용자 등록이 가능해지도록 만드는 게 바람직하겠다.
namespace BusinessData.ofAccount.ofModel
{
    [DataContext(typeof(BusinessUserDbContext), DbConnectionString.BusinessUserDbConnection)]
    [Relation(typeof(TableSetting), nameof(TableSetting))]
    public class TableSetting : Entity
    {
        public string RelationCode {get; set; }
        public string ManagedMode {get; set;}
        public string ViewMode {get; set;} // 
        public List<string> GetColumnsSelected {get; set;}
        public List<string> DetailColumnsSelected {get; set;}
        public BusinessUser BusinessUser {get; set;}
        public TableSetting()
        {
            GetColumnsSelected = new();
            DetailColumnsSelected = new();
        }
    }
    // public class PopBillInfo
    // {
    //     public string PopBillId { get; set; }
    //     public string Password { get; set; }
    //     public string LinkId { get; set; }
    //     public string SecreatKey { get; set; }
    // }
}
