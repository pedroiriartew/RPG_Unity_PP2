using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporaryItem : BaseItem
{
    Dictionary<BaseItem, float> timer = new Dictionary<BaseItem, float>();
    public override void ItemUse()
    {
        /*
        Script_ItemPrefab itemActor
        itemActor.SetItem(this);
        */
    }

}
