/********************************************
 *Copyright(C) 2021 by Hisim 
 *All rights reserved. 
 *FileName:     StartCanvas.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-02-23 09:11:22 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StartScene
{
    public class StartCanvas : MonoBehaviour
    {
        [SerializeField] private LogoPanel logoPanel;
        [SerializeField] private SelectScenePanel selectScenePanel;

        void Start()
        {
            logoPanel.SetActiveUI(true, () =>
            {
                Debug.Log("logo显示结束回调");
                logoPanel.SetActiveUI(false);
                selectScenePanel.SetActiveUI(true);
            });
        }

        void Update()
        {

        }
    }
}