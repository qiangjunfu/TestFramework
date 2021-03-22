/********************************************
 *Copyright(C) 2021 by Hisim 
 *All rights reserved. 
 *FileName:     SelectScenePanel.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-02-23 09:17:36 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UIFramework;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace StartScene
{
    public class SelectScenePanel : BasePanel
    {
        /// <summary>
        /// 是否已经加载过场景
        /// </summary>
        private bool isLoadScene;
        private float timer;
        private int defultTime = 30;


        public override void SetActiveUI(bool isShow)
        {
            base.SetActiveUI(isShow);

            if (isShow)
            {
                isLoadScene = false;
            }
        }

        public void Update()
        {
            if (isLoadScene) return;

            if (GameRoot.Instance.UdpManager.IsConnect)
            {
                Connect();
            }
            else
            {
                Disconnect();
            }

            ////30秒不做选择 默认加载钢架雪车场景
            //timer += Time.deltaTime;
            //if (timer >= defultTime)
            //{
            //    SceneManager.LoadSceneAsync(1);
            //    isLoadScene = true;
            //}
        }

        void Connect()
        {
            switch (GameRoot.Instance.UdpManager.GetReceiveData.sceneType)
            {
                case 1:
                    GameRoot.Instance.LoadSceneManager.AsyncLoadScene("ParallelGiantSlalom", LoadCompleteCallback);
                    isLoadScene = true;
                    break;
                default:
                    break;
            }
        }

        void Disconnect()
        {
            if (Input.GetKeyDown("1"))
            {
                GameRoot.Instance.LoadSceneManager.AsyncLoadScene("ParallelGiantSlalom", LoadCompleteCallback);
                isLoadScene = true;
            }
        }

        private void LoadCompleteCallback()
        {
            Debug.Log($"场景加载完成回调---------");
        }

    }
}