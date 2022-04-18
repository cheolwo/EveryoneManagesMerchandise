// See https://aka.ms/new-console-template for more information
using BusinessData;
using BusinessData.ofWarehouse.Model;
using FluentValidation;

UserActor actor = new UserActor();
SampleViewModelValidator ValidationRules = new SampleViewModelValidator();

public class SampleViewModelValidator : AbstractValidator<SampleViewModel>
{
    public SampleViewModelValidator()
    {
        RuleFor(x => x.Name).NotNull();
    }
}


public interface IViewModel
{
    
}
public interface IViewService
{
    
}
public interface IViewService<T> where T : IViewModel
{

}
public class SampleViewModel : IViewModel
{
    public string Name { get; set; }
}
public class ViewService
{

}
public class SampleService : ViewService, IViewService<SampleViewModel>
{

}
public interface IServiceTypeBuilder<T> where T : class
{
    
}
public class ServiceBuilder
{

}
public class StorageBuilder
{

}
public class ValidatorBuilder
{

}
public interface IUserActorViewService<T> where T : IViewModel
{
    Task<T> CreateAsync(T t);
    Task<T> UpdateAsync(T t);
    Task<T> GetById(string userid, string id);
    Task<IEnumerable<T>> GetAllAsync(string userid);
}
public class Actor
{
    protected ServiceBuilder ServiceBuilder = new();
    protected StorageBuilder StorageBuilder = new();
    protected ValidatorBuilder ValidatorBuilder = new();
    public Actor()
    {
        OnServiceBuilder(ServiceBuilder);
        OnStrorageBuilder(StorageBuilder);
        OnValidatorBuilder(ValidatorBuilder);
    }
    protected virtual void OnServiceBuilder(ServiceBuilder serviceBuilder) { }
    protected virtual void OnStrorageBuilder(StorageBuilder storageBuilder) { }
    protected virtual void OnValidatorBuilder(ValidatorBuilder validatorBuilde) { }
    public virtual Task<T> CreateAsync<T>(T t) where T : IViewModel { throw new NotImplementedException(); }
    public virtual Task<T> UpdateAsync<T>(T t) where T : IViewModel { throw new NotImplementedException(); }
    public virtual Task<T> GetById<T>(string userId, string id) where T : IViewModel { throw new NotImplementedException(); }
    public virtual Task<IEnumerable<T>> GetAlls<T>(string userId) where T : IViewModel { throw new NotImplementedException(); }
}
public class UserActor : Actor
{
    public UserActor()
    {
    }
    protected override void OnServiceBuilder(ServiceBuilder serviceBuilder)
    {
        Console.WriteLine("It is UserActor");
    }

    protected override void OnStrorageBuilder(StorageBuilder storageBuilder)
    {
        Console.WriteLine("It is UserActor");
    }

    protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilder)
    {
        Console.WriteLine("It is UserActor");
    }

    //public  async Task CreateAsync<T>(T t) where T : IViewModel
    //{
    //    foreach(var vc in ViewServices)
    //    {
    //        if(vc as IViewService<T> is not null)
    //        {
    //            IViewService<T> viewService = vc as IViewService<T>;

    //        }
    //    }
    //}
}

