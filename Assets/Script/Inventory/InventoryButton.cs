using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Class to handle inventory button UI interactions
public class InventoryButton : MonoBehaviour
{
    // References to inventory item and UI elements
    public Inventory inventoryItem;
    public TextMeshProUGUI itemCountTxt;
    public TextMeshProUGUI itemDescriptionTxt;
    public TextMeshProUGUI itemNameTxt;
    public Image itemImg;
    public Image itemIconImg;

    // Reference to scriptable object that holds item sprites and descriptions
    public ItemsSpriteScriptableObject itemsSpriteScriptableObject;
 
    public void Awake()
    {
        itemIconImg = GetComponent<Image>(); // Get the Image component attached to this GameObject
        itemIconImg.sprite = itemsSpriteScriptableObject.GetItemSprite(inventoryItem.item); // Set the icon sprite based on the inventory item
    }

    // OnEnable is called when the object becomes enabled and active
    private void OnEnable()
    {
        GetItemCount();  // Update the item count when the object is enabled
    }
    public void OnClickItem()
    {
        itemNameTxt.text = inventoryItem.item.ToString();
        itemImg.sprite = itemIconImg.sprite;
        itemDescriptionTxt.text = itemsSpriteScriptableObject.GetItemDescription(inventoryItem.item);
    }

    // Method to get the item count from JSONSaving and update the UI
    private void GetItemCount()
    {
        itemCountTxt.text = JSONSaving.instance.GetCountOfItem(inventoryItem.item).ToString();
    }
}
