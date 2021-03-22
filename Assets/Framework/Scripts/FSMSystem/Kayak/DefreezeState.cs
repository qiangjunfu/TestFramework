/********************************************
 *Copyright(C) 2021 by Hisim 
 *All rights reserved. 
 *FileName:     DefreezeState.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion: 2018.3.4f1 
 *Date:         2021-02-25 07:24:51 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KayakSystem
{
    public class DefreezeState : StateBase
    {
        private Rigidbody rig;
        private Transform eye;


        public DefreezeState(FSMManager fsm) : base(fsm)
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

        public override void FixedUpdate(FSMData kayakData)
        {
            //if (rig == null)
            //{
            //    rig = kayakData.gameObject.GetComponent<Rigidbody>();
            //    eye = kayakData.gameObject.transform.Find("Eye");
            //}

            //UpdateRigibodyData(kayakData);
            //if (GameRoot .Instance .UdpManager .IsConnect )
            //{
            //    MotionMove();
            //}
            //else
            //{
            //    FreeMove();
            //}
            //kayakData.gameObject.transform.Translate(Vector3.forward * 5 * Time.deltaTime);

        }

        public override void Act(FSMData kayakData)
        {
            //Debug.Log($"{this.GetType() } -> Act()");


            ////KayakSlalomScene.KayakSlalomCtrl.Instance.KayakSlalomCanvas.UpdatePlayerInfo();
            //UpdateSendData();
            //UpdateSceneState(kayakData);
        }

        public override void Reason(FSMData kayakData)
        {
            //if (kayakData.receiveData.isFreeze == 1)
            //{
            //    fsm.UpdateStateByTransition(Transition.PressFreeze);
            //}

            //if (kayakData.receiveData.isReset == 1)
            //{
            //    fsm.UpdateStateByTransition(Transition.PressReset);
            //}
        }


        #region 
        private void UpdateRigibodyData(FSMData kayakData)
        {
            //rig.mass = kayakData.receiveData.mass;
            //rig.drag = kayakData.receiveData.drag;
            //rig.angularDrag = kayakData.receiveData.angularDrag;
            eye.transform.SetLocalPosY(kayakData.receiveData.eyePosY);
            eye.transform.SetLocalRotXYZ(kayakData.receiveData.eyeRotX, kayakData.receiveData.eyeRotY, kayakData.receiveData.eyeRotZ);
        }

        private void UpdateSendData()
        {
            //GameRoot .Instance .UdpManager .SendData = 
        }

        /// <summary>
        /// 通过simhost运动
        /// </summary>
        private void MotionMove()
        {

        }

        /// <summary>
        /// 没连接host自由移动
        /// </summary>
        private void FreeMove()
        {

        }
        #endregion
    }
}