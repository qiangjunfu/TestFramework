/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     EndTrigger.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-03-01 02:00:25 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TriggerSystem
{
    public class EndTrigger : Triggerable
    {
        private void OnTriggerEnter(Collider other)
        {
            TriggerDelegateBool(true);
        }
    }
}