/********************************************
 *Copyright(C) 2021 by Hisim 
 *All rights reserved. 
 *FileName:     FreezeState.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-02-25 07:29:22 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KayakSystem
{
    public class FreezeState : StateBase
    {
        public FreezeState(FSMManager fsm) : base(fsm)
        {
            stateID = StateID.FreezeState;
        }

        public override void BeforeEnter()
        {
            base.BeforeEnter();
            GameRoot.Instance.GlobalCanvas.SetFreezePanel(true);
            Time.timeScale = 0;
        }

        public override void BeforeLeave()
        {
            base.BeforeLeave();
            GameRoot.Instance.GlobalCanvas.SetFreezePanel(false);
            Time.timeScale = 1;
        }

        public override void FixedUpdate(FSMData kayakData)
        {
            
        }

        public override void Act(FSMData kayakData)
        {
            Debug.Log($"{this.GetType() } -> Act()");
            
            UpdateSendData();
            //skeletonCanvas.UpdatePlayerInfoDate(characterData);
            UpdateSceneState( kayakData);
        }

        public override void Reason(FSMData kayakData)
        {
            if (kayakData.receiveData.isFreeze == 0)
            {
                fsm.UpdateStateByTransition(Transition.PressDefreeze);
            }

            if (kayakData.receiveData.isReset == 1)
            {
                fsm.UpdateStateByTransition(Transition.PressReset);
            }
        }

        

        private void UpdateSendData()
        {
            
        }
        
        
    }
}