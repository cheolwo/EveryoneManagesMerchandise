using System.Collections.Generic;
using System;
namespace BusinessData
{
    public class Center : Entity
    {
        [Get] public string LoginId { get; set; }
        [Get] public string Password { get; set; }
        [Get] public int FailLogin {get; set;}
        [Get] public string Address {get; set;}
        [Get] public string CountryCode {get; set;}
        [Detail] public string CardNumber {get; set;}
        [Get] public string Cvv {get; set;}
        [Get] public string CardPassword {get; set;}
        [Get] public string PhoneNumber {get; set;}
        [Get] public string FaxNumber {get; set;}
        [Get][Many] public List<Commodity> Commodities { get; set; }
        [Get][Many] public List<EStatus> EStatuses { get; set; }
        [Get][Many] public List<MStatus> MStatuses { get; set; }
        [Get][Many] public List<SStatus> SStatuses { get; set; }
        [Detail] public List<CenterMacAddress> CenterMacAddresses { get; set; }
        [Detail] public List<CenterIPAddress> CenterIPAddresses { get; set; }
        [Detail] public List<CenterRole> CenterRoles {get; set;}

        public override bool Equals(object obj)
        {
            return base.Equals(obj) && obj is Center center &&
                   Name == center.Name &&
                   UserId == center.UserId &&
                   Barcode == center.Barcode;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name, UserId, Barcode);
        }

        public virtual Center GetRelatedCenter()
        {
            return this;
        }
    }
}
