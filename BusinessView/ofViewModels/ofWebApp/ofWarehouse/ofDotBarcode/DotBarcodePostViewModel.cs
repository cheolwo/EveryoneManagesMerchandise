using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofWarehouse;
using BusinessView.ofCommon.ofUser;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDotBarcode
{
    public class DotBarcodePostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : DotBarcodeDTO, new()
    {
        public DotBarcodePostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class DotBarcodePutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : DotBarcodeDTO, new()
    {
        public DotBarcodePutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    public class DotBarcodeDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : DotBarcodeDTO, new()
    {
        public DotBarcodeDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
    }
    public class DotBarcodeGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : DotBarcodeDTO, new()
    {
        public DotBarcodeGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
}