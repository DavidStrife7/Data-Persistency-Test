using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetHighScore : MonoBehaviour
{
    public void ResetSaveData()
    {
        GameManager.GMinstance.SaveNewHighScore(0);
    }
}
