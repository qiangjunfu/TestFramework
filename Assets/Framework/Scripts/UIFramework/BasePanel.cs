/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     BasePanel.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-18 10:49:33 
 *Email:        17611473176@163.com 
 *Description:    
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UIFramework
{
    public class BasePanel : BaseUI 
    {
        /// <summary>
        /// 将UI移到第一层
        /// </summary>
        public virtual void MoveToTop()
        {
            this.transform.SetAsFirstSibling();
        }
        /// <summary>
        /// 将UI移到最下层
        /// </summary>
        public virtual void MoveToBottom()
        {
            this.transform.SetAsLastSibling();
        }
    }
}