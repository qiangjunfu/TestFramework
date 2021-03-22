/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     TriggerManager.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-03-01 02:07:41 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TriggerSystem
{
    public class TriggerManager : MonoBehaviour
    {
        [SerializeField] private List<GateTrigger> gateTriggers;
        [SerializeField] private EndTrigger  endTrigger;

        public List<GateTrigger> GetGateTriggers { get => gateTriggers; }
        public EndTrigger EndTrigger { get => endTrigger; } 
    }
}