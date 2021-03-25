/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     Triggerable.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-03-01 01:55:46 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ParallelGiantSlalom
{
    public delegate void TriggerDelegate();
    public delegate void TriggerDelegate<T>(T arg1);
    public delegate void TriggerDelegate<T, K>(T arg1, K arg2);
    
    public class Triggerable : MonoBehaviour
    {
        public TriggerDelegate TriggerDelegate;
        public TriggerDelegate<bool> TriggerDelegateBool;
        public TriggerDelegate<int, int> TriggerDelegateIntInt;


    }
}
