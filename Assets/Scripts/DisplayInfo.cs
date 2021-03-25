/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     DisplayInfo.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-03-04 07:26:06 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class DisplayInfo
{
    /// <summary>
    /// ×óÏÔÊ¾Æ÷
    /// </summary>
    public int displayLeft;
    /// <summary>
    /// Ö÷ÏÔÊ¾Æ÷
    /// </summary>
    public int displayMain;
    /// <summary>
    /// ÓÒÏÔÊ¾Æ÷
    /// </summary>
    public int displayRight;



    public DisplayInfo() { }
    public DisplayInfo(int displayLeft, int displayMain, int displayRight)
    {
        this.displayLeft = displayLeft;
        this.displayMain = displayMain;
        this.displayRight = displayRight;
    }

    public DisplayInfo ReadDisplayInfo()
    {
        string path = System.IO.Path.Combine(Application.streamingAssetsPath, "DisplayFile", "DisplayConfig.json");
        //DisplayInfo di = new DisplayInfo(1,0,2);
        //ReadJson.WriteJson<DisplayInfo>(di, path);
        DisplayInfo displayInfo = UnityTool.ReadJson.ReadJsonData<DisplayInfo>(path);
        return displayInfo;
    }
}
