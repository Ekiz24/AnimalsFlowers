using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public TextMeshProUGUI currentItemToPick;
    public TextMeshProUGUI playerLives;
    public ItemHolder currentItem;
    public ItemHolder[] items;
    public GameObject winPanel;
    public GameObject loosePanel;
    public PlayerControl player;
    int totalCollectedCount;
    private void Start()
    {
        SetCurrentItemRandomly();
    }
    public void SetCurrentItemRandomly()
    {
        int selectedItem = Random.Range(0, items.Length);
        if (items[selectedItem].gameObject.activeInHierarchy)
        {
            currentItem = items[selectedItem];
            currentItemToPick.text = items[selectedItem].thisItem.item.ToString();
            totalCollectedCount++;
        }
        else
        {
            if (totalCollectedCount == items.Length)
            {
                winPanel.SetActive(true);
                return;
            }
            SetCurrentItemRandomly();
        }
    }
    public void LevelFailed()
    {
        playerLives.text = "Lives " + player.GetPlayerLives();
        if (player.GetPlayerLives()<=0)
        {
            loosePanel.SetActive(true);
        }
    }
}
