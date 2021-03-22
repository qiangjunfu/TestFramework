/********************************************
 *Copyright(C) 2021 by Hisim 
 *All rights reserved. 
 *FileName:     LogoPanel.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-02-23 08:53:46 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;


namespace StartScene
{
    public class LogoPanel : BasePanel
    {
        [SerializeField] private Image image;
        [SerializeField] private float colorValue;
        private const int Int0 = 0;
        private const int Int2 = 2;
        private const float float254 = 254;
        private const float float255 = 255;
        private Action act ;



        public void SetActiveUI(bool isShow, Action action)
        {
            SetActiveUI(isShow);

            if (isShow)
            {
                colorValue = Int0;
                image.color = new Color((Int0 / float255), (Int0 / float255), (Int0 / float255), float255 / float255);
                act = action;
            }
        }


        private void Update()
        {
            colorValue += Int2;
            colorValue = colorValue > float255 ? float255 : colorValue;
            image.color = new Color(colorValue / float255, colorValue / float255, colorValue / float255, float255 / float255);

            if (colorValue == float254)
            {
                act?.Invoke();
                act = null;
            }
        }
        

    }
}