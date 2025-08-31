using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MelChatServerCLI.Models
{
    public class MelChatClient
    {
        required public TcpClient tcpClient { get; set; }
    }
}
