using UnityEngine;
using System;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ItemsSpriteScriptableObject", order = 1)]
public class ItemsSpriteScriptableObject : ScriptableObject
{
    public List<ItemSprites> items;
   public Sprite GetItemSprite(InventoryItems item)
    {
        foreach (var currentItem in items)
        {
            if (currentItem.item == item)
                return currentItem.itemsSprite;
        }
        return items[items.Count-1].itemsSprite ;
    }
}
[Serializable]
public class ItemSprites 
{
    public InventoryItems item;
    public Sprite itemsSprite;
}
