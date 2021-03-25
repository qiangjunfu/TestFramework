/********************************************
 *Copyright(C) 2021 by Hisim 
 *All rights reserved. 
 *FileName:     CountdownPanel.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-02-24 06:42:20 
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


namespace UISystem.GlobalCanvas
{
    public class CountdownPanel : BasePanel
    {
        [SerializeField] private List<Sprite> spriteList;
        [SerializeField] private RectTransform rect;
        [SerializeField] private Image image;
        [SerializeField] private float timer;
        [SerializeField] private int index;
        [SerializeField] private bool isZoom;
        [SerializeField] private float stepTime;
        private Action action;
        private Vector3 oldSizeDelta = new Vector3(1000, 1000, 0);
        private Vector3 newSizeDelta = new Vector3(350, 350, 0);
        private Color oldColor = new Color(255 / 255, 0 / 255, 0 / 255, 255 / 255);
        private Color newColor = new Color(255 / 255, 0 / 255, 0 / 255, 100 / 255);
        private const int countdown = 4;


        public void SetActiveUI(bool isShow, Action countdownCallback)
        {
            SetActiveUI(isShow);

            if (isShow)
            {
                if (spriteList.Count == 0)
                {
                    Sprite sprite0 = FactorySystem.FactoryManager.Instance.SpriteFactory.CreateSprite("start");
                    Sprite sprite1 = FactorySystem.FactoryManager.Instance.SpriteFactory.CreateSprite("1");
                    Sprite sprite2 = FactorySystem.FactoryManager.Instance.SpriteFactory.CreateSprite("2");
                    Sprite sprite3 = FactorySystem.FactoryManager.Instance.SpriteFactory.CreateSprite("3");
                    spriteList.Add(sprite0);
                    spriteList.Add(sprite1);
                    spriteList.Add(sprite2);
                    spriteList.Add(sprite3);
                }
                timer = countdown;
                index = countdown;
                isZoom = false;
                stepTime = 0;
                action = null;

                if (countdownCallback != null)
                {
                    action = countdownCallback;
                }
            }
        }


        void Update()
        {
            if (GameRoot.Instance.UdpManager.GetReceiveData.isReset == 1 ||
                GameRoot.Instance.UdpManager.GetReceiveData.isFreeze == 1) return;

            timer -= Time.deltaTime;
            if (timer < index)
            {
                index--;
                if (index <= -1)
                {
                    image.sprite = spriteList[3];
                    SetActiveUI(false);
                }
                else
                {
                    image.sprite = spriteList[index];
                    //isZoom = true;
                    if (index == 0)
                    {
                        if (action != null)
                        {
                            action();
                            action = null;
                        }
                    }
                }
            }

            if (isZoom)
            {
                Zoom(oldSizeDelta, newSizeDelta, 1);
            }
        }


        void Zoom(Vector2 oldSizeDelta, Vector2 newSizeDelta, float useTime)
        {
            stepTime += Time.deltaTime;
            rect.sizeDelta = Vector3.Lerp(oldSizeDelta, newSizeDelta, stepTime / useTime);
            image.color = Color.Lerp(oldColor, newColor, stepTime / useTime);
            if (stepTime >= useTime - 0.06f)
            {
                isZoom = false;
                stepTime = 0;
            }
        }
    }
}