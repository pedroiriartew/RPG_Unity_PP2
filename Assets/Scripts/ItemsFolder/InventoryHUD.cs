using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class InventoryHUD : MonoBehaviour
{
    [SerializeField]
    private PlayerActor player;

    [SerializeField]
    private Transform playerBag;

    private SlotScript[] slots;
    private InventorySystem playerInventory = null;

    [SerializeField]
    private GameObject inventoryUI;

    private void Awake()
    {
        FindObjectOfType<PlayerActor>().OpenCloseInventory += OpenCloseInventory;
    }
    void Start()
    {
        playerInventory = player.GetCharacter().GetInventory();
        playerInventory.AddedRemovedItem += UpdateUI;//Agrego mi set de instrucciones a UpdateUI

        slots = playerBag.GetComponentsInChildren<SlotScript>();
    }

    public void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < playerInventory.GetAmountOfItemsInInventory())
            {
                slots[i].AddItemToSlot(playerInventory.GetItem(i));
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }

    public void OpenCloseInventory()
    {
        inventoryUI.SetActive(!inventoryUI.activeSelf);
    }
}
