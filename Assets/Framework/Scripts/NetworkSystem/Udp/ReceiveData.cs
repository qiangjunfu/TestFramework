using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;


namespace NetworkSystem.UDP
{
    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [System.Serializable]
    public struct ReceiveData
    { /// <summary>
      /// id编号
      /// </summary>
        public int id;
        /// <summary>
        /// 场景类型  0:默认场景  1:  2:
        /// </summary>
        public int sceneType;
        /// <summary>
        /// 科目类型
        /// </summary>
        public int subjectType;
        /// <summary>
        /// 当前速度  (km/h)
        /// </summary>
        public float speed;
        /// <summary>
        /// 滑雪机横向偏移量 (-2 - 2)
        /// </summary>
        public float offset;
        /// <summary>
        /// 偏移倍数  (0 - 10)
        /// </summary>
        public float offsetMultiple;
        /// <summary>
        /// 是否显示UI界面
        /// </summary>
        public int isShowUI;
        /// <summary>
        /// 是否冻结  0:解冻 1:冻结
        /// </summary>
        public int isFreeze;
        /// <summary>
        /// 是否重置  0:不重置 1:重置
        /// </summary>
        public int isReset;
        
        public float eyePosY;
        public float eyeRotX;
        public float eyeRotY;
        public float eyeRotZ;
    }
}