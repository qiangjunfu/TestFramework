/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     IMonster.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-19 02:08:32 
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
    public abstract  class IMonster : MonoBehaviour
    {
        /// <summary>
        /// 初始化怪物
        /// </summary>
        public virtual void InitMonster() { }
    }
}