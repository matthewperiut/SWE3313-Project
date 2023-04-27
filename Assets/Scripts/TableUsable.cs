/// <summary>
/// This script sets the button color based on a randomly generated number and checks whether a code exists in a file to enable the button.
/// </summary>
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TableUsable : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private string code;
    [SerializeField] private Button button;

    private string filePath;
    
    private static Color red = new Color(1f, 0f, 0f, 1f);
    private static Color green = new Color(0f, 1f, 0f, 1f);
    private static Color yellow = new Color(1f, 1f, 0f, 1f);

    void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "user.txt");

        using (StreamReader reader = new StreamReader(filePath))
        {
            // Read the data from the file
            string data = reader.ReadToEnd();
            if (data.Contains(code))
            {
                button.interactable = true;
            }
        }

        int randomInt = Random.Range(0, 3);
        if (randomInt == 0)
            button.image.color = red;
        if (randomInt == 1)
            button.image.color = green;
        if (randomInt == 2)
            button.image.color = yellow;
    }

    /// <summary>
    /// Loads the menu screen.
    /// </summary>
    public void MenuScreen()
    {
        SceneManager.LoadScene("Scenes/menu");
    }
}