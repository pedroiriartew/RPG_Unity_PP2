using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumableItem : BaseItem
{
    public ConsumableItem()
    {
        itemType = ItemType.Consumable;
    }

    
    public override void ItemUse(PlayableCharacter character)
    {
        character.SetStats(itemStats);
    }

    /*
     * Agarro los stats de este item
     * 
     */
}
