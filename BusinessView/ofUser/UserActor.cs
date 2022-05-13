using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofInterface;
using BusinessView.ofUser.ofViewModel;

namespace BusinessView.ofUser
{
    public class UserActor : Actor, IUserActorViewService<RoleBaseViewModel>
    {
        public UserActor(ActorOption actorOption)
            :base(actorOption)
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
    }
}
