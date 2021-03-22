/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     SimhostStateData.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-17 04:05:05 
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
    /// Simhost状态更新数据
    /// </summary>
    [System.Serializable]
    public class SimhostStateData : IStateData
    {
        /// <summary>
        /// 用户
        /// </summary>
        public GameObject player;
        /// <summary>
        /// 是否按下解冻
        /// </summary>
        public bool isPressDefreeze;
        /// <summary>
        /// 是否按下冻结
        /// </summary>
        public bool isPressfreeze;
        /// <summary>
        /// 是否按下重置
        /// </summary>
        public bool isPressReset;


        public SimhostStateData(string name, GameObject player, bool isPressDefreeze, bool isPressfreeze, bool isPressReset) : base(name)
        {
            this.player = player;
            this.isPressDefreeze = isPressDefreeze;
            this.isPressfreeze = isPressfreeze;
            this.isPressReset = isPressReset;
        }
    }
}