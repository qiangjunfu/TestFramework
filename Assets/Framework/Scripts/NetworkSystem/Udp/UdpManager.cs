using NetworkSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;


namespace NetworkSystem.UDP
{
    [System.Serializable]
    public class UdpManager 
    {
        [Header("是否连接上Udp")] [SerializeField] private bool isConnect;
        [Header("心跳检测间隔时间")] [SerializeField] private float intervalTime;
        [Header("ip配置路径")] [SerializeField] private string mPath;
        [SerializeField] private IpConfig mIpConfig;
        [SerializeField] private ReceiveData receiveData;
        [SerializeField] public  SendData sendData;
        private ReceiveSocket receiveSocket;

        public bool IsConnect { get => isConnect; }
        public ReceiveData GetReceiveData { get => receiveData; }
        //public SendData SendData { get => sendData; }
        public UdpManager() { }



        public void StartScript()
        {
            InitIpPortInfo();
            InitSocketThread();
            receiveSocket.receiveEvent += ReceiveDataCallback;
        }
        private void ReceiveDataCallback(ReceiveData receiveData)
        {
            this.receiveData = receiveData;

            receiveSocket.SendData(sendData, mIpConfig.SendIp, mIpConfig.SendPort);
            isConnect = true;
        }

        public void UpdateScript()
        {
            if (isConnect)
            {
                intervalTime += Time.deltaTime;
                if (intervalTime >= 10)
                {
                    isConnect = false;
                    intervalTime = 0;
                }
            }
        }

        public void OnDestroyScript()
        {
            receiveSocket.Dispose();
        }



        private void InitIpPortInfo()
        {
            mPath = Path.Combine(Application.streamingAssetsPath, "JsonFile", "IpJson.json");
            mIpConfig = UnityTool.ReadJson.ReadJsonData<IpConfig>(mPath);
        }

        private void InitSocketThread()
        {
            if (receiveSocket == null) receiveSocket = new ReceiveSocket();

            receiveSocket.InitBindIPPort(mIpConfig.ReceivePort);
            receiveSocket.StartThread();
        }
    }
}