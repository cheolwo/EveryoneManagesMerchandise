using BusinessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofDTO.ofWarehouseDTO.ofEmployee.ofWarehouse
{
    public class EmployeeWarehouseDTO
    {
        [Get] public string Id { get; set; }
        [Get] public string Code { get; set; }
        [Get] public string Name { get; set; }
        [Detail] public string Container { get; set; }
        [Detail] public DateTime CreateTime { get; set; }
        [Detail] public string UserId { get; set; } // 이 부분은 인덱스로 만들어도 괜찮겠다.
        [Get] public string LoginId { get; set; }
        [Get] public string Password { get; set; }
        [Get] public int FailLogin { get; set; }
        [Get] public string Address { get; set; }
        [Get] public string CountryCode { get; set; }
        [Detail] public string CardNumber { get; set; }
        [Get] public string Cvv { get; set; }
        [Get] public string CardPassword { get; set; }
        [Get] public string PhoneNumber { get; set; }
        [Get] public string FaxNumber { get; set; }
    }
}
