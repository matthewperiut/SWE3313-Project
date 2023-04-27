/// <summary>
/// This script opens a URL link when a function is called.
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    [SerializeField]
    private string link = "https://google.com";
    
    /// <summary>
    /// Opens the URL link.
    /// </summary>
    public void OpenChannel()
    {
        Application.OpenURL(link);
    }
}
