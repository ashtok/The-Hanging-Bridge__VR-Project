using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;


public class SceneLoaderEditor : Editor
{
    ///Summary
    ///Adding Menu Item to Open Game Scene
    ///-Summary
    [MenuItem("HangingBridge/Open Game Scene")]
    static void OpenGameScene()
    {
        string sceneName = "GameScene";
        EditorSceneManager.OpenScene("Assets/Scenes/" + sceneName + ".unity");
        Debug.Log("Game started!");
    }

    ///Summary
    ///Adding Menu Item to Open Main Scene
    ///-Summary
    [MenuItem("HangingBridge/Open Main Scene")]
    static void OpenMainScene()
    {
        string sceneName = "MainScene";
        EditorSceneManager.OpenScene("Assets/Scenes/" + sceneName + ".unity");
    }
}