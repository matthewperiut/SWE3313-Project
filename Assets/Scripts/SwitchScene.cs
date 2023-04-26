using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    private List<string> sceneHistory = new List<string>(); //this is where we save history of scene


    //reload the scene
    public void loadCurrentScene() {
        Debug.Log("Scene Loaded"); //letting you know that the scene loaded
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //loading the current scene
    }
    
    //go forward a scene
    public void goNext() {
        Debug.Log("Next scene loaded");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //go back a scene
    public void goBack() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //switch scene by name 
    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void loadLoginScene() {
        SceneManager.LoadScene(2);
    }

    
}
