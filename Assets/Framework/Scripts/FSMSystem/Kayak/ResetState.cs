/********************************************
 *Copyright(C) 2021 by Hisim 
 *All rights reserved. 
 *FileName:     ResetState.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-02-25 07:31:57 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KayakSystem
{
    public class ResetState : StateBase
    {
        public ResetState(FSMManager fsm) : base(fsm)
        {
            stateID = StateID.ResetState;
        }

        public override void BeforeEnter()
        {
            base.BeforeEnter();
            string name = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
            GameRoot.Instance.LoadSceneManager.AsyncLoadScene(name, () =>
            {
                Debug.Log($"重置场景完成--------");
            }); 
        }

        public override void BeforeLeave()
        {
            base.BeforeLeave();
        }

        public override void Act(FSMData kayakData)
        {
            Debug.Log($"{this.GetType() } -> Act()");
        }

        public override void Reason(FSMData kayakData)
        {
            if (kayakData.receiveData.isReset == 1) return;

            if (kayakData.receiveData.isFreeze == 0)
            {
                fsm.UpdateStateByTransition(Transition.PressDefreeze);
            }

            if (kayakData.receiveData.isFreeze == 1)
            {
                fsm.UpdateStateByTransition(Transition.PressFreeze);
            }
        }

        public override void FixedUpdate(FSMData kayakData)
        {
            
        }
    }
}