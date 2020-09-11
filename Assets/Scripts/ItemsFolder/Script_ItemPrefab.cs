using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class Script_ItemPrefab : Interactable
{
    private BaseItem item = null;

    [SerializeField]
    protected Sprite icon;

    //ESTO ES RE CONTRA PLACEHOLDER
    [SerializeField]
    private string itemType = "";


    //Totalmente placeholder hasta que cree un factory de items
    private void Start()
    {
        if (item == null)
        {
            if (itemType == "Equipable")
            {
                item = new EquipableItem();
            }
            if (itemType == "Consumable")
            {
                item = new ConsumableItem();
            }
            if (itemType == "Temporary")
            {
                item = new TemporaryItem();
            }
        }

        //Esto también es placeHolder
        item.SetIcon(icon);

        //Si no entra debería explotar o algo así porque quedaría como null el base item
    }

    public override void Interact()
    {
        base.Interact();

        //Acá tendría que desactivarlo o destruirlo
        gameObject.SetActive(false);
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
