using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Server
{
    class ClientState
    {
        public Socket socket;
        public byte[] readBuff = new byte[1024];

        public ClientState() { }
        public ClientState(Socket _socket) { socket = _socket; }

        public string GetDesc()
        {
            return socket.RemoteEndPoint.ToString();
        }

        public void Send(string sendStr)
        {
            byte[] sendBytes = Encoding.Default.GetBytes(sendStr);
            Send(sendBytes);
        }

        public void Send(byte[] sendBytes)
        {
            socket.Send(sendBytes);
        }
    }

    class EchoServer
    {
        private string _ip;
        private int _port;
        public EchoServer(string ip, int port)
        {
            this._ip = ip;
            this._port = port;
        }

        Socket listenfd = null;
        ObjectPool<ClientState> clientStatePool = new ObjectPool<ClientState>();
        Dictionary<Socket, ClientState> clients = new Dictionary<Socket, ClientState>();

        public void Start()
        {
            listenfd = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAdr = IPAddress.Parse(_ip);
            IPEndPoint ipEp = new IPEndPoint(ipAdr, this._port);
            listenfd.Bind(ipEp);
            listenfd.Listen(0);
            Console.WriteLine("Server started, ip = {0}, port = {1}", this._ip, this._port);

            #region 多路复用
            //多路复用：同时处理多路信号
            List<Socket> checkRead = new List<Socket>() { };
            while (true) {
                checkRead.Clear();
                checkRead.Add(listenfd);
                foreach (var client in clients.Values)
                {
                    checkRead.Add(client.socket);
                }
                Socket.Select(checkRead, null, null, 1000);
                foreach (var item in checkRead)
                {
                    if (item == listenfd)
                        ReadListenfd(item);
                    else
                        ReadClientfd(item);
                }
            }
            #endregion
        }

        #region ReadListenfd, ReadClientfd
        private void ReadListenfd(Socket listenfd)
        {
            Console.WriteLine("Accept Client");
            Socket clientfd = listenfd.Accept();
            ClientState state = clientStatePool.Get();
            state.socket = clientfd;
            clients.Add(clientfd, state);
        }

        private bool ReadClientfd(Socket clientfd)
        {
            ClientState state = clients[clientfd];
            // Receive byte.
            int count;
            try
            {
                count = clientfd.Receive(state.readBuff);
            }
            catch (SocketException e)
            {
                CloseClient(clientfd);
                Console.WriteLine("Client Connect Error : " + e.Message);
                return false;
            }

            // Client force close.
            if(count == 0) {
                CloseClient(clientfd);
                Console.WriteLine("Client force close socket.");
                return false;
            }

            // Test:转发给所有客户端
            byte[] sendBytes = new byte[count];
            Array.Copy(state.readBuff, 0, sendBytes, 0, count);
            string str = Encoding.Default.GetString(sendBytes);
            Console.WriteLine("Receive, client is {0}, msg = {1}", state.GetDesc(), str);
            foreach (var client in clients.Values)
            {
                client.Send(sendBytes);
            }

            return true;
        }

        public void CloseClient(Socket clientfd)
        {
            var state = clients[clientfd];
            clientfd.Close();
            clients.Remove(clientfd);
            clientStatePool.Release(state);
        }
        #endregion
    }
}
