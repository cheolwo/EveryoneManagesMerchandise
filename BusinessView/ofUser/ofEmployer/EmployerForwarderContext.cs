﻿using BusinessView.ofActorService;
using BusinessView.ofCommon.ofServices.ofJournal.ofEmployer;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofUser.ofCommon;
using Microsoft.Extensions.Options;

namespace BusinessView.ofUser.ofEmployer
{
    public class EmployerForwarderContext : EmployerActorContext
    {
        public EmployerForwarderContext(ActorServiceOption options)
            :base(options)
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(EmployerWarehouse), new EmployerWarehouseService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerWCommodity), new EmployerWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerSWCommodity), new EmployerSWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerMWCommodity), new EmployerMWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerEWCommodity), new EmployerEWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerDividedTag), new EmployerDividedTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerDotBarcode), new EmployerDotBarcodeService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerIncomingTag), new EmployerIncomingTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerLoadFrame), new EmployerLoadFrameService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerWorkingDesk), new EmployerWorkingDeskService(_options.WarehouseServiceOptions));

            serviceBuilder.Add(nameof(EmployerTradeCenter), new EmployerTradeCenterService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployerTCommodity), new EmployerTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployerSTCommodity), new EmployerSTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployerMTCommodity), new EmployerMTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployerETCommodity), new EmployerETCommodityService(_options.TradeServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
