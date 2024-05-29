using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class to handle inventory-related interactions in the game
public class InventoryController : MonoBehaviour
{
    // References to the level controller and player control scripts
    public LevelController levelController;
    public PlayerControl player;

    // Method called when another collider enters the trigger collider attached to this GameObject
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
