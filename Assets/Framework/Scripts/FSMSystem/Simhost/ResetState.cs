/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     ResetState.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-17 04:24:36 
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
    /// 解冻状态
    /// </summary>
    public class ResetState : SimhostStateBase<SimhostStateData>
    {
        public ResetState(FSMManager<SimhostStateData> fsm) : base(fsm)
        {
            stateID = StateID.ResetState;
        }

        public override void BeforeEnter()
        {
            base.BeforeEnter();

        }
        public override void BeforeLeave()
        {
            base.BeforeLeave();
        }
        public override void Act(SimhostStateData data )
        {
            Debug.Log($"{this.GetType() } -> Act()");
        }
        public override void Reason(SimhostStateData data) 
        {
            if (data.isPressDefreeze)
            {
                fsm.UpdateStateByTransition(Transition.PressDefreeze);
            }

            if (data.isPressfreeze)
            {
                fsm.UpdateStateByTransition(Transition.PressFreeze);
            }
        }

    }
}