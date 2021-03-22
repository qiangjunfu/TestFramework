/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     ResourcesAssetLoad.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-19 09:15:06 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AssetSystem.AssetLoad
{
    /// <summary>
    /// Resources资源加载
    /// </summary>
    public class ResourcesAssetLoad : IAssetLoad
    {
        public const string AssetsPath = "Assets/";
        public const string AudioPath = "Audios/";
        public const string UIPanelPath = "UiPanels/";
        public const string SpritePath = "UiSprites/";
        public const string AtlasPath = "Atlas/";
        private Dictionary<string, GameObject> assetDic = new Dictionary<string, GameObject>();
        private Dictionary<string, AudioClip> audioClipDic = new Dictionary<string, AudioClip>();
        private Dictionary<string, Sprite> spriteDic = new Dictionary<string, Sprite>();



        public GameObject LoatAsset(string name)
        {
            string path = AssetsPath + name;
            if (assetDic.ContainsKey(path))
            {
                return assetDic[path];
            }
            else
            {
                GameObject g = LoadGameObject(path);
                assetDic.Add(path, g);
                return g;
            }
        }

        public AudioClip LoadAudioClip(string name)
        {
            string path = AudioPath + name;
            if (audioClipDic.ContainsKey(path))
            {
                return audioClipDic[path];
            }
            else
            {
                AudioClip audioClip = Resources.Load(AudioPath + name, typeof(AudioClip)) as AudioClip;
                audioClipDic.Add(path, audioClip);
                return audioClip;
            }
        }

        public GameObject LoadUIPanel(string name)
        {
            string path = UIPanelPath + name;
            return LoadGameObject(path);
        }

        public Sprite LoadSprite(string name)
        {
            string path = SpritePath + name;
            if (spriteDic.ContainsKey(path))
            {
                return spriteDic[path];
            }
            else
            {
                Sprite sprite = Resources.Load<Sprite>(SpritePath + name);
                spriteDic.Add(path, sprite);
                return sprite;
            }
        }

        public Sprite[] LoadAtlas(string name)
        {
            string path = AtlasPath + name;
            return Resources.LoadAll<Sprite>(path);
        }



        private GameObject LoadGameObject(string path)
        {
            GameObject g = Resources.Load<GameObject>(path);//把资源加载到内存中
            //GameObject go = GameObject.Instantiate(g);  //把内存中的资源实例化到场景
            if (g == null)
            {
                Debug.LogError("无法加载资源，路径:" + path);
                return null;
            }
            else
            {
                return g;
            }
        }
    }
}
