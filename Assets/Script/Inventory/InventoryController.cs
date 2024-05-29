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
        // Get the ItemHolder component from the colliding object
        ItemHolder item = other.GetComponent<ItemHolder>();
       
        // Check if the colliding object has an ItemHolder component
        if (item != null)
        {
            // Check if the item matches the current level item
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
