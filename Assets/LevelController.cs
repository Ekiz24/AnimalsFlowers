using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public TextMeshProUGUI currentItemToPick;
    public ItemHolder currentItem;
    public ItemHolder[] items;
    public GameObject winPanel;
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
}
