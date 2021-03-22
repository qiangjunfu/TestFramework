/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     BaseUI.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-18 10:49:49 
 *Email:        17611473176@163.com 
 *Description:    
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UIFramework
{
    public class BaseUI : MonoBehaviour
    {
        /// <summary>
        /// 激活UI
        /// </summary>
        public virtual void SetActiveUI(bool isShow)
        {
            this.gameObject.SetActive(isShow);
        }
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
