﻿using BusinessView.ofCommon.ofServices.ofGroupOrder.ofPlatform;
using BusinessView.ofCommon.ofServices.ofJournal.ofPlatform;
using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofUser.ofCommon;

namespace BusinessView.ofUser.ofPlatform
{
    public class PlatformOrderer : PlatformActor
    {
        public PlatformOrderer()
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(PlatformWarehouse), new PlatformWarehouseService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformWCommodity), new PlatformWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformSWCommodity), new PlatformSWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMWCommodity), new PlatformMWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformEWCommodity), new PlatformEWCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformDividedTag), new PlatformDividedTagService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformDotBarcode), new PlatformDotBarcodeService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformIncomingTag), new PlatformIncomingTagService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformLoadFrame), new PlatformLoadFrameService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(PlatformGOC), new PlatformGOCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformGOCC), new PlatformGOCCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformSGOC), new PlatformSGOCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMGOC), new PlatformMGOCService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformEGOC), new PlatformEGOCService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(PlatformTradeCenter), new PlatformTradeCenterService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformTCommodity), new PlatformTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformSTCommodity), new PlatformSTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMTCommodity), new PlatformMTCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformETCommodity), new PlatformETCommodityService(e => e.IsDevelopment = true));

            serviceBuilder.Add(nameof(PlatformOrderCenter), new PlatformOrderCenterService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformOCommodity), new PlatformOCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformSOCommodity), new PlatformSOCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformMOCommodity), new PlatformMOCommodityService(e => e.IsDevelopment = true));
            serviceBuilder.Add(nameof(PlatformEOCommodity), new PlatformEOCommodityService(e => e.IsDevelopment = true));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
