/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     IModel.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-18 10:53:45 
 *Email:        17611473176@163.com 
 *Description:    
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UIFramework.MVVM
{
    public interface IModel
    {
        PropertyBind<string> Name { get; set; }
        PropertyBind<int> Id { get; }
    }
}