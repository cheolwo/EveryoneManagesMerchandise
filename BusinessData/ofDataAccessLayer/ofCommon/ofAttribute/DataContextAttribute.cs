using System;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofAttribute
{
    public class DataContextAttribute : Attribute
    {
        private Type _T;
        private readonly string _DbConnectionString;

        public DataContextAttribute(Type t, string dbConnectionString)
        {
            _T = t;
            _DbConnectionString = dbConnectionString;
        }
        public Type GetDbContextType()
        {
            return _T;
        }
        public string GetDbConnectionString()
        {
            return _DbConnectionString;
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
