using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelChatAPI
{
    public abstract class ApiResponse
    {
        public ApiResponseTypes ResponseType { get; protected set; } = ApiResponseTypes.Unknown;
        public abstract ApiResponseTypes GetResponseType();
    }
}
