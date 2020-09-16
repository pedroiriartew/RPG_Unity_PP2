using UnityEngine;
using UnityEngine.UI;

public class SlotScript : MonoBehaviour
{
    private BaseItem item = null;

    [SerializeField]
    private Image icon;

    [SerializeField]
    private Button removeButton;

    private PlayableCharacter character = null;

    private void Start()
    {
        character = FindObjectOfType<PlayerActor>().GetCharacter();
    }

    private void Update()
    {
        
    }

    public void AddItemToSlot(BaseItem newItem)
    {
        item = newItem;

        icon.sprite = item.GetIcon();
        icon.enabled = true;

        removeButton.interactable = true;
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;

        removeButton.interactable = false;
    }

    public void UseItem()
    {
        if (item !=null)
        {
            item.ItemUse(character);

            character.AddStatsFromEquipment();//Eso lo tengo que arreglar, pero que se yo, todavía no se me ocurre como
        }
        else
        {
            Debug.Log("Algo salío muy mal, este item está vacío");
        }
    }

    public void RemoveItem()
    {
        InventorySystem inventory = FindObjectOfType<PlayerActor>().GetCharacter().GetInventory();

        inventory.RemoveFromInventory(item);

        ClearSlot();
    }
}
