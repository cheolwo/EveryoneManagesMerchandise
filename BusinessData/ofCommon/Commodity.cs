using System;
using System.Collections.Generic;

namespace BusinessData
{
    // CommodityCode 1 : Goods, 2 : Service
    public class Commodity : Entity, IRelatedCenter
    {
        public string HsCode {get; set;}
        [Detail]public string Barcode {get; set;}
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
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name, Barcode);
        }

        public virtual Center GetRelatedCenter()
        {
            return Center;
        }
    }

    // public class Journal : Attribute
    // {
    //     private string Debit {get; set;}
    //     private string Credit {get; set;}

    //     public Journal(string Debit, string Credit)
    //     {
    //         this.Debit = Debit;
    //         this.Credit = Credit;
    //     }
    //     public Journal()
    //     {
            
    //     }
    //     public string GetDebit()
    //     {
    //         return this.Debit;
    //     }
    //     public string GetCredit()
    //     {
    //         return this.Credit;
    //     }
    //     public void SetDebit(string Debit)
    //     {
    //         this.Debit = Debit;
    //     }
    //     public void SetCredit(string Credit)
    //     {
    //         this.Credit = Credit;
    //     }
    // }
}
