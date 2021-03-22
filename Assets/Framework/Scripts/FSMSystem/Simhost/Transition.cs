/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     Transition.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-17 03:45:37 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FSM.Simhost
{
    /// <summary>
    /// 转换条件
    /// </summary>
    public enum Transition
    {
        NullTransition,
        /********* Simhost ********/
        /// <summary>
        /// 按下解冻
        /// </summary>
        PressDefreeze,
        /// <summary>
        /// 按下冻结
        /// </summary>
        PressFreeze,
        /// <summary>
        /// 按下重置
        /// </summary>
        PressReset
    }
}