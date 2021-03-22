/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     DefreezeState.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-17 04:00:47 
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
    public class DefreezeState : SimhostStateBase<SimhostStateData>
    {
        public DefreezeState(FSMManager<SimhostStateData> fsm) : base(fsm)
        {
            stateID = StateID.DefreezeState;
        }

        public override void BeforeEnter()
        {
            base.BeforeEnter();

        }
        public override void BeforeLeave()
        {
            base.BeforeLeave();
        }
        public override void Act(SimhostStateData data)
        {
            Debug.Log($"{this.GetType() } -> Act()");
        }
        public override void Reason(SimhostStateData data)
        {
            if (data.isPressfreeze)
            {
                fsm.UpdateStateByTransition(Transition.PressFreeze);
            }

            if (data.isPressReset )
            {
                fsm.UpdateStateByTransition(Transition.PressReset);
            }
        }

    }
}