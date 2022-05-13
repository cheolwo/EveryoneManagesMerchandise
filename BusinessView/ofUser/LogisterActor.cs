using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser
{
    public class LogisterActor : Actor
    {
        public LogisterActor(ActorOption actorOption)
            :base(actorOption)
        {
        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder)
        {
            Console.WriteLine("It is LogisterActor");
        }

        protected override void OnStrorageBuilder(StorageBuilder storageBuilder)
        {
            Console.WriteLine("It is LogisterActor");
        }

        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilder)
        {
            Console.WriteLine("It is LogisterActor");
        }
    }
}
