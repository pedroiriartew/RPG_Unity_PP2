using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Esta clase es la base de todos los personajes, tanto jugador como enemigos.

public abstract class BaseCharacter
{
    public struct Stats
    {
        public float dmg;
        public float life;
        public float lifeCap;
        public float speed;
        public float range;
    }

    protected Stats myStats;

    /*
    [SerializeField]
    protected string name = " "; No recuerdo bien por que puse esto pero me tira una advertencia así que lo comento.   */

    public void ReceiveDmg(float damageReceived)
    {
        myStats.life -= damageReceived;

        Debug.Log("Recibiste dmg. Tenés " + myStats.life);

        if (myStats.life <= 0)
        {
            Die();
        }
    }

    public abstract void Die();

    /*
        Los jugadores atacan, utilizan objetos e interactuan con NPCs. 
        Los NPCs otorgan misiones y hablan con los jugadores.
        Los enemigos atacan al jugador.
    */
    public abstract void Action();
    public abstract void Move();

    public float GetSpeed() { return myStats.speed;}
    public float GetDamage() { return myStats.dmg; }
    public float GetLife() { return myStats.life; }
    public float GetCap() { return myStats.lifeCap; }
    public float GetRange() { return myStats.range; }


}
