using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelChatAPI
{
    public abstract class ApiRequest
    {
        public ApiRequestTypes RequestType { get; protected set; } = ApiRequestTypes.Unknown;
        public abstract ApiRequestTypes GetApiRequestType();
    }
}
