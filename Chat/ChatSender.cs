﻿using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class ChatSender : IChatSender
    {
        private IUser user;

        public ChatSender(IUser user)
        {
            this.user = user;
        }

        public void ReceiveMessage()
        {
            // Receive the TcpServer.response.

            // Buffer to store the response bytes.
            //   data = new Byte[256];

            // String to store the response ASCII representation.
            //    String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            //            Int32 bytes = stream.Read(data, 0, data.Length);
            //          responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            //        Console.WriteLine("Received: {0}", responseData);

            throw new NotImplementedException();

        }

        public void SendMessage(string message)
        {
            string fullMessage = user.Username + ": " + message;

            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port
                // combination.
                int port = 22;
                string ip = "159.65.235.100";
                TcpClient client = new TcpClient(ip, port);

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(fullMessage);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();

                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);

                Console.WriteLine("Sent: {0}", fullMessage);

                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }
    }

}
