using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessView.ofUser.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofForwarder
{
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderGOC : GOCDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderGOCC : EGOCDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderSGOC : SGOCDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderMGOC : MGOCDTO
    {
    }
    [ActorContext(typeof(ForwarderContext))]
    public class ForwarderEGOC : EGOCDTO
    {
    }
}
