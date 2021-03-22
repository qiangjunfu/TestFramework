/********************************************
 *Copyright(C) 2021 by Hisim 
 *All rights reserved. 
 *FileName:     Transition.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-02-25 07:14:59 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KayakSystem
{
    /// <summary>
    /// ת������
    /// </summary>
    public enum Transition 
    {
        NullTransition,
        /// <summary>
        /// ���½ⶳ
        /// </summary>
        PressDefreeze,
        /// <summary>
        /// ���¶���
        /// </summary>
        PressFreeze,
        /// <summary>
        /// ��������
        /// </summary>
        PressReset
    }
}