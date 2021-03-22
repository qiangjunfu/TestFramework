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
        [Header("���������������")] [SerializeField] private float virtualLoadProgress;
        [Header("����������ʵ����")] [SerializeField] private float realLoadProgress;
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
        /// �첽���س���
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
                //Debug.Log($"{sceneName } ���ؽ���:  {virtualLoadProgress} --- {realLoadProgress }   ");

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