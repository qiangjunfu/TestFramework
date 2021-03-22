/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     KayakData.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-03-01 08:17:52 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using NetworkSystem.UDP;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace KayakSystem
{
    public class FSMData
    {
        public string name;
        /// <summary>
        /// �û�ʵ������
        /// </summary>
        public GameObject gameObject;
        /// <summary>
        /// Udp���յ�����
        /// </summary>
        public ReceiveData receiveData;
    }
}