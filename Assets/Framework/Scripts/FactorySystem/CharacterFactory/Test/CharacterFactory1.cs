/********************************************
 *Copyright(C) 2021 by DefaultCompany 
 *All rights reserved. 
 *FileName:     CharacterFactory1.cs 
 *Author:       FuQiangJun 
 *Version:      1.0 
 *UnityVersion：2018.3.4f1 
 *Date:         2021-02-19 02:15:08 
 *Email:        17611473176@163.com 
 *Description:  
 *History: 
*******************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FactorySystem.Character
{
    public class CharacterFactory1 : ICharacterFactory
    {
        public ICharacter CreateCharacter()
        {
            GameObject g = AssetSystem.AssetManager.Instance.ResourcesAssetLoad.LoatAsset("Player1");
            GameObject go = GameObject.Instantiate(g);
            Player1 character = go.GetComponent<Player1>();
            if (character == null)
            {
                character = go.AddComponent<Player1>();
            }
            character.InitCharacter();
            return character;
        }

        public IMonster CreateMonster()
        {
            GameObject g = AssetSystem.AssetManager.Instance.ResourcesAssetLoad.LoatAsset("Monster1");
            GameObject go = GameObject.Instantiate(g);
            Monster1 character = go.GetComponent<Monster1>();
            if (character == null)
            {
                character = go.AddComponent<Monster1>();
            }
            character.InitMonster();
            return character;
        }

        public INPC CreateNPC()
        {
            GameObject g = AssetSystem.AssetManager.Instance.ResourcesAssetLoad.LoatAsset("NPC1");
            GameObject go = GameObject.Instantiate(g);
            NPC1 character = go.GetComponent<NPC1>();
            if (character == null)
            {
                character = go.AddComponent<NPC1>();
            }
            character.InitNPC();
            return character;
        }
    }
}