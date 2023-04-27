using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using TMPro;

public class LogOut : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Button logout;
    private string filePath;
    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "admin.txt");
        
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read the data from the file
                string data = reader.ReadToEnd();
                bool isAdmin = data.Contains("admin");
                if (isAdmin)
                    logout.interactable = true;
            }
        }
    }
    
    /// <summary>
    /// Deletes the file and disables the logout button.
    /// </summary>
    public void run()
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            logout.interactable = false;
        }
    }
}
