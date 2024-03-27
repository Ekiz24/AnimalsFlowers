using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public Dictionary<InventoryItem, int> playerInventoryItems;
    private void Awake()
    {
        playerInventoryItems = new Dictionary<InventoryItem, int>();
    }
}
