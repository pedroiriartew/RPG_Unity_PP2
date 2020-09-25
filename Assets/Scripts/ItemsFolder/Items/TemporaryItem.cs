using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporaryItem : BaseItem
{
    private float timer = 60f;

    public TemporaryItem()
    {
        itemType = ItemType.Temporary;
    }

    public override void ItemUse(PlayableCharacter character)
    {
        character.SetStats(itemStats);



    }

}
