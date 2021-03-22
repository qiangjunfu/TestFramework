/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     ReadJson.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-18 09:22:39 
 *Email:        17611473176@163.com 
 *Description:    
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityTool
{
    public static class ReadJson
    {
        /// <summary>
        /// 写入json文件
        /// </summary>
        public static void WriteJson<T>(T t, string path) where T : new()
        {
            string str = Newtonsoft.Json.JsonConvert.SerializeObject(t);
            Debug.Log(str);
            ReadTxt.WriteInTxtByStream(path, str);
        }

        /// <summary>
        /// 读取单个json类
        /// </summary>
        public static T ReadJsonData<T>(string path) where T : new()
        {
            string s = ReadTxt.ReadTxtByAllText(path);
            T t = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(s);
            return t;
        }


        public static List<T> ReadJsonArray<T>(string path) where T : new()
        {
            string s = ReadTxt.ReadTxtByAllText(path);
            Debug.LogFormat("{1} 读取信息: {0}", s, path);
            List<T> t = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(s);
            return t;
        }

    }
}