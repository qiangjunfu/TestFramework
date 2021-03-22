/********************************************
 *Copyright(C) 2021 by Hisim 
 *All rights reserved. 
 *FileName:     StateBase.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-02-25 07:17:10 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KayakSystem
{
    /// <summary>
    /// ״̬����
    /// </summary>
    public abstract  class StateBase
    {
        protected FSMManager fsm;
        protected StateID stateID;
        protected Dictionary<Transition, StateID> transStateDic = new Dictionary<Transition, StateID>();

        /// <summary>
        /// ��ǰ״̬ID
        /// </summary>
        public StateID StateID { get => stateID; }
        public StateBase(FSMManager fsm) { this.fsm = fsm; }


        public virtual void BeforeEnter()
        {
            Debug.Log($"{this.GetType() } -> BeforeEnter()");
        }
        public virtual void BeforeLeave()
        {
            Debug.Log($"{this.GetType() } -> BeforeLeave()");
        }
        public abstract void Act(FSMData  kayakData);
        public abstract void Reason(FSMData  kayakData);
        public abstract void FixedUpdate(FSMData kayakData);


        /// <summary>
        /// ���ת������, ��ǰ״̬����ת������һ��״̬
        /// </summary>
        public void AddTransition(Transition trans, StateID stateID)
        {
            if (trans == Transition.NullTransition)
            {
                //string typeName = this.GetType().ToString();//�ռ���.���� 
                Debug.LogError($"{this.GetType().Name } -> AddTransition() -> trans ==  Transition.NullTransition  ");
                return;
            }
            if (transStateDic.ContainsKey(trans))
            {
                Debug.LogError($"{this.GetType().Name } -> AddTransition() -> transStateDic.ContainsKey (trans) ");
                return;
            }

            transStateDic.Add(trans, stateID);
        }

        /// <summary>
        /// �Ƴ�ת������
        /// </summary>
        public void RemoveTransition(Transition trans)
        {
            if (trans == Transition.NullTransition)
            {
                Debug.LogError($"{this.GetType().Name } -> RemoveTransition() -> trans ==  Transition.NullTransition  ");
                return;
            }
            if (!transStateDic.ContainsKey(trans))
            {
                Debug.LogError($"{this.GetType().Name } -> RemoveTransition() -> !transStateDic.ContainsKey (trans) ");
                return;
            }
            transStateDic.Remove(trans);
        }

        /// <summary>
        /// ͨ��ת��������ȡ״̬ID
        /// </summary>
        public StateID GetStateIdByTrans(Transition trans)
        {
            if (trans == Transition.NullTransition)
            {
                Debug.LogError($"{this.GetType().Name } -> GetStateIdByTrans() -> trans ==  Transition.NullTransition  ");
                return StateID.NullStateID;
            }
            if (!transStateDic.ContainsKey(trans))
            {
                Debug.LogError($"{this.GetType().Name } -> GetStateIdByTrans() -> !transStateDic.ContainsKey (trans) ");
                return StateID.NullStateID;
            }
            return transStateDic[trans];
        }


        /// <summary>
        /// ���³���״̬
        /// </summary>
        protected  void UpdateSceneState(FSMData kayakData)
        {
            switch (kayakData.receiveData.sceneType)
            {
                case 1:
                    GameRoot.Instance.LoadSceneManager.AsyncLoadScene("KayakSlalomScene", LoadCompleteCallback);
                    break;
                case 2:
                    GameRoot.Instance.LoadSceneManager.AsyncLoadScene("FlatwaterScene", LoadCompleteCallback);
                    break;
                default:
                    break;
            }
        }
        private void LoadCompleteCallback()
        {
            Debug.Log($"����������ɻص�---------");
        }
    }
}