using UnityEngine;
using System;
using System.Collections.Generic;

// Create a menu item for creating instances of this ScriptableObject
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ItemsSpriteScriptableObject", order = 1)]
public class ItemsSpriteScriptableObject : ScriptableObject
{
    // List to hold item data
    public List<ItemData> items;

    // Method to get the sprite associated with a given inventory item
    public Sprite GetItemSprite(InventoryItem item)
    {
        // Iterate through the list of items
        foreach (var currentItem in items)
        {
            // Return the sprite if the item matches
            if (currentItem.item == item)
                return currentItem.itemsSprite;
        }

        // Return the sprite of the last item in the list if no match is found
        return items[items.Count-1].itemsSprite ;
    }

    // Method to get the description associated with a given inventory item
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

// Serializable class to hold data for each item
[Serializable]
public class ItemData 
{
    public InventoryItem item;
    public Sprite itemsSprite;
    public string itemName;
    public string itemDescription;
    public int count;
}
