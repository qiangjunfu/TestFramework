/********************************************
 *Copyright(C) 2021 by Hisim 
 *All rights reserved. 
 *FileName:     LoadSceneManager.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-02-24 01:45:53 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace LoadSceneSystem
{
    [System.Serializable]
    public class LoadSceneManager : IBaseSystem
    {
        [Header("场景加载虚拟进度")] [SerializeField] private float virtualLoadProgress;
        [Header("场景加载真实进度")] [SerializeField] private float realLoadProgress;
        private Action action;



        public void StartScript()
        {
            virtualLoadProgress = 0;
            realLoadProgress = 0;
            action = null;
        }

        public void UpdateScript()
        {
            action?.Invoke();
        }


        /// <summary>
        /// 异步加载场景
        /// </summary>
        public void AsyncLoadScene(string sceneName, Action loadAction)
        {
            GameRoot.Instance.GlobalCanvas.SetLoadPanel(true);

            AsyncOperation ao = SceneManager.LoadSceneAsync(sceneName);

            action = (() =>
            {
                realLoadProgress = ao.progress;

                if (virtualLoadProgress < realLoadProgress)
                {
                    virtualLoadProgress += Time.deltaTime;
                }
                GameRoot.Instance.GlobalCanvas.SetLoadProgress(virtualLoadProgress);
                //Debug.Log($"{sceneName } 加载进度:  {virtualLoadProgress} --- {realLoadProgress }   ");

                if (virtualLoadProgress >= 1)
                {
                    loadAction?.Invoke();
                    virtualLoadProgress = 0;
                    realLoadProgress = 0;
                    action = null;
                    ao = null;
                    GameRoot.Instance.GlobalCanvas.SetLoadPanel(false);
                }
            });
        }
    }
}