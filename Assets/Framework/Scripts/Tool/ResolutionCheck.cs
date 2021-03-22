/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     ResolutionCheck.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-20 03:44:59 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityTool
{
    /// <summary>
    /// 屏幕分辨率检查
    /// </summary>
    public class ResolutionCheck
    {
        /// <summary>
        /// 获取屏幕比例
        /// </summary>
        public static float GetAspectRatio()
        {
            var isLandscape = Screen.width > Screen.height;
            return isLandscape ? (float)Screen.width / Screen.height : (float)Screen.height / Screen.width;
        }

        public static bool IsPadResolution()
        {
            return InAspectRange(4.0f / 3);
        }

        public static bool IsPhoneResolution()
        {
            return InAspectRange(16.0f / 9);
        }

        public static bool IsPhone15Resolution()
        {
            return InAspectRange(3.0f / 2);
        }

        public static bool IsiPhoneXResolution()
        {
            return InAspectRange(2436.0f / 1125);
        }

        public static bool InAspectRange(float dstAspectRatio)
        {
            var aspect = GetAspectRatio();
            return aspect > (dstAspectRatio - 0.05) && aspect < (dstAspectRatio + 0.05);
        }
    }
}