/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     CharacterFactory2.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-19 02:15:18 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactorySystem.Character
{
    public class CharacterFactory2 : ICharacterFactory
    {
        public ICharacter CreateCharacter()
        {
            GameObject g = AssetSystem.AssetManager.Instance.ResourcesAssetLoad.LoatAsset("Player2");
            GameObject go = GameObject.Instantiate(g);
            Player2 character = go.GetComponent<Player2>();
            if (character == null)
            {
                character = go.AddComponent<Player2>();
            }
            character.InitCharacter();
            return character;
        }

        public IMonster CreateMonster()
        {
            GameObject g = AssetSystem.AssetManager.Instance.ResourcesAssetLoad.LoatAsset("Monster2");
            GameObject go = GameObject.Instantiate(g);
            Monster2 character = go.GetComponent<Monster2>();
            if (character == null)
            {
                character = go.AddComponent<Monster2>();
            }
            character.InitMonster();
            return character;
        }

        public INPC CreateNPC()
        {
            GameObject g = AssetSystem.AssetManager.Instance.ResourcesAssetLoad.LoatAsset("NPC2");
            GameObject go = GameObject.Instantiate(g);
            NPC2 character = go.GetComponent<NPC2>();
            if (character == null)
            {
                character = go.AddComponent<NPC2>();
            }
            character.InitNPC();
            return character;
        }
    }
}