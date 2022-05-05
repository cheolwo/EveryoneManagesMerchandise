using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformTradeCenterService : TradeService
    {
        public PlatformTradeCenterService(TradeServiceOptions options)
            : base(options)
        {

        }

    }
}
