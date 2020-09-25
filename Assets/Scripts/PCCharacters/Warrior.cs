using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Warrior : PlayableCharacter
{

    public Warrior()
    {
        myStats.life = 50f;
        myStats.lifeCap = 50f;
        myStats.dmg = 150f;
        myStats.speed = 1.2f;
        myStats.range = 10f;
        inventory = new InventorySystem();
        className = "Warrior";
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
