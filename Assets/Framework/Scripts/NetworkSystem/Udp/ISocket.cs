using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;


namespace NetworkSystem.UDP
{
    public abstract class ISocket
    {
        protected Socket socket;
        protected IPEndPoint receivePoint;
        protected Thread receiveThread;
        protected byte[] receiveBuffer;
        protected const int SleepTime_10 = 10;
        protected EndPoint endPoint;


        public abstract void StartThread();

        public ISocket() { }

        /// <summary>
        /// 初始化绑定端口号(服务器)
        /// </summary>
        public virtual void InitBindIPPort(int port)
        {
            try
            {
                receiveBuffer = new byte[1024];
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                receivePoint = new IPEndPoint(IPAddress.Any, 0);
                IPEndPoint tmpPoint = new IPEndPoint(IPAddress.Any, port);
                socket.Bind(tmpPoint);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }

        /// <summary>
        /// 发送btye数据(固定ip)
        /// </summary>
        protected virtual void SendBytes(byte[] buffer, string ip, int port)
        {
            try
            {
                IPEndPoint tmpEnd = new IPEndPoint(IPAddress.Parse(ip), port);
                //int realSend = socket.SendTo(buffer, buffer.Length, SocketFlags.None, tmpEnd);
                socket.SendTo(buffer, buffer.Length, SocketFlags.None, tmpEnd);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }

        /// <summary>
        /// 广播发送btye数据
        /// </summary>
        protected virtual void BroadcastSend(byte[] buffer, int port)
        {
            try
            {
                IPEndPoint tmpEnd = new IPEndPoint(IPAddress.Broadcast, port);
                socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
                socket.SendTo(buffer, buffer.Length, SocketFlags.None, tmpEnd);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }


        /// <summary>
        /// 结构体转btye数组
        /// </summary>
        protected  byte[] StructToBytes(object obj)
        {
            int size = Marshal.SizeOf(obj);
            byte[] bytes = new byte[size];
            IntPtr structPtr = Marshal.AllocHGlobal(size); //分配结构体大小的内存空间
            Marshal.StructureToPtr(obj, structPtr, false); //将结构体拷到分配好的内存空间
            Marshal.Copy(structPtr, bytes, 0, size);       //从内存空间拷到byte数组
            Marshal.FreeHGlobal(structPtr);                //释放内存空间
            return bytes;
        }

        /// <summary>
        /// btye数组转结构体
        /// </summary>
        protected object BytesToStruct(byte[] bytes, Type type)
        {
            int size = Marshal.SizeOf(type);
            if (size > bytes.Length) return null;
            IntPtr structPtr = Marshal.AllocHGlobal(size);
            Marshal.Copy(bytes, 0, structPtr, size);
            object obj = Marshal.PtrToStructure(structPtr, type);
            Marshal.FreeHGlobal(structPtr);
            return obj;
        }


        /// <summary>
        /// 销毁接收线程
        /// </summary>
        public virtual void Dispose()
        {
            Debug.Log("释放UDP线程------------------");

            if (socket != null)
            {
                socket.Close();
            }

            if (receiveThread != null)
            {
                receiveThread.Interrupt();
                receiveThread.Abort();
                receiveThread = null;
            }
        }
    }
}