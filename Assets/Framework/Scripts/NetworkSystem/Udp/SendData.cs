using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;


namespace NetworkSystem.UDP
{
    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [System.Serializable]
    public struct SendData
    {
        [SerializeField] public float posX;
        [SerializeField] public float posY;
        [SerializeField] public float posZ;
        [Header("俯仰角")] [SerializeField] public float rotX;
        [Header("偏航角")] [SerializeField] public float rotY;
        [Header("滚转角")] [SerializeField] public float rotZ;
        [Header("速度")] [SerializeField] public float speed;
        [Header("是否开始运行 (倒计时之后)")] [SerializeField] public int isStartRunning;
        [Header("使用时间")] [SerializeField] public float totalTime;
        [Header("总路程")] [SerializeField] public float totalDistance;
        [Header("是否游戏结束")] [SerializeField] public int isGameOver;
        [Header("是否撞墙")] [SerializeField] public int isCollisionWall;
    }
}