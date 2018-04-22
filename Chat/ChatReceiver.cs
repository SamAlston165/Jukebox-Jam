using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class ChatReceiver : IChatReceiver
    {
        public string ReceiveMessage()
        {
            try
            {
                int port = 22;
                string ip = "159.65.235.100";
                TcpClient client = new TcpClient();
                client.Connect(ip, port);
                // Receive the TcpServer.response.

                NetworkStream stream = client.GetStream();

                // Buffer to store the response bytes.
                Byte[] data = new Byte[256];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                //Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                Console.WriteLine("Received: {0}", responseData);
                return responseData;
            }

            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            return "";
        }
    }
}
