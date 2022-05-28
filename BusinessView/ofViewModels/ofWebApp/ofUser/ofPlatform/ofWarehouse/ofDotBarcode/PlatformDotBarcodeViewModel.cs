using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDotBarcode;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofWarehouse
{
    public class PlatformPostDotBarcodeViewModel : DotBarcodePostViewModel<PlatformDotBarcode>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPostDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformPutDotBarcodeViewModel : DotBarcodePutViewModel<PlatformDotBarcode>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformPutDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformDeleteDotBarcodeViewModel : DotBarcodeDeleteViewModel<PlatformDotBarcode>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformDeleteDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
    public class PlatformGetsDotBarcodeViewModel : DotBarcodeGetsViewModel<PlatformDotBarcode>
    {
        private readonly PlatformActorContext _PlatformActorContext;
        public PlatformGetsDotBarcodeViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
            _PlatformActorContext = PlatformActorContext;
        }
    }
}
