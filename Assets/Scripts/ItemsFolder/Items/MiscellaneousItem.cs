﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiscellaneousItem : BaseItem
{
    public MiscellaneousItem()
    {
        itemType = ItemType.Miscellaneous;
    }

    public override void ItemUse(PlayableCharacter character)
    {
        throw new System.NotImplementedException();
    }

    //Calculo que el item use va a ser una leve descripción del objeto
}
