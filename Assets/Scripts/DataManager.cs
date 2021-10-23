using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{

    public string playerName, highName;
    public int highScore;

    public static DataManager Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadColor();
    }

    [System.Serializable]
    class SaveData
    {
        public string playerName, highName;
        public int highScore;
    }

    public void SaveAll()
    {
        SaveData data = new SaveData();
        data.playerName = playerName;
        data.highName = highName;
        data.highScore = highScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/bricksavefile.json", json);
    }

    public void LoadColor()
    {
        string path = Application.persistentDataPath + "/bricksavefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerName = data.playerName;
            highName = data.highName;
            highScore = data.highScore;
        }
    }
}
