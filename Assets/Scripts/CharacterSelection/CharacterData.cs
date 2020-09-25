using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterData
{
    [SerializeField]
    private string characterClass;

    [SerializeField]
    private BaseCharacter.Stats characterStats;

    [SerializeField]
    private InventorySystem characterInventory;

    public void SetData(BaseCharacter.Stats newStats, InventorySystem newInventory, string newCharacterClass)
    {
        characterStats = newStats;
        characterInventory = newInventory;
        characterClass = newCharacterClass;
    }

    public BaseCharacter.Stats GetDataStats()
    {
        return characterStats;
    }

    public InventorySystem GetDataInventory()
    {
        return characterInventory;
    }

    public string GetDataCharacterClass()
    {
        return characterClass;
    }
}