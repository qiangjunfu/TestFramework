/******************************************
 *Copyright(C) 2021 by DefaultCompany
 *All rights reserved.
 *FileName:     UIManager.cs
 *Author:       FuQiangJun
 *Version:      1.0
 *UnityVersion: 2018.3.4f1
 *Date:         2021-03-25 09:12:42
 *Description:  
 *History:
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UIFramework
{
    public class UIManager : MonoBehaviour
    {
        #region 
        private static UIManager instance;
        public static UIManager Instance
        {
            get
            {
                if (instance == null)
                {
                    GameObject go = new GameObject(typeof(UIManager).ToString());
                    go.AddComponent<UIManager>();
                }
                return instance;
            }
        }
        protected virtual void Awake()
        {
            if (instance == null)
            {
                instance = GetComponent<UIManager>();
            }
            else
            {
                Destroy(gameObject);
            }
        }
        protected virtual void OnDestroy()
        {
            if (instance != null) instance = null;
        }
        //Stack
        //1.Count 获取栈中的元素个数
        //2.public virtual void Clear(); 从 Stack 中移除所有的元素
        //3.public virtual bool Contains(object obj); 判断某个元素是否在 Stack 中
        //4.public virtual object Peek(); 返回在 Stack 的顶部的对象，但不移除它
        //5.public virtual object Pop(); 移除并返回在 Stack 的顶部的对象
        //6.public virtual void Push(object obj); 向 Stack 的顶部添加一个对象
        //7.public virtual object[] ToArray(); 复制 Stack 到一个新的数组中
        //Queue
        //1.Count 获取队列中的元素个数
        //2.public virtual void Clear(); 从 Queue中移除所有的元素
        //3.public virtual bool Contains(object obj); 判断某个元素是否在 Queue中
        //4.public virtual object Dequeue(); 移除并返回在 Queue的顶部的对象
        //5.public virtual void Enqueue(object obj); 向 Queue的末尾添加一个对象
        //6.public virtual object[] ToArray(); 复制 Queue到一个新的数组中
        //7.**public virtual void TrimToSize()**设置容量为Queue中元素的实际个数
        #endregion 
        private Dictionary<UIPanelType, BasePanel> panelDic;
        private Stack<BasePanel> panelStack;


        void Start()
        {
            if (panelDic == null) panelDic = new Dictionary<UIPanelType, BasePanel>();
            if (panelStack == null) panelStack = new Stack<BasePanel>();

            GetPanel(UIPanelType.CountdownPanel);
            GetPanel(UIPanelType.FreezePanel);
            GetPanel(UIPanelType.LoadPanel);
            GetPanel(UIPanelType.SetConfigPanel);
        }


        public void PushPanel(UIPanelType uiPanelType)
        {
            if (panelStack.Count > 0)
            {
                BasePanel topPanel = panelStack.Peek();
                //topPanel.SetActiveUI(false);
            }

            BasePanel panel = GetPanel(uiPanelType);
            panel.SetActiveUI(true);
            panelStack.Push(panel);
        }

        public void PopPanel()
        {
            if (panelStack.Count <= 0) return;
            BasePanel topPanel = panelStack.Pop();
            topPanel.SetActiveUI(false);

            if (panelStack.Count <= 0) return;
            BasePanel topPanel2 = panelStack.Peek();
            topPanel.SetActiveUI(true);
        }


        private BasePanel GetPanel(UIPanelType uiPanelType)
        {
            BasePanel panel = null;
            if (!panelDic.ContainsKey(uiPanelType))
            {
                string path = "UiPanels/" + uiPanelType.ToString();
                GameObject g = Resources.Load(path) as GameObject;
                GameObject go = Instantiate(g);
                panel = go.GetComponent<BasePanel>();
                panel.transform.SetParent(this.transform);
                panel.SetActiveUI(false);
                panelDic.Add(uiPanelType, panel);
                return panel;
            }
            panel = panelDic[uiPanelType];
            return panel;
        }
    }
}