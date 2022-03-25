using System.Collections.Generic;
using System;
using System.Collections;

namespace BusinessData
{
    public class Center : Entity, IEnumerable<Center>
    {
        public string LoginId { get; set; }
        public string Password { get; set; }
        public int FailLogin { get; set; }
        public string Address { get; set; }
        public string CountryCode { get; set; }
        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public string CardPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public List<Commodity> Commodities { get; set; }
        public List<EStatus> EStatuses { get; set; }
        public List<MStatus> MStatuses { get; set; }
        public List<SStatus> SStatuses { get; set; }
        public List<CenterMacAddress> CenterMacAddresses { get; set; }
        public List<CenterIPAddress> CenterIPAddresses { get; set; }
        public List<CenterRole> CenterRoles { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj) && obj is Center center &&
                   Name == center.Name &&
                   UserId == center.UserId;
        }

        public IEnumerator<Center> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name, UserId);
        }

        public virtual Center GetRelatedCenter()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
