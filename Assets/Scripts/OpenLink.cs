using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    [SerializeField]
    private string link = "https://google.com";
    
    public void OpenChannel()
    {
        Application.OpenURL(link);
    }
}
