/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     ExporterUnityPackage.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-20 03:47:07 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExporterUnityPackage
{
    //itemName：菜单名称路径
    //isValidateFunction：不写为false，true则点击菜单前就会调用
    //priority：菜单项显示排序
    [UnityEditor.MenuItem("FQJ/导出 UnityPackage %e", false, 1)]
    static void MenuClicked()
    {
        AssetDatabase.ExportPackage("Assets/Framework", GeneratePackageName() + ".unitypackage", ExportPackageOptions.Recurse);
        Application.OpenURL("file://" + System.IO.Path.Combine(Application.dataPath, "../"));
    }

    private static string GeneratePackageName()
    {
        return "QFramework_" + System.DateTime.Now.ToString("yyyymmdd_hhmmss");
    }


}
