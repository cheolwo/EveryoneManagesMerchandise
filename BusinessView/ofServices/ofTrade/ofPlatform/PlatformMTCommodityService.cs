using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformMTCommodityService : TradeService
    {
        public PlatformMTCommodityService(TradeServiceOptions options)
            : base(options)
        {

        }


    }
}
