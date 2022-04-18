namespace BusinessView.ofUser
{
    public class UserActor : Actor
    {
        public UserActor()
        {
            OnServiceBuilder(ServiceBuilder);
            OnStrorageBuilder(StorageBuilder);
            OnValidatorBuilder(ValidatorBuilder);
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
    }
}
