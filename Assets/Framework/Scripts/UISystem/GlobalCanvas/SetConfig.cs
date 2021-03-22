/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     SetConfig.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-18 02:48:39 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UISystem.GlobalCanvas
{
    [System.Serializable]
    public class SetConfig 
    {
        /// <summary>
        /// 是否显示日志信息
        /// </summary>
        public bool isShowDebug;
        /// <summary>
        /// 是否显示UI界面
        /// </summary>
        public bool isShowUI;


        public SetConfig() { }
        public SetConfig(bool isShowDebug, bool isShowUI)
        {
            this.isShowDebug = isShowDebug;
            this.isShowUI = isShowUI;
        }
    }
}