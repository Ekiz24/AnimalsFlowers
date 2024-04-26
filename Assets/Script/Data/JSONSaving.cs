using System.IO;
using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json;
public class JSONSaving : MonoBehaviour
{
    private Inventory inventoryData;
    public Dictionary<InventoryItem, int> playerInventoryItems;
    private string path = "";
    private string persistentPath = "";

    // Start is called before the first frame update
    void Start()
    {
        CreatePlayerData();
        SetPaths();
    }

    private void CreatePlayerData()
    {
        inventoryData = new Inventory(InventoryItem.Cat,2);
        playerInventoryItems = new Dictionary<InventoryItem, int>();
        playerInventoryItems[InventoryItem.Cat] = 2;
    }

    private void SetPaths()
    {
        path = Application.dataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
        persistentPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            SaveData();

        if (Input.GetKeyDown(KeyCode.L))
            LoadData();
    }

    public void SaveData()
    {
        string savePath = persistentPath;

        Debug.Log("Saving Data at " + savePath);
        string json = JsonUtility.ToJson(playerInventoryItems);
        string jsonOutput = JsonConvert.SerializeObject(playerInventoryItems);
        Debug.Log(jsonOutput);

        using StreamWriter writer = new StreamWriter(savePath);
        writer.Write(jsonOutput);
    }

    public void LoadData()
    {
        using StreamReader reader = new StreamReader(persistentPath);
        string json = reader.ReadToEnd();

        Inventory data = JsonUtility.FromJson<Inventory>(json);
        Debug.Log(data.ToString());
        Dictionary<InventoryItem, int> dataT = JsonConvert.DeserializeObject<Dictionary<InventoryItem, int>>(json);
        Debug.Log(dataT.Count);
    }
}