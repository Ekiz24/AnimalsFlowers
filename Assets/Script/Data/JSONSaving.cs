using System.IO;
using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;

// Singleton class to handle JSON saving and loading of player inventory data
public class JSONSaving : Singleton<JSONSaving>
{
    // Dictionary to store player inventory items and their counts
    private Dictionary<InventoryItem, int> playerInventoryItems;

    // Paths for saving data
    private string path = "";
    private string persistentPath = "";

    // Override Awake to call base Awake and set file paths
    protected override void Awake()
    {
        base.Awake();
        SetPaths();
    }
    // Start is called before the first frame update
    private void Start()
    {
        LoadData(); // Load data when the game starts
    }

    // Get the count of a specific item in the inventory
    public int GetCountOfItem(InventoryItem item)
    {
        if(playerInventoryItems.ContainsKey(item))
            return playerInventoryItems[item];
        return 0;
    }

    // Initialize the player inventory data
    private void CreatePlayerData()
    {
        playerInventoryItems = new Dictionary<InventoryItem, int>();
        
    }

    // Add an item to the inventory
    public void AddItem(InventoryItem item)
    {
      if (playerInventoryItems.ContainsKey(item))
        {
            playerInventoryItems[item] += 1;
        }
        else
        {
            playerInventoryItems[item] = 1;
        }
        SaveData();
    }

    // Reset the inventory counts to 0
    public void Reset()
    {
        var valuesAsArray = Enum.GetValues(typeof(InventoryItem));
        foreach (InventoryItem item in valuesAsArray)
        {
            playerInventoryItems[item] = 0;
        }
      //  SaveData();
    }

    // Set the paths for saving and loading data
    private void SetPaths()
    {
        path = Application.dataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
        persistentPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
    }

    // Save the inventory data to a JSON file
    public void SaveData()
    {
        string savePath = persistentPath;
        Debug.Log("Saving Data at " + savePath);
        string jsonOutput = JsonConvert.SerializeObject(playerInventoryItems);
        Debug.Log(jsonOutput);
        using StreamWriter writer = new StreamWriter(savePath);
        writer.Write(jsonOutput);
    }

    // Load the inventory data from a JSON file
    public void LoadData()
    {
        using StreamReader reader = new StreamReader(persistentPath);
        string json = reader.ReadToEnd();
        CreatePlayerData();
        playerInventoryItems = JsonConvert.DeserializeObject<Dictionary<InventoryItem, int>>(json);
        Reset();
        Debug.Log(playerInventoryItems.Count);
    }
}