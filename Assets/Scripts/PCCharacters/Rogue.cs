using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Rogue : PlayableCharacter
{
    public Rogue()
    {
        myStats.life = 100;
        myStats.lifeCap = 100;
        myStats.dmg = 75;
        myStats.speed = 2f;
        myStats.range = 25f;
        inventory = new InventorySystem();
        className = "Rogue";
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
