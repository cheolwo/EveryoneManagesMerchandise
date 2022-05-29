using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofProduct;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductCenter
{
    public class ProductCenterPostViewModel<TCenter> : CenterPostViewModel<TCenter> where TCenter : ProductCenterDTO, new()
    {
        public ProductCenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class ProductCenterPutViewModel<TCenter> : CenterPutViewModel<TCenter> where TCenter : ProductCenterDTO, new()
    {
        public ProductCenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class ProductCenterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter> where TCenter : ProductCenterDTO, new()
    {
        public ProductCenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class ProductCenterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter> where TCenter : ProductCenterDTO, new()
    {
        public ProductCenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}