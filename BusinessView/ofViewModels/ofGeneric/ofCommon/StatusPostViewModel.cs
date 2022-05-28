using BusinessView.ofCommon.ofUser;
using BusinessView.ofDTO.ofCommon;

namespace BusinessView.ofViewModels.ofGeneric.ofCommon
{

    public class StatusPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : StatusDTO, new()
    {
        public StatusPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class StatusPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : StatusDTO, new()
    {
        public StatusPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class StatusDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : StatusDTO, new()
    {
        public StatusDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class StatusGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : StatusDTO, new()
    {
        public StatusGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    

    public class SStatusPostViewModel<TStatus> : StatusPostViewModel<TStatus> where TStatus : SStatusDTO, new()
    {
        public SStatusPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SStatusPutViewModel<TStatus> : StatusPutViewModel<TStatus> where TStatus : SStatusDTO, new()
    {
        public SStatusPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class SStatusDeleteViewModel<TStatus> : StatusDeleteViewModel<TStatus> where TStatus : SStatusDTO, new()
    {
        public SStatusDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class SStatusGetsViewModel<TStatus> : StatusGetsViewModel<TStatus> where TStatus : SStatusDTO, new()
    {
        public SStatusGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }


    public class MStatusPostViewModel<TStatus> : StatusPostViewModel<TStatus> where TStatus : MStatusDTO, new()
    {
        public MStatusPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MStatusPutViewModel<TStatus> : StatusPutViewModel<TStatus> where TStatus : MStatusDTO, new()
    {
        public MStatusPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class MStatusDeleteViewModel<TStatus> : StatusDeleteViewModel<TStatus> where TStatus : MStatusDTO, new()
    {
        public MStatusDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class MStatusGetsViewModel<TStatus> : StatusGetsViewModel<TStatus> where TStatus : MStatusDTO, new()
    {
        public MStatusGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }


    public class EStatusPostViewModel<TStatus> : StatusPostViewModel<TStatus> where TStatus : EStatusDTO, new()
    {
        public EStatusPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class EStatusPutViewModel<TStatus> : StatusPutViewModel<TStatus> where TStatus : EStatusDTO, new()
    {
        public EStatusPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class EStatusDeleteViewModel<TStatus> : StatusDeleteViewModel<TStatus> where TStatus : EStatusDTO, new()
    {
        public EStatusDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class EStatusGetsViewModel<TStatus> : StatusGetsViewModel<TStatus> where TStatus : EStatusDTO, new()
    {
        public EStatusGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}