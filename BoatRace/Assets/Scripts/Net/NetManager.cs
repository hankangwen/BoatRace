
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using LuaInterface;
using UnityEngine;

namespace BoatRace.Net
{
    public class NetManager
    {
        private static Socket _socket;
        private static byte[] _readBuff = new byte[1024];
        private static List<string> _msgList = new List<string>();

        public static void Send(string sendStr)
        {
            if (_socket == null)
                return;
            if (!_socket.Connected)
                return;
            Debugger.Log("Send: " + sendStr);
            byte[] sendBytes = Encoding.Default.GetBytes(sendStr);
            // // Add the size of the message to the front of the message
            // // Get bytes length.
            // Int16 bodyLength = (Int16)sendBytes.Length;
            // byte[] sizeBytes = BitConverter.GetBytes(bodyLength);
            // sizeBytes.Concat(sendBytes);
            Send(sendBytes);
        }
        
        public static void Send(byte[] sendBytes)
        {
            _socket.Send(sendBytes);
        }
        
        public static void Connect(string ip, int port)
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _socket.Connect(ip, port);
            _socket.BeginReceive(_readBuff, 0, 1024, SocketFlags.None, ReceiveCallBack, _socket);
        }

        private static void ReceiveCallBack(IAsyncResult ar)
        {
            try
            {
                Socket socket = (Socket) ar.AsyncState;
                int count = socket.EndReceive(ar);
                string str = Encoding.Default.GetString(_readBuff, 0, count);
                _msgList.Add(str);
                socket.BeginReceive(_readBuff, 0, 1024, SocketFlags.None, ReceiveCallBack, socket);
            }
            catch (Exception e)
            {
                Debug.LogError("Socket receive failed " + e.Message);
            }
        }
        
        public static void Close()
        {
            if (_socket == null)
                return;
            _socket.Close();
            _socket = null;
        }
        
        public static void Update()
        {
            if (_msgList.Count <= 0)
                return;

            string msgStr = _msgList[0];
            _msgList.RemoveAt(0);
            Debugger.Log(msgStr);
            // string[] split = msgStr.Split('|');
            // string msgName = split[0];
            // string msgArgs = split[1];
            // foreach (var item in _listeners)
            // {
            //     Debugger.Log(item.Key);
            // }
            // Debugger.Log(msgName);
            // if (_listeners.ContainsKey(msgName))
            // {
            //     _listeners[msgName](msgArgs);
            // }
        }
    }
}