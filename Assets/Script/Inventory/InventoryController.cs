using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        ItemHolder item = other.GetComponent<ItemHolder>();
        if (item != null)
        {
            JSONSaving.instance.AddItem(item.thisItem.item);
            other.gameObject.SetActive(false);
            
        }
    }
}
