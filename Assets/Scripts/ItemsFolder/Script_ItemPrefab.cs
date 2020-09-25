using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class Script_ItemPrefab : Interactable
{
    private BaseItem item = null;

    public override void Interact()
    {
        base.Interact();

        //Acá tendría que desactivarlo o destruirlo
        gameObject.SetActive(false);
    }

    public void Initialize(BaseItem baseItem)
    {
        item = baseItem;

        //Acá tendríamos que hacer todo lo que sería label del nombre,
        // sprite, etc.
    }

    public BaseItem GetItem()
    {
        return item;
    }

    public override bool IsItem()
    {
        return true;
    }

    public void SetItem(BaseItem newItem)
    {
        item = newItem;
    }

    public void Update()
    {

    }
}
