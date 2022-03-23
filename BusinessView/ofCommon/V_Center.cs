using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessView.ofCommon
{
    //public class CustomerValidator : AbstractValidator<Customer>
    //{
    //    public CustomerValidator()
    //    {
    //        RuleFor(x => x.Surname).NotEmpty();
    //        RuleFor(x => x.Forename).NotEmpty().WithMessage("Please specify a first name");
    //        RuleFor(x => x.Discount).NotEqual(0).When(x => x.HasDiscount);
    //        RuleFor(x => x.Address).Length(20, 250);
    //        RuleFor(x => x.Postcode).Must(BeAValidPostcode).WithMessage("Please specify a valid postcode");
    //    }

    //    private bool BeAValidPostcode(string postcode)
    //    {
    //        // custom postcode validating logic goes here
    //    }
    //}

    // 개체 간 부모 자식 관계가 이어져 있다면 분리시켜서 Validation 모듈을 작성할 필요가 없다.
    public class V_CreateCenterValidator : AbstractValidator<V_CreateCenter>
    {
        public V_CreateCenterValidator()
        {
            RuleFor(c=>c.Address).NotEmpty();
            RuleFor(c=>c.PhoneNumber).NotEmpty();
            RuleFor(c=>c.CardNumber).NotEmpty();
        }
    }
    public class V_CreateEntity
    {
        
    }
    
    public class V_CreateCenter
    {
        public string UserId { get; set; }
        public string Container { get; set; }
        public string Name { get; set; }

        public string LoginId { get; set; }
        public string Password { get; set; }

        public string Address { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }

        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public string CardPassword { get; set; }
    }
}
