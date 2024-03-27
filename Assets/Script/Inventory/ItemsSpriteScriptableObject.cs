using UnityEngine;
using System;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ItemsSpriteScriptableObject", order = 1)]
public class ItemsSpriteScriptableObject : ScriptableObject
{
    public List<ItemSprites> items;
   public Sprite GetItemSprite(InventoryItem item)
    {
        foreach (var currentItem in items)
        {
            if (currentItem.item == item)
                return currentItem.itemsSprite;
        }
        return items[items.Count-1].itemsSprite ;
    }
    public string GetItemDescription(InventoryItem item)
    {
        foreach (var currentItem in items)
        {
            if (currentItem.item == item)
                return currentItem.itemDescription;
        }
        return items[items.Count - 1].itemDescription;
    }
}
[Serializable]
public class ItemSprites 
{
    public InventoryItem item;
    public Sprite itemsSprite;
    public string itemName;
    public string itemDescription;
    public int count;
}
