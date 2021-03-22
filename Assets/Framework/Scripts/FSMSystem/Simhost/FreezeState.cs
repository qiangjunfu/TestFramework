/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     FreezeState.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-17 04:23:07 
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
    /// 冻结状态
    /// </summary>
    public class FreezeState : SimhostStateBase<SimhostStateData>
    {
        public FreezeState(FSMManager<SimhostStateData> fsm) : base(fsm)
        {
            stateID = StateID.FreezeState;
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
            if (data.isPressDefreeze)
            {
                fsm.UpdateStateByTransition(Transition.PressDefreeze);
            }

            if (data.isPressReset)
            {
                fsm.UpdateStateByTransition(Transition.PressReset);
            }
        }

    }
}