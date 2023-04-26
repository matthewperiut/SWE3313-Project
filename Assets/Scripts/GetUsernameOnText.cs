using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GetUsernameOnText : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private TextMeshProUGUI textMesh;
    private string filePath;

    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "user.txt");

        using (StreamReader reader = new StreamReader(filePath))
        {
            // Read the data from the file
            string data = reader.ReadToEnd();
            textMesh.text = data;
        }
    }
}
