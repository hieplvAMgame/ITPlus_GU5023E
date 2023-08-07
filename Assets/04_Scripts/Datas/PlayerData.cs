using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : ICharacter
{
    public Type_Character type = Type_Character.Warrior;
    private void Awake()
    {
        Setup();
    }
    public override void OnDead()
    {
        base.OnDead();

    }
    public override void Setup()
    {
        base.Setup();
        //Hp+= currentLevel*2 + item[id].Hp;
    }
}
public enum Type_Character
{
    Warrior,
    Mage,
    Orge,
    Dracula
}
