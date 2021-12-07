using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Drank_mixer_app
{
    public class Arduino
    {
        public static string Cummunicate()
        {
            string result = "No Response";
            IPAddress ipAddress = IPAddress.Parse("169.254.127.17"); //laptop connection
            IPEndPoint endPoint = new IPEndPoint(ipAddress, 42069); //instellen op welke poort en ip wordt gecommunicate
            Socket s = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            s.Connect(endPoint);
            if (s.Connected)
            {
                //send
                byte[] msg = Encoding.ASCII.GetBytes("<TEMP>");
                s.Send(msg);
                //receive
                //byte[] buffer = new byte[100];
                //int bytesReceived = s.Receive(buffer);
                //result = Encoding.ASCII.GetString(buffer, 0, bytesReceived).Split('>')[1];
                //close
                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }
            return result;
        }
        
    }
}
