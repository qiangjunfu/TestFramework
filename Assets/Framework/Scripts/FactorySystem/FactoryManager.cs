/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     FactoryManager.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-19 11:07:36 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using FactorySystem.Character;
using FactorySystem.Sprites;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;


namespace FactorySystem
{
    /// <summary>
    /// 工厂管理器
    /// </summary>
    public class FactoryManager
    {
        private static FactoryManager instance;
        public static FactoryManager Instance
        {
            get
            {
                if (instance == null)
                {
                    var ctor = typeof(FactoryManager).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new System.Type[0], null);
                    if (ctor == null)
                    {
                        throw new NullReferenceException("这个类必须有一个私有的无参的构造函数!!!");
                    }
                    instance = (FactoryManager)ctor.Invoke(null);
                }
                return instance;
            }
        }
        private FactoryManager() { }


        private SpriteFactory spriteFactory;

       
        public SpriteFactory SpriteFactory
        {
            get
            {
                if (spriteFactory == null) spriteFactory = new SpriteFactory();
                return spriteFactory;
            }
        }
    }
}