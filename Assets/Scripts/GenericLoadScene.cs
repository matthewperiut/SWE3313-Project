using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GenericLoadScene : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;

    public void LoadStringScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
