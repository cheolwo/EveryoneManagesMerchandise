using System;
using System.Collections;
using System.Collections.Generic;

namespace BusinessData
{
    public class Commodity : Entity, IRelatedCenter, IEnumerable<Commodity>
    {
        public string HsCode {get; set;}
        [Detail]public string Barcode {get; set;}
        public string CenterId {get; set;}
        [One][Get]public Center Center { get; set; }
        [Many][Get]public List<EStatus> EStatuses { get; set; }
        [Many][Get]public List<MStatus> MStatuses { get; set; }
        [Many][Get]public List<SStatus> SStatuses { get; set; } 
        public override bool Equals(object obj)
        {
            return base.Equals(obj) && obj is Commodity commodity &&
                   Name == commodity.Name &&
                   Barcode == commodity.Barcode;
        }

        public IEnumerator<Commodity> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name, Barcode);
        }

        public virtual Center GetRelatedCenter()
        {
            return Center;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
