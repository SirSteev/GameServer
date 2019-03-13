using System;
using System.Net;
using System.Net.Sockets;

namespace GameServer
{
    static class ServerTCP
    {
        static TcpListener serverSocket = new TcpListener(IPAddress.Any, 5557); // port number

        public static void InitializeNetwork()
        {
            Console.WriteLine("Initializing Packets...");
            ServerHandleData.InitializePackets();
            serverSocket.Start();
            serverSocket.BeginAcceptTcpClient(new AsyncCallback(OnClientConnection), null);
        }

        private static void OnClientConnection(IAsyncResult result)
        {
            TcpClient client = serverSocket.EndAcceptTcpClient(result);
            serverSocket.BeginAcceptTcpClient(new AsyncCallback(OnClientConnection), null);
            ClientManager.CreateNewConection(client);
        }
    }
}
