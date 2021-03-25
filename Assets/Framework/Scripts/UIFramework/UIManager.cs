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
        //1.Count ��ȡջ�е�Ԫ�ظ���
        //2.public virtual void Clear(); �� Stack ���Ƴ����е�Ԫ��
        //3.public virtual bool Contains(object obj); �ж�ĳ��Ԫ���Ƿ��� Stack ��
        //4.public virtual object Peek(); ������ Stack �Ķ����Ķ��󣬵����Ƴ���
        //5.public virtual object Pop(); �Ƴ��������� Stack �Ķ����Ķ���
        //6.public virtual void Push(object obj); �� Stack �Ķ������һ������
        //7.public virtual object[] ToArray(); ���� Stack ��һ���µ�������
        //Queue
        //1.Count ��ȡ�����е�Ԫ�ظ���
        //2.public virtual void Clear(); �� Queue���Ƴ����е�Ԫ��
        //3.public virtual bool Contains(object obj); �ж�ĳ��Ԫ���Ƿ��� Queue��
        //4.public virtual object Dequeue(); �Ƴ��������� Queue�Ķ����Ķ���
        //5.public virtual void Enqueue(object obj); �� Queue��ĩβ���һ������
        //6.public virtual object[] ToArray(); ���� Queue��һ���µ�������
        //7.**public virtual void TrimToSize()**��������ΪQueue��Ԫ�ص�ʵ�ʸ���
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