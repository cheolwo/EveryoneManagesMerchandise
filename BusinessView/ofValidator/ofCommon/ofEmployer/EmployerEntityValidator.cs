using BusinessView.ofDTO.ofCommon;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using FluentValidation;

namespace BusinessView.ofValidator.ofCommon.ofEmployer
{
    public class EmployerEntityValidator<TEntity> : EntityDTOValidator<TEntity>, IValidator<TEntity> where TEntity : EntityDTO
    {
        public EmployerEntityValidator()
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
    public class EmployerCenterValidator<TEntity> : EmployerEntityValidator<TEntity>, IValidator<TEntity> where TEntity : EmployerCenter
    {
        public EmployerCenterValidator()
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
    public class EmployerCommodityValidator<TEntity> : EmployerEntityValidator<TEntity>, IValidator<TEntity> where TEntity : EmployerCommodity
    {
        public EmployerCommodityValidator()
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
    public class EmployerStatusValidator<TEntity> : EmployerEntityValidator<TEntity>, IValidator<TEntity> where TEntity : EmployerStatus
    {
        public EmployerStatusValidator()
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