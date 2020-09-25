using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField]
    private Script_ItemPrefab itemPrefab;
    //private BaseItem.ItemType itemType;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            CreateItem();
        }
    }

    public void CreateItem()
    {
        //Script_ItemPrefab itemActor = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);

        //BaseItem loadedItem;
        LoadDataByID(0);

        //itemActor.Initialize(loadedItem);
    }

    public BaseItem LoadDataByID(int id)
    {
        BaseItem loadedItem;
        string jsonLoadItemData = File.ReadAllText(Application.dataPath + "/items.json");
        SimpleJSON.JSONNode data = SimpleJSON.JSON.Parse(jsonLoadItemData);

        for (int i = 0; i < data["itemList"].AsArray.Count; i++)
        {
            if(data["itemList"].AsArray[i]["itemID"]==id)
            {
               string itemType = data["itemList"].AsArray[i]["itemType"];
               BaseItem.ItemType type = (BaseItem.ItemType)int.Parse(itemType);//hypercast

                loadedItem = CreateItemByType(type);

                string statsString = data["itemList"].AsArray[i]["itemStats"];
                BaseCharacter.Stats newStats = (BaseCharacter.Stats)statsString ;
                loadedItem.SetStats(newStats);
            }
        }   

        //List<BaseItem> itemList = new List<BaseItem>();

        //for (int i = 0; i < data.Children.Count(); i++)
        //{

        //}

        //string itemTypeData = data["itemType"].Value;//Como si fuera un diccionario

        //BaseItem.ItemType type = (BaseItem.ItemType)int.Parse(itemTypeData);//hypercast

        //BaseItem loadedItem = CreateItemByType(type, jsonLoadItemData);

        return loadedItem;
    }

    private BaseItem CreateItemByType(BaseItem.ItemType itemtype)
    {
        switch (itemtype)
        {
            case BaseItem.ItemType.Temporary:
                return new TemporaryItem();
            case BaseItem.ItemType.Equipable:
                return new EquipableItem();
            case BaseItem.ItemType.Consumable:
                return new ConsumableItem();
            case BaseItem.ItemType.Miscellaneous:
                return new MiscellaneousItem();
            default:
                return new ConsumableItem();
        }
    }

    //BaseItem myItemData = new ConsumableItem();

    //string jsonSaveItemData = JsonUtility.ToJson(myItemData);

    //Debug.Log(jsonSaveItemData);

    //File.WriteAllText(Application.dataPath + "/items.json", jsonSaveItemData);
}
