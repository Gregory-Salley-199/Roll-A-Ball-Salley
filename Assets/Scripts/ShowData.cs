using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text PlayerName;
    public Text BallSpeed;
    public Text HighScore;

    private void Awake()
    {
        PlayerName.text = KeepData.Name;
        BallSpeed.text = KeepData.PlayerSpeed.ToString();
        HighScore.text = "High: " + KeepData.HighScore.ToString();
    }
    
}