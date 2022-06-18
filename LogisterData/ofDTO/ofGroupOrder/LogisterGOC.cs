using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofLogister
{
    [ActorContext(typeof(LogisterContext))]
    public class LogisterGOC : GOCDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterGOCC : EGOCDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterSGOC : SGOCDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterMGOC : MGOCDTO
    {
    }
    [ActorContext(typeof(LogisterContext))]
    public class LogisterEGOC : EGOCDTO
    {
    }
}
