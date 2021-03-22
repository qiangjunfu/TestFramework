/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     StateBase.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-17 03:41:53 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FSM.Simhost
{
    /// <summary>
    /// 状态基类
    /// </summary>
    public abstract class StateBase<T> where T : IStateData
    {
        protected FSMManager<T> fsm;
        protected StateID stateID;
        protected Dictionary<Transition, StateID> transStateDic = new Dictionary<Transition, StateID>();

        /// <summary>
        /// 当前状态ID
        /// </summary>
        public StateID StateID { get => stateID; }
        public StateBase(FSMManager<T> fsm) { this.fsm = fsm; }


        public virtual void BeforeEnter()
        {
            Debug.Log($"{this.GetType() } -> BeforeEnter()");
        }
        public virtual void BeforeLeave()
        {
            Debug.Log($"{this.GetType() } -> BeforeLeave()");
        }
        public abstract void Act(T t);
        public abstract void Reason(T t);


        /// <summary>
        /// 添加转换条件, 当前状态才能转换到另一个状态
        /// </summary>
        public void AddTransition(Transition trans, StateID stateID)
        {
            if (trans == Transition.NullTransition)
            {
                //string typeName = this.GetType().ToString();//空间名.类名 
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
        /// 移除转换条件
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
        /// 通过转换条件获取状态ID
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
    }
}