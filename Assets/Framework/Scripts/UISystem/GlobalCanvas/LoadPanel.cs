/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     LoadPanel.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-18 02:58:53 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;


namespace UISystem.GlobalCanvas
{
    public class LoadPanel : BasePanel
    {
        [SerializeField] private Slider slider;
        [SerializeField] private float lifeTime;
        [SerializeField] private bool isLoadComplete;


        public void SetActiveUI(bool isShow, bool isShowSlider)
        {
            SetActiveUI(isShow);

            if (isShow)
            {
                lifeTime = 0;
                isLoadComplete = false;
                slider.value = 0;

                if (isShowSlider == false)
                {
                    slider.gameObject.SetActive(false);
                }
                else
                {
                    slider.gameObject.SetActive(true);
                }
            }
        }


        public void SetLoadProgress(float progress)
        {
            slider.value = progress;
        }

    }
}