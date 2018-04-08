using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace HTTP
{
    public class Connection
    {
        public IPEndPoint HostEndPoint { get; private set; }

        public Connection(string hostName, int port)
        {
            var hostEntry = Dns.GetHostEntry(hostName);
            var hostAddress = hostEntry.AddressList.First();
            HostEndPoint = new IPEndPoint(hostAddress, port);
        }

        public Response ExecuteRequest(Request request)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(HostEndPoint);

            var requestString = request.ToString();
            var sendRequest = socket.Send(Encoding.UTF8.GetBytes(requestString));

            var buffer = new byte[socket.ReceiveBufferSize];
            var receiveResponse = socket.Receive(buffer);

            socket.Close();

            var responseText = Encoding.UTF8.GetString(buffer);
            return new Response(responseText);
        }
    }
}
