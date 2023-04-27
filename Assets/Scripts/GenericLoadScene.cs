using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GenericLoadScene : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;

    /// <summary>
    /// Loads the scene with the name specified in the `sceneToLoad` variable.
    /// </summary>
    public void LoadStringScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
