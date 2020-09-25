using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public abstract class PlayableCharacter : BaseCharacter
{
    [SerializeField]
    protected InventorySystem inventory = null;

    [SerializeField]
    protected string className;

    // Cada clase va a tener su propia habilidad especial.
    public virtual void SpecialAbility()
    {
        //Acá poner algún tipo de Cooldown para las habilidades
        //Es algo que comparten todas las clases
    }

    /* 
        Tanto interactuar como un npc como entrar se hacen con interact
        Quizás haya que cambiar el nombre
        Quizás no sirva una mierda esta idea
     */

    public void AddStatsFromEquipment()
    {
        BaseItem[] equipment = inventory.GetEquipment();

        for (int i = 0; i < equipment.Length; i++)
        {
            if (equipment[i] != null)
            {
                SetStats(equipment[i].GetStats());
            }
        }
    }

    public override void Die()
    {
        //Jajaj no se puede bro
        // Destroy(gameObject);
    }

    //No sé si lo voy a usar a esto todavía pero por si las dudas lo tengo creado 
    public void SetStats(Stats moreStats)
    {
        myStats.dmg += moreStats.dmg;

        myStats.life += moreStats.life;

        myStats.lifeCap += moreStats.lifeCap;

        myStats.range += moreStats.range;

        myStats.speed += moreStats.speed;
    }

    public void SetNewStats(Stats newStats)
    {
        myStats = newStats;
    }

    public Stats GetStats()
    {
        return myStats;
    }

    public InventorySystem GetInventory()
    {
        return inventory;
    }

    public void SetInventory(InventorySystem newInventory)
    {
        inventory = newInventory;
    }

    public string GetClassName()
    {
        return className;
    }
}
