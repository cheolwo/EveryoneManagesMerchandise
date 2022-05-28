using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using FluentValidation;

namespace BusinessView.ofValidator.ofCommon.ofPlatform
{
    public class PlatformEntityValidator<TEntity> : EntityDTOValidator<TEntity>, IValidator<TEntity> where TEntity : EntityDTO
    {
        public PlatformEntityValidator()
        {
            
        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TEntity>.CreateWithOptions((TEntity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
    public class PlatformCenterValidator<TEntity> : PlatformEntityValidator<TEntity>, IValidator<TEntity> where TEntity : PlatformCenter
    {
        public PlatformCenterValidator()
        {
            RuleFor(x => x.LoginId)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.Password)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.Address)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.CountryCode)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .Length(1,100);
        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TEntity>.CreateWithOptions((TEntity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
    public class PlatformCommodityValidator<TEntity> : PlatformEntityValidator<TEntity>, IValidator<TEntity> where TEntity : PlatformCommodity
    {
        public PlatformCommodityValidator()
        {
            RuleFor(x => x.HsCode)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.Barcode)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.CenterId)
                .NotEmpty()
                .Length(1,100);
        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TEntity>.CreateWithOptions((TEntity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
    public class PlatformStatusValidator<TEntity> : PlatformEntityValidator<TEntity>, IValidator<TEntity> where TEntity : PlatformStatus
    {
        public PlatformStatusValidator()
        {
            RuleFor(x => x.CommodityId)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.CenterId)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.Quantity)
                .NotEmpty();
        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TEntity>.CreateWithOptions((TEntity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}