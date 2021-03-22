/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     ICharacter.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-19 10:31:19 
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
    public abstract class ICharacter : MonoBehaviour
    {
        /// <summary>
        /// 初始化角色
        /// </summary>
        public virtual void InitCharacter() { }

    }
}