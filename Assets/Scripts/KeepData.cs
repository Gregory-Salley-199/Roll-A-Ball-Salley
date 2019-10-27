using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class KeepData : MonoBehaviour
{
    public static string Name = "Anonymous";
    public static int PlayerScore;
    public static int HighScore = 0;
    public static float PlayerSpeed;
    //public static float PickUpSpeed;

    public InputField PlayerName;
    public Slider BallSpeedSlider;
   // public Slider PickUpSpeedSlider;
  

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject); 
    }
    
    public void UpdateName()
    {
        Name = PlayerName.text;
    }
    
    public void ChangeSpeed()
    {
        PlayerSpeed = BallSpeedSlider.value;
       // PickUpSpeed = PickUpSpeedSlider;
    }

   
}