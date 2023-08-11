using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : ICharacter
{
    public static PlayerData instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        Setup();
    }
    public Type_Character type = Type_Character.Warrior;
    public override void OnDead()
    {
        base.OnDead();

    }
    public override void Setup()
    {
        base.Setup();
        //Hp+= currentLevel*2 + item[id].Hp;
    }
    public override void OnTakenDamage(int amount)
    {
        base.OnTakenDamage(amount);
        if (Hp <= 0)
        {
            //Play anim die
            GameManager.instance.GameLose();
        }
    }
}

