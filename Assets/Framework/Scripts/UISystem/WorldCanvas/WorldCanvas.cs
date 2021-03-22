/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     WorldCanvas.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-19 03:42:55 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WorldCanvas : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private Camera targetCamera;
    [SerializeField] [Range(0, 3)] private int rotType;


    void Start()
    {
        if (targetCamera == null) targetCamera = Camera.main;
        if (canvas == null) canvas = GetComponent<Canvas>();
        canvas.renderMode = RenderMode.WorldSpace;
        canvas.worldCamera = targetCamera;
    }


    void Update()
    {
        switch (rotType)
        {
            case 0:
                LookTarget1();
                break;
            case 1:
                LookTarget2();
                break;
            case 2:
                LookTarget3();
                break;
            default:
                break;
        }
    }


    void LookTarget1()
    {
        transform.rotation = targetCamera.transform.rotation;
    }

    void LookTarget2()
    {
        Vector3 targetPos = transform.position - targetCamera.transform.position;
        Quaternion lookAtRotation = Quaternion.LookRotation(targetPos, Vector3.up);
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, lookAtRotation, Time.deltaTime);
    }

    void LookTarget3()
    {
        Vector3 dir = targetCamera.transform.position - this.transform.position;
        dir.Normalize();
        transform.rotation = Quaternion.LookRotation(-dir);
    }


    public void OpenWorldCanvas()
    {
        this.gameObject.SetActive(true);
    }
    public void CloseWorldCanvas() 
    {
        this.gameObject.SetActive(false);
    }
}
