using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sorcerer : PlayableCharacter
{
    public Sorcerer()
    {
        myStats.life = 75;
        myStats.lifeCap = 75;
        myStats.dmg = 100;
        myStats.speed = 1.5f;
        myStats.range = 15f;
        inventory = new InventorySystem();
        className = "Sorcerer";
    }

    public override void SpecialAbility()
    {
        //ni idea
    }

    public override void Action()
    {
        //Acá vendría la mecánica principal de atacar.
    }
    public override void Move()
    {

    }
}
