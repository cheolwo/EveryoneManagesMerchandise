using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class BasePlatformDotBarcodeViewModel : BaseEntityViewModel<PlatformDotBarcode>
    {
        public BasePlatformDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostDotBarcodeViewModel : EntityPostViewModel<PlatformDotBarcode>
    {
        public PlatformPostDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutDotBarcodeViewModel : EntityPutViewModel<PlatformDotBarcode>
    {
        public PlatformPutDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteDotBarcodeViewModel : EntityDeleteViewModel<PlatformDotBarcode>
    {
        public PlatformDeleteDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsDotBarcodeViewModel : EntityGetsViewModel<PlatformDotBarcode>
    {
        public PlatformGetsDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
