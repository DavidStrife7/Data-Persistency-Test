using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GMinstance;
    public string saveDataName;
    public int score;

    private void Awake()
    {
        if (GMinstance != null)
        {
            Destroy(gameObject);
            return;
        }
        GMinstance = this;
        DontDestroyOnLoad(gameObject);

        LoadBestScore();
    }

    [System.Serializable]
    class SaveData
    {
        public string SaveName;
        public int SavedHighScore;
    }

    public void SaveNewHighScore(int newScore)
    {
        SaveData newData = new SaveData();
        newData.SaveName = saveDataName;
        newData.SavedHighScore = newScore;

        string json = JsonUtility.ToJson(newData);

        File.WriteAllText(Application.persistentDataPath + "/savedata.json", json);
    }

    public void LoadBestScore()
    {
        string saveFilePath = Application.persistentDataPath + "/savedata.json";
        if (File.Exists(saveFilePath))
        {
            string json = File.ReadAllText(saveFilePath);
            SaveData loadData = JsonUtility.FromJson<SaveData>(json);
            saveDataName = loadData.SaveName;
            score = loadData.SavedHighScore;
        }
    }
}
