using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ItemCollection
{
    [SerializeField]
    private BaseItem[] itemList;
}

[System.Serializable]
public abstract class BaseItem
{
    /// <summary>
    /// Clase abstracta que genera los distintos items consumibles, temporales y equipados.
    /// </summary>
    [System.Serializable]
    public enum ItemType
    {
        Temporary = 1,
        Equipable = 2,
        Consumable = 3,
        Miscellaneous = 4
    }

    [SerializeField]
    protected int itemID;

    [SerializeField]
    protected Sprite icon = null;

    [SerializeField]
    protected BaseCharacter.Stats itemStats;

    [SerializeField]
    protected string name;

    [SerializeField]
    protected ItemType itemType;

    public BaseCharacter.Stats GetStats()
    {
        return itemStats;
    }

    public void SetStats(BaseCharacter.Stats newStats)
    {
        itemStats = newStats;
    }

    public abstract void ItemUse(PlayableCharacter character);

    public string GetName()
    {
        return name;
    }

    public Sprite GetIcon()
    {
        return icon;
    }

    public void SetIcon(Sprite newIcon)
    {
        icon = newIcon;
    }
}
