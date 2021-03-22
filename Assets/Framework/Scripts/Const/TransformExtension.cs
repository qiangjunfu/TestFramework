/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     TransformExtension.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-20 04:03:49 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class TransformExtension
{
    public static void Identity(this MonoBehaviour monoBehaviour)
    {
        monoBehaviour.transform.Identity();
    }

    public static void Identity(this Transform transform)
    {
        transform.localPosition = Vector3.zero;
        transform.localScale = Vector3.one;
        transform.localRotation = Quaternion.identity;
    }

    public static void SetLocalPosX(this Transform transform, float x)
    {
        var localPos = transform.localPosition;
        localPos.x = x;
        transform.localPosition = localPos;
    }

    public static void SetLocalPosY(this Transform transform, float y)
    {
        var localPos = transform.localPosition;
        localPos.y = y;
        transform.localPosition = localPos;
    }

    public static void SetLocalPosZ(this Transform transform, float z)
    {
        var localPos = transform.localPosition;
        localPos.z = z;
        transform.localPosition = localPos;
    }

    public static void SetLocalPosXY(this Transform transform, float x, float y)
    {
        var localPos = transform.localPosition;
        localPos.x = x;
        localPos.y = y;
        transform.localPosition = localPos;
    }

    public static void SetLocalPosXZ(this Transform transform, float x, float z)
    {
        var localPos = transform.localPosition;
        localPos.x = x;
        localPos.z = z;
        transform.localPosition = localPos;
    }

    public static void SetLocalPosYZ(this Transform transform, float y, float z)
    {
        var localPos = transform.localPosition;
        localPos.y = y;
        localPos.z = z;
        transform.localPosition = transform.localPosition;
    }

    public static void SetLocalRotXYZ (this Transform transform  , float x , float y ,float z)
    {
        Vector3 localRot = new Vector3(x, y, z);
        transform.localEulerAngles = localRot;
    }

    public static void AddChild(this Transform parentTrans, Transform childTrans)
    {
        childTrans.SetParent(parentTrans);
    }
}
