/// <summary>
/// This script allows the user to switch between scenes and reload the current scene.
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    //private List<string> sceneHistory = new List<string>(); //this is where we save history of scene
    //[SerializeField]
    //private string scene = "https://google.com";
    [SerializeField] private string sceneToLoad;

    /// <summary>
    /// Reloads the current scene.
    /// </summary>
    public void loadCurrentScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //loading the current scene
    }
    
    /// <summary>
    /// Loads the next scene.
    /// </summary>
    public void goNext() {
        Debug.Log("Next scene loaded");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /// <summary>
    /// Loads the previous scene.
    /// </summary>
    public void goBack() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    /// <summary>
    /// Loads the scene specified by the string name.
    /// </summary>
    public void LoadStringScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    
    /// <summary>
    /// Loads the scene specified by the name.
    /// </summary>
    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    /// <summary>
    /// Loads the login scene.
    /// </summary>
    public void loadLoginScene() {
        SceneManager.LoadScene(2);
    }

    
}
