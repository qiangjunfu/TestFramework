/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     AudioManager.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-18 02:27:17 
 *Email:        17611473176@163.com 
 *Description:    
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour , IBaseSystem
{
    [SerializeField] private AudioSource audioSourceBG;
    [SerializeField] private AudioSource audioSourceUI;


    public void StartScript()
    {
        
    }
    public void UpdateScript()
    {
        
    }

    public void PlayUIAudio(string name, float volume = 1)
    {
        AudioClip audio = AssetSystem.AssetManager.Instance.ResourcesAssetLoad.LoadAudioClip(name);
        audioSourceUI.loop = false;
        audioSourceUI.volume = volume;
        audioSourceUI.Play();
    }

    public void PlayBGM(string name, float volume = 1)
    {
        AudioClip bgm = AssetSystem.AssetManager.Instance.ResourcesAssetLoad.LoadAudioClip(name);
        if (audioSourceBG.clip != bgm)
        {
            audioSourceBG.clip = bgm;
        }
        audioSourceBG.loop = true;
        audioSourceBG.volume = volume;
    }

}
