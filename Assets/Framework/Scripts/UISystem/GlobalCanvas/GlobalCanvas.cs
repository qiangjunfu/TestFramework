/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     GlobalCanvas.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-18 02:51:54 
 *Email:        17611473176@163.com 
 *Description:  一些所有界面通用的UI 放在该Canvas下
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UISystem.GlobalCanvas
{
    public class GlobalCanvas : MonoBehaviour, IBaseSystem
    {
        [Header("设置界面")] [SerializeField] private SetConfigPanel setConfigPanel;
        [Header("倒计时界面")] [SerializeField] private CountdownPanel countdownPanel;
        [Header("冻结界面")] [SerializeField] private FreezePanel freezePanel;
        [Header("加载界面")] [SerializeField] private LoadPanel loadPanel;


        public void StartScript()
        {
            setConfigPanel.SetActiveUI(false);
            countdownPanel.SetActiveUI(false);
            freezePanel.SetActiveUI(false);
            loadPanel.SetActiveUI(false);
        }

        public void UpdateScript()
        {

        }

        /// <summary>
        /// 设置配置界面
        /// </summary>
        public void SetConfigPanel(bool isShow)
        {
            setConfigPanel.SetActiveUI(isShow);
        }
        /// <summary>
        /// 设置倒计时界面
        /// </summary>
        public void SetCountdownPanel(bool isShow, System.Action countdownAction)
        {
            countdownPanel.SetActiveUI(isShow, countdownAction);
        }
        /// <summary>
        /// 设置冻结界面
        /// </summary>
        public void SetFreezePanel(bool isShow)
        {
            freezePanel.SetActiveUI(isShow);
        }
        /// <summary>
        /// 设置加载界面
        /// </summary>
        public void SetLoadPanel(bool isShow, bool isShowSlider = true)
        {
            loadPanel.SetActiveUI(isShow, isShowSlider);
        }

        /// <summary>
        /// 设置场景加载界面 加载进度
        /// </summary>
        public void SetLoadProgress(float progress)
        {
            loadPanel.SetLoadProgress(progress);
        }

    }
}