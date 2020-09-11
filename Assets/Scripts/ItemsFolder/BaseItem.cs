using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseItem
{
    /// <summary>
    /// Clase abstracta que genera los distintos items consumibles, temporales y equipados.
    /// </summary>

    public struct Stats
    {
        public float dmg;
        public float life;
        public float lifeCap;
        public float speed;
        public float range;
    }
    protected Sprite icon = null;

    protected Stats itemStats;

    protected string name;

    public abstract void ItemUse();

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
