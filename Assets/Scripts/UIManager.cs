using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public string startScene;
    public string settingsScene;

    public void StartGame() 
    {
        SceneManager.LoadScene(startScene);
    }

    public void settings() 
    {
        SceneManager.LoadScene(settingsScene);
    }
}
