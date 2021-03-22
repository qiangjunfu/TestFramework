/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     IAssetLoad.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-19 09:13:58 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AssetSystem.AssetLoad
{
    public interface IAssetLoad
    {
        GameObject LoatAsset(string name);
        AudioClip LoadAudioClip(string name);
        GameObject LoadUIPanel(string name);
        Sprite LoadSprite(string name);
        Sprite[] LoadAtlas(string name);
    }
}