/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     FSMManager.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-17 03:43:12 
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
    /// FSM管理器
    /// </summary>
    public class FSMManager<T> where T : IStateData
    {
        /// <summary>
        /// 当前状态ID
        /// </summary>
        private StateID currentStateID;
        /// <summary>
        /// 当前状态
        /// </summary>
        private StateBase<T> currentState;
        /// <summary>
        /// 存储的状态字典
        /// </summary>
        private Dictionary<StateID, StateBase<T>> stateDic = new Dictionary<StateID, StateBase<T>>();



        /// <summary>
        /// 初始化状态
        /// </summary>
        public void InitState(StateBase<T> state)
        {
            if (currentState == null)
            {
                currentState = state;
                currentStateID = state.StateID;
                currentState.BeforeEnter();
            }
        }

        /// <summary>
        /// 状态更新
        /// </summary>
        public void Update(T t)
        {
            currentState.Act(t);
            currentState.Reason(t);
        }

        /// <summary>
        /// 更新状态通过转换条件
        /// </summary>
        public void UpdateStateByTransition(Transition trans)
        {
            if (trans == Transition.NullTransition)
            {
                Debug.LogError($"{this.GetType().Name } -> UpdateStateByTransition -> trans == Transition.NullTransition");
                return;
            }

            StateID id = currentState.GetStateIdByTrans(trans);
            if (id == StateID.NullStateID)
            {
                Debug.LogError($"{this.GetType().Name } -> UpdateStateByTransition -> id == StateID.NullStateID");
                return;
            }
            if (!stateDic.ContainsKey(id))
            {
                Debug.LogError($"{this.GetType().Name } -> UpdateStateByTransition -> !stateDic.ContainsKey(id)");
                return;
            }

            currentState.BeforeLeave();
            StateBase<T> state = stateDic[id];
            currentState = state;
            currentStateID = state.StateID;
            currentState.BeforeEnter();
        }

        /// <summary>
        /// 添加状态
        /// </summary>
        public void AddState(StateBase<T> state)
        {
            if (state == null)
            {
                Debug.LogError($"{this.GetType().Name } -> AddState() -> state == null ");
                return;
            }

            if (stateDic.ContainsKey(state.StateID))
            {
                Debug.LogError($"{this.GetType().Name } -> AddState() -> stateDic.ContainsKey(state.StateID) : {state.StateID }");
                return;
            }

            stateDic.Add(state.StateID, state);
        }

        /// <summary>
        /// 移除状态
        /// </summary>
        public void RemoveState(StateID stateID)
        {
            if (stateID == StateID.NullStateID)
            {
                Debug.LogError($"{this.GetType().Name } -> RemoveState() -> stateID == StateID.NullStateID");
                return;
            }
            if (stateDic.ContainsKey(stateID) == false)
            {
                Debug.LogError($"{this.GetType().Name } -> RemoveState() -> stateDic .ContainsKey(stateID) == false ：{stateID}");
                return;
            }
            stateDic.Remove(stateID);
        }


    }
}