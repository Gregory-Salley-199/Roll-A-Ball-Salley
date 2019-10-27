using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void StopGame()
    {
        SceneManager.LoadScene("ExitScene");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("IntroScene");
    }
    public void ExitGame()
    {
        
        UnityEditor.EditorApplication.isPlaying = false;
    }
}