/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     BaseView.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-18 11:04:15 
 *Email:        17611473176@163.com 
 *Description:    
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UIFramework.MVVM
{
    public abstract class BaseView<VM, M> : MonoBehaviour where VM : IViewModel<M> where M : IModel
    {
        public virtual VM ViewModel { get; }
        public abstract void BindViewModel(VM viewModel);

    }

}