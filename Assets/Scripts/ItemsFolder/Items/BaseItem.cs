using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public abstract class BaseItem
{
    /// <summary>
    /// Clase abstracta que genera los distintos items consumibles, temporales y equipados.
    /// </summary>

    protected Sprite icon = null;

    protected BaseCharacter.Stats itemStats;

    protected string name;

    public BaseCharacter.Stats GetStats()
    {
        return itemStats;
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
