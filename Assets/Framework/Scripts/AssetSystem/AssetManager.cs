/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     AssetManager.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-19 09:12:32 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using AssetSystem.AssetLoad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;


namespace AssetSystem
{
    /// <summary>
    /// 资源加载管理器
    /// </summary>
    public class AssetManager
    {
        private static AssetManager instance;
        public static AssetManager Instance
        {
            get
            {
                if (instance == null)
                {
                    var ctor = typeof(AssetManager).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new System.Type[0], null);
                    if (ctor == null)
                    {
                        throw new NullReferenceException("这个类必须有一个私有的无参的构造函数!!!");
                    }
                    instance = (AssetManager)ctor.Invoke(null);
                }
                return instance;
            }
        }
        private AssetManager() { }


        private ResourcesAssetLoad resourcesAssetLoad;
        public ResourcesAssetLoad ResourcesAssetLoad
        {
            get
            {
                if (resourcesAssetLoad == null) resourcesAssetLoad = new ResourcesAssetLoad();
                return resourcesAssetLoad;
            }
        }


    }
}