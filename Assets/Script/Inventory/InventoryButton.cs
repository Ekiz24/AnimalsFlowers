using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InventoryButton : MonoBehaviour
{
    public Inventory inventoryItem;
    public TextMeshProUGUI itemCountTxt;
    public TextMeshProUGUI itemDescriptionTxt;
    public TextMeshProUGUI itemNameTxt;
    public Image itemImg;
    public Image itemIconImg;

    public ItemsSpriteScriptableObject itemsSpriteScriptableObject;
    public void Start()
    {
        itemIconImg = GetComponent<Image>();
        itemCountTxt = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        itemIconImg.sprite = itemsSpriteScriptableObject.GetItemSprite(inventoryItem.item);
    }
    public void OnClickItem()
    {
        itemNameTxt.text = inventoryItem.item.ToString();
        itemImg.sprite = itemIconImg.sprite;
    }
}
