using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public string playerName;
    public string bestPlayerName;
    public int bestScore;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

        LoadData();
    }

    [System.Serializable]
    class GameData
    {
        public string playerName;
        public string bestPlayerName;
        public int bestScore;
    }

    public void SaveData()
    {
        GameData data = new GameData();
        data.playerName = playerName;
        data.bestPlayerName = bestPlayerName;
        data.bestScore = bestScore;

        string json=JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath+"/savefile.json",json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            GameData data=JsonUtility.FromJson<GameData>(json);
            playerName = data.playerName;
            bestPlayerName = data.bestPlayerName;
            bestScore = data.bestScore;
        }
    }

    public void ClearRecord()
    {
        playerName = "";
        bestPlayerName = "";
        bestScore = 0;

        SaveData();

    }
}
