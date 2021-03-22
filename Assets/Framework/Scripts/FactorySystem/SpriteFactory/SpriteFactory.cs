/********************************************
 *Copyright(C) 2021 by Hisim 
 *All rights reserved. 
 *FileName:     SpriteFactory.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-02-24 08:52:09 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FactorySystem.Sprites
{
    public class SpriteFactory
    {
        /// <summary>
        /// 创建图片
        /// </summary>
        public Sprite CreateSprite(string name)
        {
            return AssetSystem.AssetManager.Instance.ResourcesAssetLoad.LoadSprite(name);
        }


        /// <summary>
        /// 创建图集
        /// </summary>
        public Sprite[] CreateAtlas(string name)
        {
            return AssetSystem.AssetManager.Instance.ResourcesAssetLoad.LoadAtlas(name);
        }
    }
}