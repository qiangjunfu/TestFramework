/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     GameRoot.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-18 11:20:39 
 *Email:        17611473176@163.com 
 *Description:    
 *History: 
*******************************************/
using NetworkSystem.UDP;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityTool;
using UISystem.GlobalCanvas;
using UnityEngine;
using LoadSceneSystem;


public class GameRoot : MonoSingleTon<GameRoot>
{
    [Header("网络连接系统")] [SerializeField] private UdpManager udpManager;
    [Header("场景加载系统")] [SerializeField] private LoadSceneManager loadSceneManager;
    [Header("声音系统")] [SerializeField] private AudioManager audioManager;
    [Header("全局Canvas系统")] [SerializeField] private GlobalCanvas globalCanvas;
    public UdpManager UdpManager { get => udpManager; }
    public LoadSceneManager LoadSceneManager { get => loadSceneManager; }
    public AudioManager AudioManager { get => audioManager; }
    public GlobalCanvas GlobalCanvas { get => globalCanvas; }



    void Start()
    {
        InitSystemConfig();

        udpManager = new UdpManager();
        loadSceneManager = new LoadSceneManager();
        if (audioManager == null) audioManager = transform.Find("AudioManager").GetComponent<AudioManager>();
        if (globalCanvas == null) globalCanvas = transform.Find("GlobalCanvas").GetComponent<GlobalCanvas>();
        udpManager.StartScript();
        loadSceneManager.StartScript();
        audioManager.StartScript();
        globalCanvas.StartScript();
    }

    void InitSystemConfig()
    {
#if UNITY_EDITOR
        Debug.unityLogger.logEnabled = true;
#else
        Debug.unityLogger.logEnabled = false;
#endif

        Application.targetFrameRate = 60;
        Application.runInBackground = true;
        for (int i = 0; i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate();
        }
    }



    void Update()
    {
        udpManager.UpdateScript();
        loadSceneManager.UpdateScript();
        //audioManager.UpdateScript();
        //globalCanvas.UpdateScript();
    }


    /// <summary>
    /// 设置倒计时界面
    /// </summary>
    public void SetCountdownPanel(bool isShow, System.Action countdownAction)
    {
        globalCanvas.SetCountdownPanel(isShow, countdownAction);
    }


    protected override void OnDestroy()
    {
        base.OnDestroy();

        if (udpManager != null) udpManager.OnDestroyScript();
    }
}
