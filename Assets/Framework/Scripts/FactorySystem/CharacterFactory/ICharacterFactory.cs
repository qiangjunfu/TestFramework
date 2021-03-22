/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     CharacterFactory.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-19 10:25:45 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using AssetSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FactorySystem.Character
{
    /// <summary>
    /// 抽象角色工厂
    /// </summary>
    public interface  ICharacterFactory
    {
        ICharacter CreateCharacter();
        INPC CreateNPC();
        IMonster CreateMonster();
    }
}