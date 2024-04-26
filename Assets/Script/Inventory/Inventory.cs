using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Inventory
{
    public InventoryItem item;
    public int count;

    public Inventory(InventoryItem item, int count)
    {
        this.item = item;
        this.count = count;
    }

    public override string ToString()
    {
        return $"{item} are {count} ";
    }
}
