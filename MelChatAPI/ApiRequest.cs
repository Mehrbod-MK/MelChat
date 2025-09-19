using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MelChatAPI
{
    public abstract class ApiRequest(string sessionId, string requestId, ApiRequestTypes requestType)
    {
        public string SessionId { get; protected set; } = sessionId;
        public string RequestId { get; protected set; } = requestId;
        public ApiRequestTypes RequestType { get; protected set; } = requestType;

        public async Task SendRequest(Stream stream, CancellationToken cancellationToken)
        {
            string apiRequestJson = JsonSerializer.Serialize(this);
            byte[] dataToSend = Encoding.UTF8.GetBytes(Convert.ToBase64String(Encoding.UTF8.GetBytes(apiRequestJson)));
            byte[] lengthBytes = BitConverter.GetBytes((long)dataToSend.Length);

            // Write packet length.
            await stream.WriteAsync(lengthBytes, cancellationToken);

            // Write packet data.
            await stream.WriteAsync(dataToSend, cancellationToken);
        }

        private bool ValidateClientCertificate(object sender, X509Certificate? certificate, X509Chain? chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
