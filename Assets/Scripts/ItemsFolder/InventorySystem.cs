﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem
{
    private BaseItem[] playerBag = new BaseItem[10];
    private BaseItem[] playerEquipment = new BaseItem[3];

    private int amountOfItemsInBag = 0;

    public event Action AddedRemovedItem;

    public enum EquipableSlot
    {
        chest = 0,
        ring,
        artifact
    }

    public void UseObject()
    {
        //Ponele que en algún momento haga algo con esto
    }

    public bool AddToInventory(BaseItem item)
    {
        for (int i = 0; i < playerBag.Length; i++)
        {
            if (playerBag[i] == null)
            {
                playerBag[i] = item;

                amountOfItemsInBag++;

                AddedRemovedItem?.Invoke();//Si mi evento AddedItem no es nulo, lo invoco

                return true;
            }
        }
        //Acá llamar a un UI que muestre alertas y cosas?

        Debug.Log("No tienes más espacio en el inventario para agregar este objeto.");
        return false;
    }

    public void RemoveFromInventory(BaseItem item)
    {
        amountOfItemsInBag--;

        for (int i = 0; i < playerBag.Length; i++)
        {
            if (playerBag[i] == item)
            {
                playerBag[i] = null;

                return;
            }
        }
    }

    public BaseItem GetItem(int itemIndex)
    {
        return playerBag[itemIndex];
    }

    public int GetAmountOfItemsInInventory()
    {
        return amountOfItemsInBag;
    }

    /*
     * BaseItem
     Porque si yo quiero que me de vida tiene que ser una ona 10life, 0de, 0de, 0de.
     */

    /*
     Como método virtual va ser la manera de usarse el objeto.
    Los temporales tienen un timer, el consumible se activa al toque y el equipable se agrega al inventario o algo así 
    Miscelaneos son items de misiones o etc.
     */

    /*
       El inventario va a tener todos Base Item y después internamente elige a traves de la sobrecarga de la herencia, cual es el método que tiene que utilizar.
     
    */

    /*
       Hay dos Arrays Equipables y desequipables y luego otro para le resto de los items. Mochila y lo equipado.

       Para los items equipables podemos tener un enumerador que se fija en que slot debería ir.
     
       El PlayerCharacter tiene un objeto inventario. Ya sea una clase que luego se ve en un UI o que se yo, dijo algo más.
     
     */

    /*
     *  Representación visual. Cuando lo selecciono llamo a su propio Use. 
     *  
     *
    */
}
