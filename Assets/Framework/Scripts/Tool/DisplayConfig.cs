/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     DisplayConfig.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-19 04:32:56 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 三屏显示器配置文件
/// </summary>
public class DisplayConfig 
{
    /// <summary>
    /// 左显示器
    /// </summary>
    public int displayLeft;
    /// <summary>
    /// 主显示器
    /// </summary>
    public int displayMain;
    /// <summary>
    /// 右显示器
    /// </summary>
    public int displayRight;



    public DisplayConfig() { }
    public DisplayConfig(int displayLeft, int displayMain, int displayRight)
    {
        this.displayLeft = displayLeft;
        this.displayMain = displayMain;
        this.displayRight = displayRight;
    }

    private void InitDisplay()
    {
        //string path = System.IO.Path.Combine(Application.streamingAssetsPath, "DisplayFile", "DisplayConfig.json");
        ////DisplayInfo di = new DisplayInfo(2, 1, 3);
        ////ReadJson.WriteJson<DisplayInfo>(di, path);
        //DisplayConfig mDisplayInfo = ReadJson.ReadJsonData<DisplayConfig>(path);
        //eyeCamera_Left.targetDisplay = mDisplayInfo.displayLeft - 1;
        //eyeCamera_Main.targetDisplay = mDisplayInfo.displayMain - 1;
        //eyeCamera_Right.targetDisplay = mDisplayInfo.displayRight - 1;
    }
}
