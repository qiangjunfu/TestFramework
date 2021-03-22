/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     GateTrigger.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-03-01 01:58:43 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TriggerSystem
{
    public class GateTrigger : Triggerable
    {
        [Header("旗门位置")] [SerializeField] [Range(-1, 1)] private int gatePos;
        [Header("旗门分数")] [SerializeField] [Range(-1, 1)] private int score;

        private void OnTriggerEnter(Collider other)
        {
            TriggerDelegateIntInt(gatePos, score);
        }
    }
}