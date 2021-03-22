/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     INPC.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-19 02:06:45 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FactorySystem.Character
{
    /// <summary>
    /// 角色基类
    /// </summary>
    public abstract  class INPC : MonoBehaviour
    {
        /// <summary>
        /// 初始化NPC
        /// </summary>
        public virtual void InitNPC() { } 
    }
}