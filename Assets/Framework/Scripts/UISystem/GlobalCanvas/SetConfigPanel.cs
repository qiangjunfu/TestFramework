/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     SetConfigPanel.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-18 02:46:07 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityTool;
using UIFramework;
using UnityEngine;


namespace UISystem.GlobalCanvas
{
    public class SetConfigPanel : BasePanel
    {
        [SerializeField] private SetConfig setConfig;
        [SerializeField] private bool isInit = false;


        public override void SetActiveUI(bool isShow)
        {
            base.SetActiveUI(isShow);

            if (isShow)
            {
                Init();
            }
        }

        //private void Update()
        //{
        //    if (Input.GetKeyDown("1"))
        //    {
        //        生成Json文件();
        //    }
        //}

        void Init()
        {
            string path = System.IO.Path.Combine(Application.streamingAssetsPath, "SetFile", "SetConfig.json");
            setConfig = ReadJson.ReadJsonData<SetConfig>(path);
            isInit = true;
        }


        /// <summary>
        /// 是否显示日志信息
        /// </summary>
        public bool IsShowDebug()
        {
            if (isInit == false)
            {
                isInit = true;
                Init();
            }
            return setConfig.isShowDebug;
        }
        /// <summary>
        /// 是否显示UI信息
        /// </summary>
        /// <returns></returns>
        public bool IsShowUI()
        {
            if (isInit == false)
            {
                isInit = true;
                Init();
            }
            return setConfig.isShowUI;
        }


        void 生成Json文件()
        {
            string path = System.IO.Path.Combine(Application.streamingAssetsPath, "SetFile", "SetConfig.json");
            SetConfig setConfig = new SetConfig(false, false);
            ReadJson.WriteJson(setConfig, path);
        }

    }
}