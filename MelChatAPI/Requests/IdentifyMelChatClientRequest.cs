using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelChatAPI.Requests
{
    public class IdentifyMelChatClientRequest : ApiRequest
    {
        public IdentifyMelChatClientRequest(string sessionId, string requestId)
            : base(sessionId, requestId, ApiRequestTypes.IdentifyMelChatClient)
        {
        }
    }
}
