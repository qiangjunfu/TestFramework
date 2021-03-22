/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     SimhostState.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-17 04:09:53 
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
    /// Simhost状态基类
    /// </summary>
    public abstract class SimhostStateBase<T> : StateBase<T> where T : IStateData
    {
        protected SimhostStateBase(FSMManager<T> fsm) : base(fsm)
        {

        }
    }
}