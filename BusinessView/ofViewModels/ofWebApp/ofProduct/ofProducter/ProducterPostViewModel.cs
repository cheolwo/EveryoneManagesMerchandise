using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;

namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofProducter
{
    public class ProducterPostViewModel<TCenter> : CenterPostViewModel<TCenter> where TCenter : ProducterDTO, new()
    {
        public ProducterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class ProducterPutViewModel<TCenter> : CenterPutViewModel<TCenter> where TCenter : ProducterDTO, new()
    {
        public ProducterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class ProducterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter> where TCenter : ProducterDTO, new()
    {
        public ProducterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class ProducterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter> where TCenter : ProducterDTO, new()
    {
        public ProducterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}