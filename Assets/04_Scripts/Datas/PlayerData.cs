using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : ICharacter
{
    public float range;
    public FOV fov;

    public Type_Character type = Type_Character.Warrior;
    public override void OnDead()
    {
        base.OnDead();
    }
    public override void Setup()
    {
        base.Setup();
        //hp = level *2 + base
        Hp += DataManager.Instance.userData.CurrentLevel * 2;
        Defend += DataManager.Instance.userData.CurrentLevel * 2;
        Damage += DataManager.Instance.userData.CurrentLevel * 2;
        LuckyRate += DataManager.Instance.userData.CurrentLevel * 2;
        //fov.SetupRange(range);
        //Hp+= currentLevel*2 + item[id].Hp;
    }
    public override void OnTakenDamage(int amount)
    {
        base.OnTakenDamage(amount);
        if (Hp <= 0)
        {
            //Play anim die
            GameManager.Instance.GameLose();
        }
    }
}

