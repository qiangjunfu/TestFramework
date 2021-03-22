/********************************************
 *Copyright(C) 2021 by Hisim 
 *All rights reserved. 
 *FileName:     StateID.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-02-25 07:13:12 
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
    /// ×´Ì¬ID
    /// </summary>
    public enum StateID 
    {
        NullStateID,
        /// <summary>
        /// ½â¶³×´Ì¬
        /// </summary>
        DefreezeState,
        /// <summary>
        /// ¶³½á×´Ì¬
        /// </summary>
        FreezeState,
        /// <summary>
        /// ÖØÖÃ×´Ì¬
        /// </summary>
        ResetState
    }
}