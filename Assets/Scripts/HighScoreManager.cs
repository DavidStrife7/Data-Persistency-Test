using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class HighScoreManager : MonoBehaviour
{
    private Text highScoreText;
    private string saveFilePath;
    private GameManager GM;

    private void Awake()
    {
        UpdateHighScore();
    }

    public void UpdateHighScore()
    {
        GM = GameManager.GMinstance;
        saveFilePath = Application.persistentDataPath + "/savedata.json";
        highScoreText = GetComponent<Text>();
        highScoreText.text = "Best Score : Name : 0";
        if (File.Exists(saveFilePath))
        {
            highScoreText.text =
                "Best Score : "
                + GM.saveDataName +
                " : "
                + GM.score;
        }
    }
}
