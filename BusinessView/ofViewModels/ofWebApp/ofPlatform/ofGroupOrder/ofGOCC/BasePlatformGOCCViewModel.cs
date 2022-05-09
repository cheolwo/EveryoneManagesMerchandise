using BusinessView.ofCommon.ofUser;
using BusinessView.ofViewModels.ofGeneric.ofCommon;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;

namespace BusinessView.ofViewModels.ofWebApp.ofPlatform.ofGroupOrder
{
    public class BasePlatformGOCCViewModel : BaseCommodityViewModel<PlatformGOCC>
    {
        public BasePlatformGOCCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {
        }
    }
    public class PlatformPostGOCCViewModel : CommodityPostViewModel<PlatformGOCC>
    {
        public PlatformPostGOCCViewModel(PlatformActorContext PlatformActorContext)
            : base(PlatformActorContext)
        {

        }
    }
    public class PlatformPutGOCCViewModel : CommodityPutViewModel<PlatformGOCC>
    {
        public PlatformPutGOCCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformDeleteGOCCViewModel : CommodityDeleteViewModel<PlatformGOCC>
    {
        public PlatformDeleteGOCCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
    public class PlatformGetsGOCCViewModel : CommodityGetsViewModel<PlatformGOCC>
    {
        public PlatformGetsGOCCViewModel(PlatformActorContext PlatformActorContext)
            :base(PlatformActorContext)
        {

        }
    }
}
