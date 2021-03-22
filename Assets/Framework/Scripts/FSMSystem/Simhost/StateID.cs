/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     StateID.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-17 03:45:26 
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
    /// 状态ID
    /// </summary>
    public enum StateID 
    {
        NullStateID,
        /********* Simhost ********/
        /// <summary>
        /// 解冻状态
        /// </summary>
        DefreezeState,
        /// <summary>
        /// 冻结状态
        /// </summary>
        FreezeState,
        /// <summary>
        /// 重置状态
        /// </summary>
        ResetState
    }
}