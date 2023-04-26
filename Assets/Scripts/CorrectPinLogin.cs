using System.IO;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class CorrectPinLogin : MonoBehaviour
{
    private string filePath;
    private string userFilePath;
	[SerializeField] private TMP_InputField inputField;
	[SerializeField] private Button logout;

    private void Start()
    {
        // Set the file path based on the current platform and persistent data path
        filePath = Path.Combine(Application.persistentDataPath, "admin.txt");
        userFilePath = Path.Combine(Application.persistentDataPath, "user.txt");
    }

	public void Test()
	{
		string text = inputField.text;
		if (text == "3141")
		{
			inputField.text = "";
			WriteCurrentUser("3141");
			logout.interactable = true;
			SceneManager.LoadScene("Scenes/menu");
		}
		if (text == "5926")
		{
			inputField.text = "";
			WriteCurrentUser("5926");
			logout.interactable = true;
			SceneManager.LoadScene("Scenes/menu");
		}
		if (text == "5358")
		{
			inputField.text = "";
			WriteCurrentUser("5358");
			logout.interactable = true;
			SceneManager.LoadScene("Scenes/menu");
		}
	}

	private void WriteCurrentUser(string username)
	{
		if (File.Exists(userFilePath))
		{
			File.Delete(userFilePath);
		}
		using (StreamWriter writer = new StreamWriter(userFilePath))
		{
			// Write the data to the file
			writer.Write(username);
		}
	}
}
