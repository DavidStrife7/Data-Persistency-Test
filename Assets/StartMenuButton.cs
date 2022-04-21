using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuButton : MonoBehaviour
{
    [SerializeField]
    private GameObject inputField;

    // Start is called before the first frame update
    void Start()
    {
        MainManager.HighScoreText.text = "David";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress()
    {
        //playerName = inputField.GetComponent<InputField>().text;
        SceneManager.LoadScene("main");
    }
}
