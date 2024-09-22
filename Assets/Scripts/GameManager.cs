using System.Collections;
using System.Collections.Generic;
using HangingBridge;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int activeBridgeTemplate = 0;
    public static GameManager instance;     //Singelton Instance of the class

    public Timer gameTimer;

    public bool isReloaded;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }


    /// <summary>
    /// Sets active bridge template when main Scene Loads
    /// </summary>
    /// <param name="template"></param>
    public void SetActiveBridgeTemplate(int template)
    {
        activeBridgeTemplate = template;
    }

    private void Start()
    {
        LoadScene();
        isReloaded = false;
        gameTimer.StartTimer();
    }

    /// <summary>
    /// Load the main Scene
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Additive);
    }

    /// <summary>
    /// Reloads scene and sets the isReloaded boolean to true
    /// </summary>
    public void ReloadScene()
    {
        SceneManager.UnloadSceneAsync("MainScene");
        isReloaded = true;
        LoadScene();
    }
}
