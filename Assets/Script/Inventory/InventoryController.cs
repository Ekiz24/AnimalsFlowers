using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public LevelController levelController;
    public PlayerControl player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        ItemHolder item = other.GetComponent<ItemHolder>();
        if (item != null)
        {
            if (levelController.currentItem.thisItem.item == item.thisItem.item)
            {
                JSONSaving.instance.AddItem(item.thisItem.item);
                other.gameObject.SetActive(false);
                levelController.SetCurrentItemRandomly();
            }
            else
            {
                player.PlayerDamage();
                levelController.LevelFailed();
            }
            
        }
    }
}
